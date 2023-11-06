using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo1_1018_net_request.MyDemo1
{
    public partial class DestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //输出参数值
            Response.Write("<br />输出参数值:<br />");
            if (Request.Params["name"] != null)
                Response.Write("参数 name:" + Request.Params["name"].ToString() + "<br />");
            else
                Response.Write("无参数 name。<br />");
            if (Request.Params["birthday"] != null)
                Response.Write("参数 birthday:" + Request.Params["name"].ToString() + "<br />");
            else
                Response.Write("无参数 birthday。<br />");

            if (!Page.IsPostBack)
            {
                {   //输出Request对象的属性值	
                    Response.Write("ApplicationPath属性:" + Request.ApplicationPath.ToString() + "<br />");
                    Response.Write("Cookies属性:" + Request.Cookies.ToString() + "<br />");
                    //Cookie中包含的信息可以是用户的偏好设置、登录状态、购物车内容等。
                    //微软邮箱保持登录状态，就是通过cookie保存账户密码，再登录outlook邮箱时再把信息发回服务器
                    //即实现打开邮箱网页就登录上
                    Response.Write("FilePath属性:" + Request.FilePath.ToString()
                    + "<br />");
                    Response.Write("HttpMethod属性:" + Request.HttpMethod.ToString()
                    + "<br />");
                    Response.Write("Path属性:" + Request.Path.ToString() + "<br />");
                    Response.Write("PathInfo属性:" + Request.PathInfo.ToString()
                    + "<br />");
                    Response.Write("PhysicalApplicationPath属性:" +
                    Request.PhysicalApplicationPath.ToString() + "<br />");
                    Response.Write("PhysicalPath属性:" + Request.PhysicalPath.ToString()
                    + "<br />");
                    Response.Write("QueryString属性:" + Request.QueryString.ToString()
                    + "<br />");
                    Response.Write("RawUrl 属性:" + Request.RawUrl.ToString() + "<br />");
                    Response.Write("RequestType属性:" + Request.RequestType.ToString()
                    + "<br />");
                    Response.Write("Url属性:" + Request.Url.ToString() + "<br />");
                    Response.Write("UrlReferrer属性:" + Request.UrlReferrer.ToString()
                    + "<br />");
                }
                //结束输出
                Response.End();
            }

        }
    }
}