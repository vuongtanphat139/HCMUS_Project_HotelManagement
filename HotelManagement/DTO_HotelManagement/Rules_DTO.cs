using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_HoTelManagement
{
    public class Rules_DTO
    {
        private string idRule;
        private string name;
        private string content;
        private string createDate;
        private string manager;

        public string IdRule { get => idRule; set => idRule = value; }
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
        public string CreateDate { get => createDate; set => createDate = value; }
        public string Manager { get => manager; set => manager = value; } 

        public Rules_DTO(string idRule, string name, string content, string createDate, string manager) 
        {
            this.idRule=idRule;
            this.name=name;
            this.content=content;
            this.createDate=createDate;
            this.manager=manager;
        }
        public Rules_DTO(string name, string content, string manager)
        {
            this.name = name;
            this.content = content;
            this.manager=manager;  
        }
        public Rules_DTO(string Id)
        {
            this.idRule = Id;
        }
        public Rules_DTO() {}
        public Rules_DTO(string id, string name, string content, string manager)
        {
            this.idRule = id;
            this.name = name;
            this.content = content;
            this.manager = manager;
        }
    }
}
