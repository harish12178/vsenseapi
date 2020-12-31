using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VSense.API.Repositories;
using VSense.API.Models;
using System;
using System.Linq;
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
            var arr=new List<Log>();
            var data=await this.repo.GetRecent();
            foreach (var item in data)
            {
                var result=new Log();
                var assign=this.repo.GetAssignidByDeviceid(item.DeviceID);
                result.device_log=item;
                result.device_assign=assign;
                arr.Add(result);
            }
            return Ok(arr);
        }
        public async Task<IActionResult> GetLog(string deviceID,string pramID){
            var log = await repo.GetLog(deviceID,pramID);
            if (log == null)
            {
                return NotFound("Log  not found");
            }
            return Ok(log);
        }

        public async Task<IActionResult> Log(logWithStatus log)
        {
            var device=await repo.GetDevice(log.DeviceID);
            if(device==null){
                return NotFound($"Device with deviceID={log.DeviceID} not available");
            }
            if(device.isEnabled==false){
                return BadRequest($"Device is disabled please contact administer");
            }
            var ispram="";
            foreach (var item in device.deviceParams)
            {
                if (item.ParamID==log.PramID)
                {
                    ispram=log.PramID;
                    log.minValue=item.Min;
                    log.maxValue=item.Max;
                    break;
                }
            }
            if(ispram==""){
                return NotFound($"Device does not have param={log.PramID} not available");
            }
            var created_log=await repo.CreateLog(log);
            return Ok("Success");
        }
        class DeviceStatus
        {
            public DeviceStatus(DateTime datetime,int count)
            {
                this.date=datetime;
                this.activeCount=count;
            }
            public DateTime date { get; set; }
            public int activeCount { get; set; }
        }
        class DeviceStatusMonth
        {
            public DeviceStatusMonth(int datetime,int count)
            {
                this.month=datetime;
                this.activeCount=count;
            }
            public int month { get; set; }
            public int activeCount { get; set; }
        }
        public IActionResult devicestatus(){
            var datewisedata=repo.getdevicestatus();
            var outdata=new List<DeviceStatus>();
            foreach (var item in datewisedata)
            {
                var deviceanddate=item.ToLookup(t => t.DeviceID);
                outdata.Add(new DeviceStatus(item.Key,deviceanddate.Count));
            }
            return Ok(outdata);
        }
        public IActionResult devicestatusmonth(){
            var datewisedata=repo.getdevicestatusbymonth();
            var outdata=new List<DeviceStatusMonth>();
            foreach (var item in datewisedata)
            {
                var deviceanddate=item.ToLookup(t => t.DeviceID);
                outdata.Add(new DeviceStatusMonth(item.Key,deviceanddate.Count));
            }
            return Ok(outdata);
        }
        
    }
}