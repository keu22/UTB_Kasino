using Kasino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kasino.Application.Abstraction
{
    public interface IUserService
    {
        List<User> GetAll();
    }
}
