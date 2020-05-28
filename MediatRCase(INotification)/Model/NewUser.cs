using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRCase.Model
{
    public class NewUser:INotification
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
