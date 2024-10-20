using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lembrete.API.Enums;

namespace Lembrete.API.Models
{
    public class ResponseModel <T>
    {
        public T? ResponseObject { get; set; }
        public bool Success { get; set; } = true;
        public string? Message { get; set; } = "Operação realizada com sucesso.";
        public MessageTypeEnum MessageType { get; set; } = MessageTypeEnum.success;
    }
}