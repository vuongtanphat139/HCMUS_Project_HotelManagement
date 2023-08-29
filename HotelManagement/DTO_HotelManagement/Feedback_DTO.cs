using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Feedback_DTO
    {
        private string idSTT;
        private string content;
        private string created_date;
        private string rating;
        private string id_bill;

        public string IdSTT { get => idSTT; set => idSTT = value; }
        public string Content { get => content; set => content = value; }
        public string Created_date { get => created_date; set => created_date = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Id_bill { get => id_bill; set => id_bill = value; }

        public Feedback_DTO(string Id)
        {
            this.idSTT = Id;
        }
        public Feedback_DTO(string idSTT, string content, string created_date, string rating, string id_bill)
        {
            this.idSTT = idSTT;
            this.content = content;
            this.created_date = created_date;
            this.rating = rating;
            this.id_bill = id_bill;
        }
    }
}
