using VSense.API.Models;
using VSense.API.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
namespace VSense.API.Repositories
{
    public class DeviceRepository:IDeviceRepository
    {
        private readonly DeviceContext _context;

        public DeviceRepository(DeviceContext context)
        {
            _context = context;
        }
        public async Task<List<Device_log>> GetAllLogs(){
            return await _context.Device_log.ToListAsync();
        }
        public async Task<List<Device_log>> GetRecent(){
            return await _context.Device_log.OrderByDescending(e=>e.LogID).Take(3).ToListAsync();
            
        }
        public async Task<Device_log> GetLog(string id){
            return await _context.Device_log.OrderByDescending(e=>e.LogID).FirstOrDefaultAsync(data=>data.DeviceID==id);
        }
        public async Task<Device_log> CreateLog(Device_log log){
                log.dateTime=DateTime.Now;
                var new_log=await _context.Device_log.AddAsync(log);
                await _context.SaveChangesAsync();
                return new_log.Entity;
        }
        public async Task<m_device> CreateDevice(m_device device){
                device.createdOn=DateTime.Now;
                device.isEnabled=true;
                var new_log=await _context.m_device.AddAsync(device);
                await _context.SaveChangesAsync();
                return new_log.Entity;
        }
        public async Task<m_device> UpdateDevice(m_device device){
            var result = await _context.m_device.FirstOrDefaultAsync(e => e.DeviceID == device.DeviceID);
                result.DeviceID = device.DeviceID;
                result.Name = device.Name;
                result.Purpose = device.Purpose;
                result.PuttoUse=device.PuttoUse;
                result.Battery=device.Battery;
                result.Healthy=device.Healthy;
                result.SoftwareVersion=device.SoftwareVersion;
                result.Vcc=device.Vcc;
                result.Lifespan=device.Lifespan;
                result.modifiedOn=DateTime.Now;
                result.modifiedBy=device.modifiedBy;
                result.isEnabled=device.isEnabled;
                await _context.SaveChangesAsync();
                return result;
        }
        public async Task<m_device_param> CreateDeviceParam(m_device_param device){
                device.createdOn=DateTime.Now;
                device.isEnabled=true;
                var new_log=await _context.m_device_param.AddAsync(device);
                await _context.SaveChangesAsync();
                return new_log.Entity;
        }
        public async Task<m_device_param> UpdateDeviceParam(m_device_param device){
            var result = await _context.m_device_param.FirstOrDefaultAsync(e => e.ParamID == device.ParamID);
                result.DeviceID = device.DeviceID;
                result.ParamID = device.ParamID;
                result.Title = device.Title;
                result.Unit=device.Unit;
                result.longText=device.longText;
                result.Max=device.Max;
                result.Min=device.Min;
                result.Icon=device.Icon;
                result.isPercentage=device.isPercentage;
                result.Color=device.Color;
                result.isEnabled=device.isEnabled;
                result.modifiedBy=device.modifiedBy;
                result.modifiedOn=DateTime.Now;
                await _context.SaveChangesAsync();
                return result;
        }
        public async Task<m_equipment> CreateEquipment(m_equipment device){
                device.createdOn=DateTime.Now;
                device.isEnabled=true;
                var new_log=await _context.m_equipment.AddAsync(device);
                await _context.SaveChangesAsync();
                return new_log.Entity;   
        }
        public async Task<m_equipment> UpdateEquipment(m_equipment device){
            var result = await _context.m_equipment.FirstOrDefaultAsync(e => e.EquipmentID == device.EquipmentID);
                result.EquipmentID = device.EquipmentID;
                result.Text = device.Text;
                result.GeoLoc = device.GeoLoc;
                result.Plant=device.Plant;
                result.Workcenter=device.Workcenter;
                result.modifiedOn=DateTime.Now;
                result.isEnabled=device.isEnabled;
                result.modifiedBy=device.modifiedBy;
                await _context.SaveChangesAsync();
                return result;   
        }
        public async Task<m_Loc> CreateLoc(m_Loc device){
                device.createdOn=DateTime.Now;
                device.isEnabled=true;
                var new_log=await _context.m_Loc.AddAsync(device);
                await _context.SaveChangesAsync();
                return new_log.Entity;    
        }
        public async Task<m_Loc> UpdateLoc(m_Loc device){
            var result = await _context.m_Loc.FirstOrDefaultAsync(e => e.LocationID == device.LocationID);
                result.LocationID = device.LocationID;
                result.LcoationText = device.LcoationText;
                result.WorkCenter = device.WorkCenter;
                result.Plant=device.Plant;
                result.Geo=device.Geo;
                result.ParantLocationID=device.ParantLocationID;
                result.isEnabled=device.isEnabled;
                result.modifiedOn=DateTime.Now;
                result.modifiedBy=device.modifiedBy;
                await _context.SaveChangesAsync();
                return result;   
        }

        
        public async Task<t_device_assign> CreateDeviceAssign(t_device_assign device){
                device.createdOn=DateTime.Now;
                device.isEnabled=true;
                var new_log=await _context.t_device_assign.AddAsync(device);
                await _context.SaveChangesAsync();
                return new_log.Entity;
        }
        public async Task<t_device_assign> UpdateDeviceAssign(t_device_assign device){
            var result = await _context.t_device_assign.FirstOrDefaultAsync(e => e.DeviceID == device.DeviceID);
                result.DeviceID = device.DeviceID;
                result.EquipmentID = device.EquipmentID;
                result.StDateTime = device.StDateTime;
                result.enDateTime=device.enDateTime;
                result.Frequency=device.Frequency;
                result.LocID=device.LocID;
                result.isEnabled=device.isEnabled;
                result.modifiedOn=DateTime.Now;
                result.modifiedBy=device.modifiedBy;
                await _context.SaveChangesAsync();
                return result;  
        }
        public async Task<t_device_assign_param> CreateDeviceAssignParam(t_device_assign_param device){
                device.createdOn=DateTime.Now;
                device.isEnabled=true;
                var new_log=await _context.t_device_assign_param.AddAsync(device);
                await _context.SaveChangesAsync();
                return new_log.Entity;           
        }
        public async Task<t_device_assign_param> UpdateDeviceAssignParam(t_device_assign_param device){
            var result = await _context.t_device_assign_param.FirstOrDefaultAsync(e => e.PramID == device.PramID);
                result.assignmentID = device.assignmentID;
                result.PramID = device.PramID;
                result.Title = device.Title;
                result.Unit=device.Unit;
                result.longText=device.longText;
                result.Max=device.Max;
                result.Min=device.Min;
                result.Icon=device.Icon;
                result.Soft_1_Exception_Threshold=device.Soft_1_Exception_Threshold;
                result.Soft_2_Exception_Threshold=device.Soft_2_Exception_Threshold;
                result.Hard_1_Exception_Threshold=device.Hard_1_Exception_Threshold;
                result.Hard_2_Exception_Threshold=device.Hard_2_Exception_Threshold;
                result.ActivityGraphTitle=device.ActivityGraphTitle;
                result.isEnabled=device.isEnabled;
                result.modifiedOn=DateTime.Now;
                result.modifiedBy=device.modifiedBy;
                await _context.SaveChangesAsync();
                return result;        
        }


        public async Task<List<m_device>> GetAllDevices(){
            return await _context.m_device.ToListAsync();
        }
        public async Task<List<t_device_assign>> GetAllActiveDevices(){
            return await _context.t_device_assign.Where(o=>o.device.isEnabled==true).ToListAsync();
        }
        public async Task<List<t_device_assign>> GetAllInActiveDevices(){
            return await _context.t_device_assign.Where(o=>o.device.isEnabled==false).ToListAsync();;
        }
        public async Task<List<m_device_param>> GetAllDeviceParams(){
            return await _context.m_device_param.ToListAsync();
        }
        public async Task<List<m_equipment>> GetAllEquipments(){
            return await _context.m_equipment.ToListAsync();
        }
        public async Task<List<m_Loc>> GetAllLocs(){
            return await _context.m_Loc.ToListAsync();
        }
        // public async Task<List<m_TrkDo>> GetAllTrkDos(){
        //     return await _context.m_TrkDo.ToListAsync();
        // }
        public async Task DeleteDevice(string Id){
            var result = await _context.m_device.FirstOrDefaultAsync(device => device.DeviceID == Id);
            if (result != null)
            {
                _context.m_device.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteDeviceparam(string Id){
            var result = await _context.m_device_param.FirstOrDefaultAsync(device => device.ParamID == Id);
            if (result != null)
            {
                _context.m_device_param.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteEquipment(string Id){
            var result = await _context.m_equipment.FirstOrDefaultAsync(device => device.EquipmentID == Id);
            if (result != null)
            {
                _context.m_equipment.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteLoc(string Id){
            var result = await _context.m_Loc.FirstOrDefaultAsync(device => device.LocationID == Id);
            if (result != null)
            {
                _context.m_Loc.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        // public async Task DeleteTrkdo(string Id){
        //     var result = await _context.m_TrkDo.FirstOrDefaultAsync(device => device.TrkDoID == Id);
        //     if (result != null)
        //     {
        //         _context.m_TrkDo.Remove(result);
        //         await _context.SaveChangesAsync();
        //     }
        // }
        public async Task DeleteDeviceAssign(string Id){
            var result = await _context.t_device_assign.FirstOrDefaultAsync(device => device.DeviceID == Id);
            if (result != null)
            {
                _context.t_device_assign.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteDeviceAssignParam(string Id){
            var result = await _context.t_device_assign_param.FirstOrDefaultAsync(device => device.PramID == Id);
            if (result != null)
            {
                _context.t_device_assign_param.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<m_device> GetDevice(string id){
            return await _context.m_device.FirstOrDefaultAsync(data=>data.DeviceID==id);
        }
        public async Task<t_device_assign_param> GetDeviceAssignParam(string id){
            return await _context.t_device_assign_param.FirstOrDefaultAsync(data=>data.PramID==id);
        }
        public async Task<t_device_assign> GetDeviceAssign(int id){
            return await _context.t_device_assign.FirstOrDefaultAsync(data=>data.assignmentID==id);
        }
        public async Task<m_device_param> GetDeviceparam(string id){
            return await _context.m_device_param.FirstOrDefaultAsync(data=>data.ParamID==id);
        }
        public async Task<m_equipment> GetEquipment(string id){
            return await _context.m_equipment.FirstOrDefaultAsync(data=>data.EquipmentID==id);
        }
        public async Task<m_Loc> GetLocation(string id){
            return await _context.m_Loc.FirstOrDefaultAsync(data=>data.LocationID==id);
        }
        // public async Task<m_TrkDo> GetTrkDo(string id){
        //     return await _context.m_TrkDo.FirstOrDefaultAsync(data=>data.TrkDoID==id);
        // }

        public async Task<List<string>> GetDevicesByEquipment(string id){
            return await _context.t_device_assign.Where(data=>data.EquipmentID==id).Select(data=>data.DeviceID).ToListAsync();
        }
        public async Task<List<string>> Getalldeviceids(){
            return await _context.m_device.Select(data=>data.DeviceID).ToListAsync();
        }
        public async Task<List<string>> Getallequipmentids(){
            return await _context.m_equipment.Select(data=>data.EquipmentID).ToListAsync();
        }
        public async Task<List<string>> Getalllocationids(){
            return await _context.m_Loc.Select(data=>data.LocationID).ToListAsync();
        }
        public async Task<t_device_assign> GetAssignidByDeviceid(string id){
            return await _context.t_device_assign.FirstOrDefaultAsync(data=>data.DeviceID==id);
        }

        public async Task<List<t_device_assign>> GetAllDeviceassigns(){
            return await _context.t_device_assign.ToListAsync();
        }
        public async Task<List<t_device_assign_param>> GetAllDeviceassignparams(){
            return await _context.t_device_assign_param.ToListAsync();
        }
    }
}