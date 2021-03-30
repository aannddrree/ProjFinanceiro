using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjFinanceiro.Dto;
using ProjFinanceiro.Services;

namespace ProjFinanceiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        private MongoService _mongoService;

        public ReportController()
        {
            _mongoService = new MongoService();
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            return await _mongoService.GetClienteAsync();
        }
    }
}