using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDirectives.Models
{
    public class ClientDropdown
    {
        public ClientDropdown()
        {
            this.DropDownItems = new List<ClientDropDownItem>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public List<ClientDropDownItem> DropDownItems { get; set; }
    }
}