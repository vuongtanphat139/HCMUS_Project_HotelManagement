using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Service_Form_DTO
    {
        private string idServiceForm;
        private string name;
        private string description;
        private int price;
        private int amount;
        private string idService;
        private string formCreator;
        private string customer;


        public string IdServiceForm { get => idServiceForm; set => idServiceForm=value; }
        public string Name { get => name; set => name=value; }
        public string Description { get => description; set => description=value; }
        public int Price { get => price; set => price=value; }
        public int Amount { get => amount; set => amount=value; }
        public string IdService { get => idService; set => idService=value; }
        public string FormCreator { get => formCreator; set => formCreator=value; }
        public string Customer { get => customer; set => customer=value; }
        public Service_Form_DTO( string idServiceForm, string name, string description, int price, int amount, string idService, string formCreator, string customer)
        {
            this.idServiceForm=idServiceForm;
            this.name=name;
            this.description=description;
            this.price=price;
            this.amount=amount;
            this.idService=idService;
            this.formCreator=formCreator;
            this.customer=customer;
        }
           
    }
}
