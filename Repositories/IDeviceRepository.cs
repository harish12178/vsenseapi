using VSense.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace VSense.API.Repositories
{
    public interface IDeviceRepository
    {

            Task<List<Device_log>> GetAllLogs();
            Task<List<Device_log>> GetRecent();
            Task<Device_log> GetLog(string DeviceID);
            Task<Device_log> CreateLog(Device_log log);
            
            Task<List<m_device>> GetAllDevices();
            Task<List<t_device_assign>> GetAllActiveDevices();
            Task<List<t_device_assign>> GetAllInActiveDevices();
            Task<List<m_device_param>> GetAllDeviceParams();
            Task<List<m_equipment>> GetAllEquipments();
            Task<List<m_Loc>> GetAllLocs();
            // Task<List<m_TrkDo>> GetAllTrkDos();
            Task<List<t_device_assign>> GetAllDeviceassigns();
             Task<List<t_device_assign_param>> GetAllDeviceassignparams();

            Task DeleteDevice(string id);
            Task<m_device> CreateDevice(m_device device);
            Task<m_device> UpdateDevice(m_device device);
            Task DeleteDeviceparam(string id);
            Task<m_device_param> CreateDeviceParam(m_device_param device);
            Task<m_device_param> UpdateDeviceParam(m_device_param device);
            Task DeleteEquipment(string id);
            Task<m_equipment> CreateEquipment(m_equipment device);
            Task<m_equipment> UpdateEquipment(m_equipment device);
            Task DeleteLoc(string id);
            Task<m_Loc> CreateLoc(m_Loc m_Loc);
            Task<m_Loc> UpdateLoc(m_Loc m_Loc);
            // Task DeleteTrkdo(string id);
            // Task<m_TrkDo> CreateTrkdo(m_TrkDo device);
            Task DeleteDeviceAssign(string id);
            Task<t_device_assign> CreateDeviceAssign(t_device_assign device);
            Task<t_device_assign> UpdateDeviceAssign(t_device_assign device);
            Task DeleteDeviceAssignParam(string id);
            Task<t_device_assign_param> CreateDeviceAssignParam(t_device_assign_param device);
            Task<t_device_assign_param> UpdateDeviceAssignParam(t_device_assign_param device);

            Task<m_device> GetDevice(string DeviceID);
            Task<m_device_param> GetDeviceparam(string ParamID);
            Task<m_equipment> GetEquipment(string EquipmentID);
            Task<m_Loc> GetLocation(string LocationID);
            // Task<m_TrkDo> GetTrkDo(string TrkdoID);
            Task<t_device_assign> GetDeviceAssign(int AssignmentID);
            Task<t_device_assign_param> GetDeviceAssignParam(string PramID);

            Task<List<string>> GetDevicesByEquipment(string EquipmentID);
            Task<List<string>> Getalldeviceids();
            Task<List<string>> Getallequipmentids();
            Task<List<string>> Getalllocationids();
            Task<t_device_assign> GetAssignidByDeviceid(string DeviceID);

             

    }
}