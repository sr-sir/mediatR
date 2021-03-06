﻿using MediatR;
using MediatRCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRCase.Handler
{
    public class EmailHandler : INotificationHandler<NewUser>
    {
        public Task Handle(NewUser newUser, CancellationToken cancellationToken)
        {
            string str = "第二步";
            return Task.FromResult(str);
        }
    }
}
