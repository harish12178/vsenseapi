using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VSense.API.Models
{
    public class Device_log
    {
        [Key]
        public int LogID { get; set; }
        public string DeviceID { get; set; }
        public string RefID { get; set; }
        public DateTime dateTime { get; set; }
        public string PramID { get; set; }
        public float value { get; set; }
        public float minValue { get; set; }
        public float maxValue { get; set; }
        public float avgValue { get; set; }
        public float Threshold { get; set; }
        // [ForeignKey("DeviceID")]
        // public virtual m_device device { get; set; }
        // [ForeignKey("PramID")]
        // public virtual t_device_assign_param device_Assign_Param { get; set; }
    }
}