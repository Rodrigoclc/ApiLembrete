using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Models;

namespace Lembrete.API.Interfaces.RULE
{
    public interface IEventInterface
    {
        Task<ResponseModel<IEnumerable<EventModel>>> CreateEvent(EventDto eventDto);
        Task<ResponseModel<IEnumerable<EventModel>>> GetAllEvents();
    }
}