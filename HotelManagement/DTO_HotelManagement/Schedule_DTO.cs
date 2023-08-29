using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Schedule_DTO
    {
        private string idTour;
        private string startTime;
        private string endDTime;

        public string IdTour { get => idTour; set => idTour=value; }
        public string StartTime { get => startTime; set => startTime=value; }
        public string EndDTime { get => endDTime; set => endDTime=value; }

        public Schedule_DTO(string idTour, string startTime, string endDTime)
        {
            this.idTour = idTour;
            this.startTime = startTime;
            this.endDTime = endDTime;

        }

        public Schedule_DTO()
        {
          

        }
    }
}
