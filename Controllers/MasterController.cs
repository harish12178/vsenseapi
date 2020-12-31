using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VSense.API.Repositories;
using VSense.API.Models;
using System.Collections.Generic;
namespace VSense.API.Controllers
{
    [Route("VSenseAPI/[controller]/[action]")]
    [ApiController]
    public class MasterController:ControllerBase
    {
        private readonly IDeviceRepository repo;
        public MasterController(IDeviceRepository repository)
        {
            this.repo=repository;
        }
        public async Task<IActionResult> GetAllDevices(){
            return Ok(await this.repo.GetAllDevices());
        }
        public async Task<IActionResult> GetAllActiveDevices(){
            return Ok(await this.repo.GetAllActiveDevices());
        }
        public async Task<IActionResult> GetAllInactiveDevices(){
            return Ok(await this.repo.GetAllInActiveDevices());
        }
        public async Task<IActionResult> GetAllDeviceParams(){
            return Ok(await this.repo.GetAllDeviceParams());
        }
        public async Task<IActionResult> GetAllEquipments(){
            return Ok(await this.repo.GetAllEquipments());
        }
        public async Task<IActionResult> GetAllLocs(){
            return Ok(await this.repo.GetAllLocs());
        }
        // public async Task<IActionResult> GetAllTrkDos(){
        //     return Ok(await this.repo.GetAllTrkDos());
        // }
        public async Task<IActionResult> device(m_device device)
        {
            if(await repo.GetDevice(device.DeviceID)!=null){
                return BadRequest("device already exists");
            }
            var created=await repo.CreateDevice(device);
            return Ok(created);
            
        }
        public async Task<IActionResult> deviceparam(m_device_param device)
        {
            var created=await repo.CreateDeviceParam(device);
            return Ok(created);
        }
        public async Task<IActionResult> equipment(m_equipment device)
        {
            if(await repo.GetEquipment(device.EquipmentID)!=null){
                return BadRequest("equipment already exists");
            }
            var created=await repo.CreateEquipment(device);
            return Ok(created);
        }
        public async Task<IActionResult> location(m_Loc device)
        {
            if(await repo.GetLocation(device.LocationID)!=null){
                return BadRequest("location already exists");
            }
            var created=await repo.CreateLoc(device);
            return Ok(created);
        }
        public async Task<IActionResult> deviceupdate(m_device device)
        {
            var created=await repo.UpdateDevice(device);
            return Ok(created);
        }
        public async Task<IActionResult> deviceparamupdate(m_device_param device)
        {
            var created=await repo.UpdateDeviceParam(device);
            return Ok(created);
        }
        public async Task<IActionResult> equipmentupdate(m_equipment device)
        {
            var created=await repo.UpdateEquipment(device);
            return Ok(created);
        }
        public async Task<IActionResult> locationupdate(m_Loc device)
        {
            var created=await repo.UpdateLoc(device);
            return Ok(created);
        }
        
        public async Task<IActionResult> deletedevice(string id){
            await repo.DeleteDevice(id);
            return Ok();

        }
        public async Task<IActionResult> deletedeviceparam(string deviceid,string paramid){
            await repo.DeleteDeviceparam(deviceid,paramid);
            return Ok();

        }
        public async Task<IActionResult> deleteequipment(string id){
            await repo.DeleteEquipment(id);
            return Ok();
        }
        public async Task<IActionResult> deletelocation(string id){
            await repo.DeleteLoc(id);
            return Ok();
        }
        // public async Task<IActionResult> deletetrkdo(string id){
        //     await repo.DeleteTrkdo(id);
        //     return Ok();
        // }

        public async Task<IActionResult> getdevice(string deviceID){
            var log = await repo.GetDevice(deviceID);

            if (log == null)
            {
                return NotFound($"Device with deviceID = {deviceID} not found");
            }

            return Ok(log);
        }
        public async Task<IActionResult> getdeviceparam(string paramID){
            var log = await repo.GetDeviceparam(paramID);

            if (log == null)
            {
                return NotFound($"DeviceParam with paramID = {paramID} not found");
            }

            return Ok(log);
        }
        public async Task<IActionResult> getequipment(string equipmentID){
            var log = await repo.GetEquipment(equipmentID);

            if (log == null)
            {
                return NotFound($"Equipment with equipmentID = {equipmentID} not found");
            }

            return Ok(log);
        }
        public async Task<IActionResult> getlocation(string locationID){
            var log = await repo.GetLocation(locationID);

            if (log == null)
            {
                return NotFound($"Location with locationID = {locationID} not found");
            }

            return Ok(log);
        }
        // public async Task<IActionResult> getrkdo(string trkdoID){
        //     var log = await repo.GetTrkDo(trkdoID);

        //     if (log == null)
        //     {
        //         return NotFound($"TrkDo with trkdoID = {trkdoID} not found");
        //     }

        //     return Ok(log);
        // }

        public async Task<IActionResult> getalldeviceid(){
            return Ok(await repo.Getalldeviceids());
        }
        public async Task<IActionResult> getallequipmentid(){
            return Ok(await repo.Getallequipmentids());
        }
        public async Task<IActionResult> getalllocationid(){
            return Ok(await repo.Getalllocationids());
        }
        public IActionResult getparamgroup(){
            return Ok(repo.GetParamGroup());
        }
        public async Task<IActionResult> paramgroup(List<m_device_param> device)
        {
            var created=await repo.createparamgroup(device);
            return Ok(created);
        }
        public async Task<IActionResult> updateparamgroup(List<m_device_param> device)
        {
            var created=await repo.updateparamgroup(device);
            return Ok(created);
        }
    }
}