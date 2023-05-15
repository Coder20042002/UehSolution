using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.Entities;

namespace Ueh.Application.Service
{
    public interface IRegisterService
    {
        Task<List<Dangkycuoi>> GetAll();
        Task<List<Dangkycuoi>> Get(int id);
        Task Delete(int id);
    }
}
