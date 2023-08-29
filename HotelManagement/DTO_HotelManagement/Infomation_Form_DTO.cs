using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public  class Infomation_Form_DTO
    {
        private string idInformationForm;
        private string type;
        private string arrivalDate;
        private int numberRooms;
        private int numberStays;
        private string specialRequirements;

        public string IdInformationForm { get => idInformationForm; set => idInformationForm=value; }
        public string Type { get => type; set => type=value; }
        public string ArrivalDate { get => arrivalDate; set => arrivalDate=value; }
        public int NumberRooms { get => numberRooms; set => numberRooms=value; }
        public int NumberStays { get => numberStays; set => numberStays=value; }
        public string SpecialRequirements { get => specialRequirements; set => specialRequirements=value; }


        public Infomation_Form_DTO()
        {

        }
        public Infomation_Form_DTO(string idInformationForm, string type, string arrivalDate, int numberRooms, int numberStays, string specialRequirements)
        {
            this.idInformationForm= idInformationForm;
            this.type= type;
            this.arrivalDate= arrivalDate;
            this.numberRooms= numberRooms;
            this.numberStays= numberStays;
            this.specialRequirements= specialRequirements;
        }
       
    }
}
