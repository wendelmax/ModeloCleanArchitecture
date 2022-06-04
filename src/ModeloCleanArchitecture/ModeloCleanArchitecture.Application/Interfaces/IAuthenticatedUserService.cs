using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloCleanArchitecture.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
