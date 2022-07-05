using Microsoft.AspNetCore.Mvc;
using ReportsAPI.Contracts;
using ReportsAPI.Models;

namespace ReportsAPI.Controllers
{
    public class ReportsController : ControllerBase
    {
        private IRepository<Asset> _azureRepoA;
        private IRepository<Vendor> _azureRepoV;
        private IRepository<Warranty> _azureRepoW;
        private IRepository<IotDevice> _azureRepoD;



        public ReportsController(IRepository<Asset> azureRepo, IRepository<Vendor> azureRepoV, IRepository<Warranty> azureRepoW, IRepository<IotDevice> azureRepoD)
        {
            _azureRepoA = azureRepo;
            _azureRepoV = azureRepoV;
            _azureRepoW = azureRepoW;
            _azureRepoD = azureRepoD;
        }


        [HttpGet]
        [Route("api/[action]")]
        public async Task<IActionResult> CountAllAssets()
        {
            var createResponse = await _azureRepoA.CountAsync();
            return Ok(createResponse);
        }

        [HttpGet]
        [Route("api/[action]")]
        public async Task<IActionResult> CountAllVendors()
        {
            var createResponse = await _azureRepoV.CountAsync();
            return Ok(createResponse);
        }

        [HttpGet]
        [Route("api/[action]")]
        public async Task<IActionResult> CountAllWarranties()
        {
            var createResponse = await _azureRepoW.CountAsync();
            return Ok(createResponse);
        }

        [HttpGet]
        [Route("api/[action]")]
        public async Task<IActionResult> CountAllIotDevices()
        {
            var createResponse = await _azureRepoD.CountAsync();
            return Ok(createResponse);
        }
    }
}
