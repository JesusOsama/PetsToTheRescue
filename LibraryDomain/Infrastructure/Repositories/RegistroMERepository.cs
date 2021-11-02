using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDomain.Core.Entities;
using LibraryDomain.Core.Interfaces;
using LibraryDomain.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryDomain.Infrastructure.Repositories
{
    public class RegistroMERepository : IRegistroMERepository
    {
        private readonly PetsToTheRescueContext _context;

        public RegistroMERepository(PetsToTheRescueContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<RegistroMascotaEncontrada>> GetRegistroMascotaEncontradas()
        {
            return await _context.RegistroMascotaEncontrada.ToListAsync();
        }

        public async Task<RegistroMascotaEncontrada> GetRegistroMascotaEncontradaById(int id)
        {
            return await _context.RegistroMascotaEncontrada.Where(x => x.IdRegistroMe == id).FirstOrDefaultAsync();
        }
        public async Task Insert(RegistroMascotaEncontrada registroME)
        {
            await _context.RegistroMascotaEncontrada.AddAsync(registroME);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(RegistroMascotaEncontrada registroME)
        {
            var registroMENow = await _context.RegistroMascotaEncontrada.FindAsync(registroME.IdRegistroMe);
            registroMENow.IdDni = registroME.IdDni;
            registroMENow.IdMascota = registroME.IdMascota;
            registroMENow.FechaEncuentro = registroME.FechaEncuentro;
            registroMENow.LugarEncuentro = registroME.LugarEncuentro;

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int id)
        {
            var registroMENow = await _context.RegistroMascotaEncontrada.FindAsync(id);
            if (registroMENow == null)
                return false;

            _context.RegistroMascotaEncontrada.Remove(registroMENow);
            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

    }
}
