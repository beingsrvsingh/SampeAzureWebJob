using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebJob
{
    class Program
    {

       public class Mathmatics
        {
            public int add(int a, int b)
            {
                return a + b;
            }
        }

        static void Main(string[] args)
        {

            //using (var client = new WebClient())
            //{
            //    var values = new NameValueCollection();
            //    values["id"] = "1";

            //    var response = client.UploadValues("http://localhost:61423/", values);

            //    var responseString = Encoding.Default.GetString(response);
            //}

            //Mathmatics c = new Mathmatics();            
            //Console.WriteLine(c.add(1, 2));
            //Console.ReadLine();

            #region Console to Mvc
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:61423/");
            //request.Method = "GET";
            ////specify other request properties

            //try
            //{
            //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:61423/");
            //request.Method = "POST";
            //var data = string.Format("id={0}", Uri.EscapeDataString("1"));
            //StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
            //requestWriter.Write(requestWriter);
            //requestWriter.Close();

            #endregion
        }
    }
}
