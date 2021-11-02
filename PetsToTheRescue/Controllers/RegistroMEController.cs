using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDomain.Core.Interfaces;
using LibraryDomain.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetsToTheRescue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroMEController : ControllerBase
    {
        private readonly IRegistroMERepository _registroMERepository;
        public RegistroMEController(IRegistroMERepository registroMERepository)
        {
            _registroMERepository = registroMERepository;
        }
        [HttpGet]
        [Route("GetRegistroMascotaEncontradas")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _registroMERepository.GetRegistroMascotaEncontradas();
            return Ok(customers);

        }
    }
}
