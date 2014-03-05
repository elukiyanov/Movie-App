using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data.SqlClient;
using MovieApp.Models;
using System.Net;
using System.IO;
using System.Text;


namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        
        }



        [HttpPost]
        public ActionResult Index(string btnClick)
        {

          /*  if (btnClick == "Update Movies")
            {

                string urlAddress = "http://www.imdb.com/chart/top";
              


                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;
                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }
                    string data = readStream.ReadToEnd();
                    response.Close();
                    readStream.Close();



                    //Split table data
                  
                    int start = data.IndexOf("<tbody>");
                    
                   
                    data = data.Substring(start);
                    int end = data.IndexOf("</tbody>");
                    int total = data.Count();

                    data = data.Substring(0, end);

                    int i = 5;


                }


                
            }*/

            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
