using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualStudio.Threading;
using Netch.JsonConverter;
using Netch.Models;
using Netch.Servers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Netch.Utils;

public static class Configuration
{
    /// <summary>
    ///     数据目录
    /// </summary>
    public static string DataDirectoryFullName => Path.Combine(Global.NetchDir, "data");

    public static string FileFullName => Path.Combine(DataDirectoryFullName, FileName);

    private static string BackupFileFullName => Path.Combine(DataDirectoryFullName, BackupFileName);

    private const string FileName = "settings.json";

    private const string BackupFileName = "settings.json.bak";

    private static readonly AsyncReaderWriterLock _lock = new(null);

    private static readonly JsonSerializerOptions JsonSerializerOptions = Global.NewCustomJsonSerializerOptions();

    static Configuration()
    {
        JsonSerializerOptions.Converters.Add(new ServerConverterWithTypeDiscriminator());
        JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    }

    public static async Task LoadAsync()
    {
        try
        {
            if (!File.Exists(FileFullName))
            {
                await SaveAsync();
                return;
            }

            await using var _ = await _lock.ReadLockAsync();

            if (await LoadCoreAsync(FileFullName))
                return;

            Log.Information("Load backup configuration \"{FileName}\"", BackupFileFullName);
            await LoadCoreAsync(BackupFileFullName);
        }
        catch (Exception e)
        {
            Log.Error(e, "Load configuration failed");
            Environment.Exit(-1);
        }
    }

    private static async ValueTask<bool> LoadCoreAsync(string filename)
    {
        try
        {
            Setting settings;

            await using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
            {
                settings = (await JsonSerializer.DeserializeAsync<Setting>(fs, JsonSerializerOptions))!;
            }

            CheckSetting(settings);
            Global.Settings = settings;
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Load configuration file \"{FileName}\" error ", filename);
            return false;
        }
    }

    private static void CheckSetting(Setting settings)
    {
        settings.Profiles.RemoveAll(p => p.ServerRemark == string.Empty || p.ModeRemark == string.Empty);

        if (settings.Profiles.Any(p => settings.Profiles.Any(p1 => p1 != p && p1.Index == p.Index)))
            for (var i = 0; i < settings.Profiles.Count; i++)
                settings.Profiles[i].Index = i;

        settings.AioDNS.ChinaDNS = DnsUtils.AppendPort(settings.AioDNS.ChinaDNS);
        settings.AioDNS.OtherDNS = DnsUtils.AppendPort(settings.AioDNS.OtherDNS);
    }

    /// <summary>
    ///     保存配置
    /// </summary>
    public static async Task SaveAsync()
    {
        if (_lock.IsWriteLockHeld)
            return;

        try
        {
            await using var _ = await _lock.WriteLockAsync();
            Log.Verbose("Save Configuration");

            if (!Directory.Exists(DataDirectoryFullName))
                Directory.CreateDirectory(DataDirectoryFullName);

            var tempFile = Path.Combine(DataDirectoryFullName, FileFullName + ".tmp");
            await using (var fileStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                await JsonSerializer.SerializeAsync(fileStream, Global.Settings, JsonSerializerOptions);
            }

            await EnsureConfigFileExistsAsync();

            File.Replace(tempFile, FileFullName, BackupFileFullName);
        }
        catch (Exception e)
        {
            Log.Error(e, "Save Configuration error");
        }
    }

    private static async ValueTask EnsureConfigFileExistsAsync()
    {
        if (!File.Exists(FileFullName))
        {
            await using var fs = new FileStream(FileFullName, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, true);
        }
    }

    public static async Task UpdateServerList(JToken? servers)
    {
        try
        {
            if (!File.Exists(FileFullName))
            {
                await SaveAsync();
                return;
            }

            await using var _ = await _lock.ReadLockAsync();

            if (await LoadCoreAsync(FileFullName,servers))
                return;

            Log.Information("Load backup configuration \"{FileName}\"", BackupFileFullName);
            await LoadCoreAsync(BackupFileFullName, servers);
        }
        catch (Exception e)
        {
            Log.Error(e, "Load configuration failed");
            Environment.Exit(-1);
        }
    }

    private static async ValueTask<bool> LoadCoreAsync(string filename, JToken? servers)
    {
        try
        {
            Setting settings;

            await using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
            {
                settings = (await JsonSerializer.DeserializeAsync<Setting>(fs, JsonSerializerOptions))!;
            }

            CheckSetting(settings);
            settings.Server = new List<Server>();
            //将登录获取到的server更新到本地
            JArray jArray = (JArray)servers;
            foreach (JToken element in jArray)
            {
                
                JObject jObject = (JObject)element;
                JToken typeValue = jObject["Type"];
                if (typeValue.ToString() == "VMess")
                {
                    
                    VMessServer server = JsonConvert.DeserializeObject<VMessServer>(jObject.ToString());
                    settings.Server.Add(server);
                }
                else if (typeValue.ToString() == "Vless")
                {
                    VLESSServer server = JsonConvert.DeserializeObject<VLESSServer>(jObject.ToString());
                    settings.Server.Add(server);
                }
                else if (typeValue.ToString() == "SS")
                {
                    ShadowsocksServer server = JsonConvert.DeserializeObject<ShadowsocksServer>(jObject.ToString());
                    settings.Server.Add(server);
                }
                else if (typeValue.ToString() == "SSR")
                {
                    ShadowsocksRServer server = JsonConvert.DeserializeObject<ShadowsocksRServer>(jObject.ToString());
                    settings.Server.Add(server);
                }
                else if (typeValue.ToString() == "Trojan")
                {
                    TrojanServer server = JsonConvert.DeserializeObject<TrojanServer>(jObject.ToString());
                    settings.Server.Add(server);
                }

            }


            Global.Settings = settings;
            return true;
        }
        catch (Exception e)
        {
            Log.Error(e, "Load configuration file \"{FileName}\" error ", filename);
            return false;
        }
    }
}