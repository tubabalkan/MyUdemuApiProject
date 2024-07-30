using HotelProject.WebUI.Models.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using MimeKit;
using MailKit.Net.Smtp;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "tubabalkan165@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("user", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder= new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();
            mimeMessage.Subject=model.Subject;
            SmtpClient client = new SmtpClient();
       
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("tubabalkan165@gmail.com", "nqtuocjicqekzymk");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
