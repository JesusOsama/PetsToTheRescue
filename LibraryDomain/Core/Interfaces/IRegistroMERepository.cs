using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDomain.Core.Entities;

namespace LibraryDomain.Core.Interfaces
{
    public interface IRegistroMERepository
    {
        Task<bool> Delete(int id);
        Task<RegistroMascotaEncontrada> GetRegistroMascotaEncontradaById(int id);
        Task<IEnumerable<RegistroMascotaEncontrada>> GetRegistroMascotaEncontradas();
        Task Insert(RegistroMascotaEncontrada registroME);
        Task<bool> Update(RegistroMascotaEncontrada registroME);
    }
}
