using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Enums;

namespace Lembrete.API.Models
{
    public class EventDto
    {
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string NoticeDate { get; set; }
        public FrequencyOfWarningsEnum FrequencyOfWarnings { get; set; }
        public WarningMethodEnum WarningMethod { get; set; }
    }
}