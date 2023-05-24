using Netch.Properties;
using Netch.Utils;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Netch.Forms;
[Fody.ConfigureAwait(true)]
public partial class loginForm : Form
{

    public loginForm()
    {
        InitializeComponent();
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textUserName_TextChanged(object sender, EventArgs e)
    {

    }

    private async void buttonLogin_Click(object sender, EventArgs e)
    {
        var url = Constants.BetUserLoginLink;
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "windows-pc");
        List<KeyValuePair<string, string>> formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("name", textUserName.Text),
                new KeyValuePair<string, string>("password", textPassWord.Text)
            };
        var postData = new FormUrlEncodedContent(formData);
        var response = await client.PostAsync(url, postData);
        var content = await response.Content.ReadAsStringAsync();

        //var url = Constants.BetUserLoginLink;
        //var client = new HttpClient();
        //var response = await client.GetAsync($"{url}?username={textUserName}&password={textPassWord}");
        //var content = await response.Content.ReadAsStringAsync();
        try
        {
            var result = JObject.Parse(content);
            var loginValue = (bool)result["login"];
            if (loginValue)
            {

                //处理返回的json数据 存入 data和mode目录下，  data存放服务器信息，mode存放加速的游戏进程名
                //this.returnform.vmessText = (String)result["vmess"];
                //this.returnform._isLogin = true;
                MessageBox.Show("登录成功");
                var servers = result["Servers"];
                Global.IsLogin = true;
                Global.Settings.userName = textUserName.Text;
                Global.Settings.password = textPassWord.Text;
                await Configuration.SaveAsync();
                Configuration.UpdateServerList(servers).Wait();
                await Configuration.SaveAsync();
                Close();
            }
            else
            {
                Global.Settings.userName = "";
                Global.Settings.password = "";
                await Configuration.SaveAsync();
                MessageBox.Show("登录失败");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("登录失败");
        }

    }
}

