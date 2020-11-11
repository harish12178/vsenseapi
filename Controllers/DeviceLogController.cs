using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VSense.API.Repositories;
using VSense.API.Models;
namespace VSense.API.Controllers
{
    [Route("VSenseAPI/[controller]/[action]")]
    [ApiController]
    public class DeviceLogController:ControllerBase
    {
        private readonly IDeviceRepository repo;
        public DeviceLogController(IDeviceRepository repository)
        {
            this.repo=repository;
        }
        public async Task<IActionResult> GetAllLogs(){
            return Ok(await this.repo.GetAllLogs());
        }
        public async Task<IActionResult> Getrecentlogs(){
            return Ok(await this.repo.GetRecent());
        }
        public async Task<IActionResult> GetLog(string deviceID){
            var log = await repo.GetLog(deviceID);

            if (log == null)
            {
                return NotFound($"Log with deviceID = {deviceID} not found");
            }

            return Ok(log);
        }

        public async Task<IActionResult> Log(Device_log log)
        {
            var device=await repo.GetDevice(log.DeviceID);
            var pram=await repo.GetDeviceAssignParam(log.PramID);
            if(device==null){
                return NotFound($"Device with deviceID={log.DeviceID} not available");
            }
            if(pram==null){
                return NotFound($"Device with pramID={log.PramID} not available");
            }
            if(device.DeviceID!=pram.device_assign.DeviceID){
                return BadRequest($"PramID={log.PramID} not assigned to DeviceID= {log.DeviceID}");
            }
            if(device.isEnabled==false){
                return BadRequest($"Device is disabled please contact administer");
            }
            var created_log=await repo.CreateLog(log);
            return Ok("success");
        }
        
    }
}