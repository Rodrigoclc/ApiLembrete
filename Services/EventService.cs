using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Interfaces.DAL;
using Lembrete.API.Interfaces.RULE;
using Lembrete.API.Models;
using Newtonsoft.Json;

namespace Lembrete.API.Services
{
    public class EventService : IEventInterface
    {
        private readonly IEventDALInterface _eventDALInterface;
        public EventService(IEventDALInterface eventDALInterface)
        {
            _eventDALInterface = eventDALInterface;
        }
        public async Task<ResponseModel<IEnumerable<EventModel>>> CreateEvent(EventDto eventDto)
        {
            ResponseModel<IEnumerable<EventModel>> responseModel = new();

            try
            {
                responseModel.ResponseObject = await _eventDALInterface.CreateEvent(eventDto);
            }
            catch (Exception ex)
            {
                responseModel.Message = $"erro: {ex.Message}";
                responseModel.MessageType = Enums.MessageTypeEnum.error;
                responseModel.Success = false;
            }

            return responseModel;
        }

        public async Task<ResponseModel<IEnumerable<EventModel>>> GetAllEvents()
        {
            ResponseModel<IEnumerable<EventModel>> responseModel = new();

            try
            {
                responseModel.ResponseObject = await _eventDALInterface.GetAllEvents();
            }
            catch (Exception ex)
            {
                responseModel.Message = $"erro: {ex.Message}";
                responseModel.MessageType = Enums.MessageTypeEnum.error;
                responseModel.Success = false;
            }

            return responseModel;
        }
    }
}