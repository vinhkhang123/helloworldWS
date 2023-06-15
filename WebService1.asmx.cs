using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HelloW
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Name = "Hello wooorld",Namespace = "localhost:50357/" , Description="hello may cung")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string helau(string str)
        {
            return "Hello "+str;
        }
        [WebMethod]
        public double cong(double a,double b)
        {
            double kq=a+b;
            return kq;
        }
        [WebMethod]
        public double tru(double a, double b)
        {
            double kq = a - b;
            return kq;
        }
        [WebMethod]
        public double nhan(double a, double b)
        {
            double kq = (a * b);
            return kq;
        }
        [WebMethod]
        public double chia(double a, double b)
        {
            double kq = (a / b);
            return kq;
        }
        [WebMethod]
        public string batnhat(double a, double b)
        {
            string kl = "";


        

            if (a == 0)
            {

                if (b == 0)
                {

                    kl = "pt vo so nghiem";

                } else
                    {
                        kl = "pt vo  nghiem";
                    }
            }
            else
            {
                double kq = (-b / a);
                kl = "pt co nghiem " + kq;
            }
           
         
            return kl;
        }
        [WebMethod]
        public string batnhat1(double a, double b)
        {
            string kl = "";




            if (a == 0 && b == 0)
            {
                kl = "pt vo  nghiem";

            }
            else if (b == 0)
            {
                kl = "pt vo so nghiem";
            }
            else
            {
                double kq = (-b / a);
                kl = "pt co nghiem " + kq;
            }
                return kl;
        }
    }
}
