using Netch.Properties;
using Netch.Utils;
using Newtonsoft.Json.Linq;
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

        var result = JObject.Parse(content);
        var loginValue = (bool)result["login"];
        if (loginValue)
        {

            //处理返回的json数据 存入 data和mode目录下，  data存放服务器信息，mode存放加速的游戏进程名
            //this.returnform.vmessText = (String)result["vmess"];
            //this.returnform._isLogin = true;
            MessageBox.Show("登录成功");
            var servers = result["Servers"];
            Configuration.UpdateServerList(servers).Wait();
            await Configuration.SaveAsync();
            Global.IsLogin = true;
            Close();
        }
        else
        {
            MessageBox.Show("登录失败");
        }
    }
}

