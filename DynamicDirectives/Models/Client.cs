using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDirectives.Models
{
    public class Client
    {
        public Client()
        {
            this.ClientDropdowns = new List<Models.ClientDropdown>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
        public List<ClientDropdown> ClientDropdowns { get; set; }
    }
}