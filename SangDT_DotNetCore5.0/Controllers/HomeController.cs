using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SangDT_DotNetCore5._0.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace SangDT_DotNetCore5._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly Services.SmtpHandling _serviceHandling;

        public HomeController()
        {
            _serviceHandling = new Services.SmtpHandling();
        }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }

            //call a method to send the email
            _serviceHandling.SendEmail(formData.Id, formData.Name, formData.Email, formData.Phone, formData.Note);

            //return Json(formData);

            // send email using gmail smtp
            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.gmail.com");
            //    client.Authenticate("sangdothanh95@gmail.com", "Sungdt@123");

            //    var bodyBuilder = new BodyBuilder
            //    {
            //        HtmlBody = $"<p>{formData.Id}</p> <p>{formData.Name}</p> <p>{formData.Phone}</p> <p>{formData.Email}</p> <p>{formData.Note}</p>",
            //      TextBody = "{formData.Id} \r\n formData.Name} \r\n formData.Phone} \r\n formData.Email} \r\n formData.Note} "
            //    };

            //    var message = new MimeMessage
            //    {
            //        Body = bodyBuilder.ToMessageBody()
            //    };
            //    message.From.Add(new MailboxAddress("Noreply my site", "sangdothanh95@gmail.com"));
            //    message.To.Add(new MailboxAddress("Testing Send Email", formData.Email));
            //    message.Subject = "New context submit data";
            //    client.Send(message);

            //    client.Disconnect(true);
            //}

            TempData["Message"] = "Tks for you. We will contact you shortly!";
            return RedirectToAction("Contact");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
