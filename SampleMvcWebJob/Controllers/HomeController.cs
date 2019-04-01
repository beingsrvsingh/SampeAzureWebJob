using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcWebJob.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://samplewebjobservice.scm.azurewebsites.net/api/");
            // the creds from my .publishsettings file
            //var byteArray = Encoding.ASCII.GetBytes("username:password");

            string userName = "$SampleWebJobService";
            string userPassword = "mQ4cRQeuCshZhltdsB5ZD8jhgwriz9uxv1S4fr6G3929pvYDcGuocCS0cyfh";
            var base64Auth = Convert.ToBase64String(Encoding.Default.GetBytes($"{userName}:{userPassword}"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Auth);
            // POST to the run action for my job
            var response = await client.PostAsync("triggeredwebjobs/WebJobAwesome/run", null);

            return View();
            //return Content("Welcome Web Jobs");
        }

        [HttpPost]
        public async Task<ActionResult> Index(int?id)
        {
            string directory = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
            //Process.Start("C://Users//Saurav//source//repos//SampleWebJob//SampleWebJob//bin//Debug//SampleWebJob.exe");

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://samplewebjobservice.scm.azurewebsites.net/api/");
            // the creds from my .publishsettings file
            //var byteArray = Encoding.ASCII.GetBytes("username:password");

            string userName = "$SampleWebJobService";
            string userPassword = "mQ4cRQeuCshZhltdsB5ZD8jhgwriz9uxv1S4fr6G3929pvYDcGuocCS0cyfh";
            var base64Auth = Convert.ToBase64String(Encoding.Default.GetBytes($"{userName}:{userPassword}"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Auth);
            // POST to the run action for my job
            var response = await client.PostAsync("triggeredwebjobs/WebJobAwesome/run", null);

            return Content("Welcome to Post Web Jobs");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}