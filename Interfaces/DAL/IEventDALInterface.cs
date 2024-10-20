using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Models;

namespace Lembrete.API.Interfaces.DAL
{
    public interface IEventDALInterface
    {
        Task<IEnumerable<EventModel?>>  CreateEvent(EventDto eventDto);
        Task<IEnumerable<EventModel>> GetAllEvents();
    }
}