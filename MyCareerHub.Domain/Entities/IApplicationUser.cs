using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCareerHub.Domain.Entities
{
    public interface IApplicationUser
    {
        string Id { get; }
        string UserName { get; }
        string Email { get; }
        string? FullName { get; }
    }
}