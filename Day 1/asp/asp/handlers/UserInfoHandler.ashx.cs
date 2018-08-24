using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace asp.handlers
{
    /// <summary>
    /// Summary description for UserInfoHandler
    /// </summary>
    public class UserInfoHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string result = "<p style=" + '\u0022' + "font-size: 50px;margin: 0;" + '\u0022' + ">User info:</p>";
            result += "<p>UserHostAddress: " + context.Request.UserHostAddress + "</p>";
            result += "<p>UserAgent: " + context.Request.UserAgent + "</p>";
            result += "<p style=" + '\u0022' +"font-size: 50px;margin: 0;" +'\u0022' + ">File content:</p>" +
                "<div style=" + '\u0022' + "background-color: #B6B6B4;border: 3px double black;" + '\u0022' + ">";

            using (var reader = new StreamReader(@"D:\VSSolutions\asp\asp\abc.abc"))
            {
                while (!reader.EndOfStream)
                {
                    result += reader.ReadLine();
                }
                
            }

            result += "</div>";
            context.Response.Write(result);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}