using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactservice;

        public ContactController(IContactService contactservice)
        {
            _contactservice = contactservice;
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactservice.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date=Convert.ToDateTime(DateTime.Now.ToString());
            _contactservice.TInsert(contact);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _contactservice.TGetById(id);
            _contactservice.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Contact contact)
        {
            _contactservice.TUpdate(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _contactservice.TGetById(id);
            return Ok(values);
        }
        [HttpGet("sendmessage/{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactservice.TGetById(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            return Ok(_contactservice.TGetContactCount());
        }



    }
}
