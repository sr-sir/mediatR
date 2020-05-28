using MediatR;
using MediatRCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRCase.Handler
{
    public class NewUserHandler : INotificationHandler<NewUser>
    {
        public Task Handle(NewUser newUser, CancellationToken cancellationToken)
        {
            string str = "用户名：" + newUser.Username + "密码：" + newUser.Password;
            return Task.FromResult(str);
        }
    }
}
