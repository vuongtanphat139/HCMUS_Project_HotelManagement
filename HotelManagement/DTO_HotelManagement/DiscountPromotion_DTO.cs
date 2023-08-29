using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class DiscountPromotion_DTO
    {
        private string idDiscount;
        private string name;
        private string startTime;
        private string endTime;
        private string description;
        private int requirement;
        private float discountRate;
        private string typeDiscount;
        public string IdDiscount { get => idDiscount; set => idDiscount = value; }
        public string Name { get => name; set => name = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public string Description { get => description; set => description = value; }
        public int Requirement { get => requirement; set => requirement = value; }
        public float DiscountRate { get => discountRate; set => discountRate = value; }
        public string TypeDiscount { get => typeDiscount; set => typeDiscount = value; }

        public DiscountPromotion_DTO() { }
        public DiscountPromotion_DTO(String idDiscount) {
            this.idDiscount = idDiscount;
        }

        public DiscountPromotion_DTO(String Name, string startDate, string endDate, string Descript, String type, float PercentDiscount, int amountRequiment)
        {
            this.name = Name;
            this.startTime= startDate;
            this.endTime = endDate;
            this.description = description;
            this.typeDiscount = type;
            this.discountRate= PercentDiscount; 
            this.requirement= amountRequiment;  
        }

        public DiscountPromotion_DTO(string idDiscount, string Name, string startDate, string endDate, string Descript, String type, float PercentDiscount, int amountRequiment)
        {
            this.idDiscount = idDiscount;
            this.name = Name;
            this.startTime = startDate;
            this.endTime = endDate;
            this.description = description;
            this.typeDiscount = type;
            this.discountRate = PercentDiscount;
            this.requirement = amountRequiment;
        }
        public DiscountPromotion_DTO(string startTime, string endTime){
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public DiscountPromotion_DTO(string idDiscount, string name, string startTime, string endTime, string description, int requirement, float discountRate, int k)
        {
            IdDiscount = idDiscount;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            Requirement = requirement;
            DiscountRate = discountRate;
            IdDiscount = idDiscount;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            Requirement = requirement;
            DiscountRate = discountRate;
        }
    }
}
