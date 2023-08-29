using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Supply_Form_DTO
    {
        private string idInformation;
        private string groupName;
        private string registeredName;
        private int  groupSize;

        public string IdInformation { get => idInformation; set => idInformation=value; }
        public string GroupName { get => groupName; set => groupName=value; }
        public string RegisteredName { get => registeredName; set => registeredName=value; }
        public int GroupSize { get => groupSize; set => groupSize=value; }

        public Supply_Form_DTO(string idInformation, string groupName, string registeredName, int groupSize)
        {
            this.idInformation= idInformation;
            this.groupName= groupName;
            this.registeredName= registeredName;
            this.groupSize= groupSize;
        }
        public Supply_Form_DTO(string registeredName)
        {
            this.registeredName = registeredName;
        }    
    }
}
