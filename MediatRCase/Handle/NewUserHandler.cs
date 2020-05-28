using MediatR;
using MediatRCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRCase.Handle
{
    public class NewUserHandler : IRequestHandler<NewUser, string>
    {
        public Task<string> Handle(NewUser request, CancellationToken cancellationToken)
        {
            string str = "用户名：" + request.Username + "密码：" + request.Password;
            return Task.FromResult(str);
        }
    }
}
