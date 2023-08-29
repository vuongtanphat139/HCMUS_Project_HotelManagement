using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Partner_Tour_DTO
    {
        private string idTour;
        private string name;
        private string description;
        private string departurePoint;
        private string destinationPoint;
        private string mininumNumber;
        private string maximumNumber;
        private string price;
        private int totalDay;
        private string owner;
        private string supervisor;

        public string IdTour { get => idTour; set => idTour = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string DeparturePoint { get => departurePoint; set => departurePoint = value; }
        public string DestinationPoint { get => destinationPoint; set => destinationPoint = value; }
        public string MininumNumber { get => mininumNumber; set => mininumNumber = value; }
        public string MaximumNumber { get => maximumNumber; set => maximumNumber = value; }
        public string Price { get => price; set => price = value; }
        public int TotalDay { get => totalDay; set => totalDay = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Supervisor { get => supervisor; set => supervisor = value; }

        public Partner_Tour_DTO(string idTour, string name, string description, string departurePoint, string destinationPoint, string mininumNumber, string maximumNumber, string price, int totalDay, string owner, string supervisor)
        {
            this.idTour = idTour;
            this.name = name;
            this.description = description;
            this.departurePoint = departurePoint;
            this.destinationPoint = destinationPoint;
            this.mininumNumber = mininumNumber;
            this.maximumNumber = maximumNumber;
            this.price = price;
            this.totalDay = totalDay;
            this.owner = owner;
            this.supervisor = supervisor;

        }
        public Partner_Tour_DTO()
        {

        }

    }
}