using ApiOdev.Business.Models;
using ApiOdev.Business.Services.ManagerServices;
using ApiOdev.Business.VMs;
using ApiOdev.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ApiOdev.Controllers
{
    [Route("api")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerService _managerService;

        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }

        [HttpPost]
        [Route("manager/add")]
        public async Task<IActionResult> Add(ManagerViewModel model)
        {
            await _managerService.AddManager(model);
            return Ok(model);
           
        }

        [HttpGet]
        [Route("manager/list")]
        public async Task<IActionResult> List()
        {
            var list=await _managerService.ListOfManagers();
            return Ok(list);
        }

        [HttpPut]
        [Route("manager/edit")]
        public async Task<IActionResult> Edit(string email,ManagerViewModel model)
        {
            var data = await _managerService.EditGet(email);
            
           
            if(data==null)
            {
                return NotFound();
            }

            await _managerService.EditPost(model);
           
            return Ok(data);
        }

        [HttpGet]
        [Route("manager/details")]
        public async Task<IActionResult> Details(string email)
        {
            var data = await _managerService.Details(email);
            return Ok(data);
        }

        [HttpDelete]
        [Route("manager/delete")]
        public async Task<IActionResult> Delete(string email)
        {
           await _managerService.Delete(email);
           return NoContent();
        }



    }
}
