//using Microsoft.AspNetCore.Mvc;
//using ReportsAPI.Contracts;
//using ReportsAPI.Models;
//using ReportsAPI.Services;

//namespace ReportsAPI.Controllers
//{
//    public class AssetsController : ControllerBase
//    {
//        private IRepository<Asset> _azureRepo;

//        public AssetsController(IRepository<Asset> azureRepo)
//        {
//            _azureRepo = azureRepo;
//        }


//        [HttpGet]
//        [Route("api/[action]")]
//        public async Task<IActionResult> CountAllAssets()
//        {
//            var createResponse = await _azureRepo.CountAsync();
//            return Ok(createResponse);
//        }
//    }
//}
