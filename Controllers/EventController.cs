using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Interfaces.RULE;
using Lembrete.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lembrete.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventInterface _eventInterface;
        public EventController(IEventInterface eventInterface)
        {
            _eventInterface = eventInterface;
        }
        [Route("eventos")]
        [HttpPost]
        public async Task<ActionResult<ResponseModel<EventModel>>> CreateEvent(EventDto eventDto)
        {
            return Ok( await _eventInterface.CreateEvent(eventDto) );
        }
        [Route("eventos")]
        [HttpGet]
        public async Task<ActionResult<ResponseModel<EventModel>>> GetAllEvents()
        {
            return Ok( await _eventInterface.GetAllEvents() );
        }
    }
}