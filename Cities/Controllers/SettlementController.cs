using BL.IService;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettlementController : ControllerBase
    {
        private readonly IServiceSettlement serviceSettlement;
        public SettlementController(IServiceSettlement serviceSettlement)
        {
            this.serviceSettlement = serviceSettlement;
        }

       
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Settlement>>> GetAll()
        {
            var cities= await serviceSettlement.GetAll();
            return Ok(cities);
        }


        [HttpPost("Add")]
        public async Task<ActionResult<Settlement>> Add(Settlement settlement)
        {
            return await serviceSettlement.Add(settlement);
        }


        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await serviceSettlement.Delete(id);
        }


        [HttpPut("Update")]
        public async Task<ActionResult<Settlement>> Update(Settlement settlement)
        {
            return await serviceSettlement.Update(settlement);
        }
    }
}
