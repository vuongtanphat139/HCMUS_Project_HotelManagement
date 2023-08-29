using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class ServiceHistory_DTO
    {
        private string idService;
        private string idEmp;
        private string startTime;
        private string endTime;

        public string IdService { get => idService; set => idService = value; }
        public string IdEmp { get => idEmp; set => idEmp = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
    }
}
