using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }

        [HttpPut("UpdateBookingR")]
        public IActionResult UpdateBookingR(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("bbb")]
        public IActionResult bbb(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
        [HttpGet("Last6Book")]
        public IActionResult Last6Book()
        {
            var values = _bookingService.TLast6Booking();
            return Ok(values);
        }
        [HttpGet("BookingAproved")]
        public IActionResult BookingAproved(int id)
        {
            _bookingService.TBookingStatusChangeApproved3(id);
            return Ok();
        }
        [HttpGet("BookingCancel")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }
        [HttpGet("BookingWait")]
        public IActionResult BookingWait(int id)
        {
            _bookingService.TBookingStatusChangeBeklet(id);
            return Ok();
        }
    }
}
