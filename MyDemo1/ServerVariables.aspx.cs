using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo1_1018_net_request.MyDemo1
{
    public partial class ServerVariables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        //第三行代码定义了一个名为Page_Load的方法，该方法是一个事件处理程序，用于处理页面的Load事件。
        //protected关键字表示该方法只能在当前类或其子类中访问，void表示该方法没有返回值，
        //object sender和EventArgs e表示该方法的参数。
        {
            if (!Page.IsPostBack)
                //当用户在地址栏中输入页面的URL并按下回车键时，页面会被第一次加载。
                //此时，Page.IsPostBack的值为false，表示页面不是由回发引起的重新加载。
                //通过链接跳转到新页面就可满足条件
            { //输出服务器环境变量值
                Response.Write("使用ServerVariables属性获得服务器环境变量:"
                + "<br /><br />");
                Response.Write("客户端的ip、主机名、服务器的主机名、端口"
                + "<br /><br />");
                //
                int i;
                //取得所有的键
                String[] arrl=Request.ServerVariables.AllKeys; 
                for (i = 0; i < arrl.Length; i++)
                {

                    Response.Write("Key:" + arrl[i] + "<br />");
                    Response.Write("Val:" + Request.ServerVariables[arrl[i]].ToString() + "<br /><br />");
                }
            }


            //结束输出
            Response.End();

        }
    }
}