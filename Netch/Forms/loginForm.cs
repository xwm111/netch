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
        var url_A = Constants.BetUserLoginLink_A;
        var url_B = Constants.BetUserLoginLink_B;
        var url = url_B;

        var client = new HttpClient();

        //textUserName和textPassWord 都不许为空
        if (String.IsNullOrEmpty(textUserName.Text) || String.IsNullOrEmpty(textPassWord.Text))
        {
            MessageBox.Show("用户名或密码不能为空");
            return;
        }

        var logtag = false;

        /*
            3bet_a1 3zhg45un  7哥
            3bet_a2 a9y4hg7y  龙哥
            3bet_b1 31ad4kke   其他测试人员
            3bet_b2 pz10y3ec   其他测试人员
         */
        if (textUserName.Text == "3bet_a1" && textPassWord.Text == "3zhg45un")
        {
            logtag = true;
        }
        else if (textUserName.Text == "3bet_a2" && textPassWord.Text == "a9y4hg7y")
        {
            logtag = true;
        }
        else if (textUserName.Text == "3bet_b1" && textPassWord.Text == "31ad4kke")
        {
            logtag = true;
        }
        else if (textUserName.Text == "3bet_b2" && textPassWord.Text == "pz10y3ec")
        {
            logtag = true;
        }
        else
        {
            logtag = false;
        }

        if (!logtag)
        {
            MessageBox.Show("用户名/密码不正确");
            return;
        }


        if (textUserName.Text == "3bet_a1" || textUserName.Text == "3bet_a2")
        {
            url = url_A;
        }
        if (textUserName.Text == "3bet_b1" || textUserName.Text == "3bet_b2")
        {
            url = url_B;
        }
        var response = await client.GetAsync($"{url}?username={textUserName}&password={textPassWord}");

        var content = await response.Content.ReadAsStringAsync();

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

