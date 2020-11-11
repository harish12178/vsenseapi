using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VSense.API.Repositories;
using VSense.API.Models;
namespace VSense.API.Controllers
{
    [Route("VSenseAPI/[controller]/[action]")]
    [ApiController]
    public class AssignmentController:ControllerBase
    {
        private readonly IDeviceRepository repo;
        public AssignmentController(IDeviceRepository repository)
        {
            this.repo=repository;
            
        }
        
        public async Task<IActionResult> getdevices(string equipmentid){
            var log = await repo.GetDevicesByEquipment(equipmentid);
            return Ok(log);
        }
        public async Task<IActionResult> getassingidbydeviceid(string assignmentid){
            var log = await repo.GetAssignidByDeviceid(assignmentid);
            return Ok(log);
        }

        public async Task<IActionResult> getalldeviceassigns(){
            return Ok(await this.repo.GetAllDeviceassigns());
        }
        public async Task<IActionResult> getalldeviceassignparams(){
            return Ok(await this.repo.GetAllDeviceassignparams());
        }

        public async Task<IActionResult> deviceassign(t_device_assign device)
        {
            if(await repo.GetDeviceAssign(device.assignmentID)!=null){
                return BadRequest("assignment already exists");
            }
            var created=await repo.CreateDeviceAssign(device);
            return Ok(created);
        }
        public async Task<IActionResult> updatedeviceassign(t_device_assign device)
        {
            var created=await repo.UpdateDeviceAssign(device);
            return Ok(created);
        }
        public async Task<IActionResult> deletedeviceassign(string id){
            await repo.DeleteDeviceAssign(id);
            return Ok();

        }
        public async Task<IActionResult> deviceassignparam(t_device_assign_param device)
        {
            if(await repo.GetDeviceAssignParam(device.PramID)!=null){
                return BadRequest("PramID already exists");
            }
            var created=await repo.CreateDeviceAssignParam(device);
            return Ok(created);
        }
        public async Task<IActionResult> updatedeviceassignparam(t_device_assign_param device)
        {
            var created=await repo.UpdateDeviceAssignParam(device);
            return Ok(created);
        }
        public async Task<IActionResult> deletedeviceassignparam(string id){
            await repo.DeleteDeviceAssign(id);
            return Ok();

        }
    }
}