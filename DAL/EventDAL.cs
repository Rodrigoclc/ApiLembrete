using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Lembrete.API.Interfaces.DAL;
using Lembrete.API.Models;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace Lembrete.API.DAL
{
    public class EventDAL : IEventDALInterface
    {
        private readonly IConfiguration _configuration;
        private readonly string getConnection;
        public EventDAL(IConfiguration configuration)
        {
            _configuration = configuration;
            getConnection = configuration.GetConnectionString("DafaultConnection");
        }
        public async Task<IEnumerable<EventModel?>> CreateEvent(EventDto eventDto)
        {
            using (var connection = new SqlConnection(getConnection))
            {
                string query = $"INSERT INTO Events (IdUser, EventName, EventDate, NoticeDate, FrequencyOfWarnings, WarningMethod) ";
                query += $"VALUES (1, '{eventDto.EventName}', '{eventDto.EventDate}', '{eventDto.NoticeDate}', {(int)eventDto.FrequencyOfWarnings}, {(int)eventDto.WarningMethod});";
                
                return await connection.QueryAsync<EventModel>(query);
            }
        }

        public async Task<IEnumerable<EventModel>> GetAllEvents()
        {
            using (var connection = new SqlConnection(getConnection))
            {
                string query = "SELECT * FROM Events";
                
                return await connection.QueryAsync<EventModel>(query);
            }
        }
    }
}