using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Enums;

namespace Lembrete.API.Models
{
    public class EventModel
    {
        public int IdEvent { get; set; } = 0;
        public int IdUser { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
        public string NoticeDate { get; set; }
        public FrequencyOfWarningsEnum FrequencyOfWarnings { get; set; } = FrequencyOfWarningsEnum.dia;
        public WarningMethodEnum WarningMethod { get; set; } = WarningMethodEnum.whatsApp;
    }
}