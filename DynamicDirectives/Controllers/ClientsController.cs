using DynamicDirectives.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Linq;

namespace DynamicDirectives.Controllers
{
    [RoutePrefix("api/clients")]
    public class ClientsController : ApiController
    {
        [Route(""), HttpGet]
        [ResponseType(typeof(List<Client>))]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(GetClients());
        }

        [Route("{clientId}/dropdowns"), HttpGet]
        [ResponseType(typeof(List<Client>))]
        public async Task<IHttpActionResult> GetDropDownsByClientId(int clientId)
        {
            return Ok(GetClientDropdowns(clientId));
        }

        private List<Client> GetClients()
        {
            var clients = new List<Client>();
            for (int i = 0; i < 10; i++)
            {
                clients.Add(new Client
                {
                    Id = i,
                    Name = $"client {i}",
                    ClientDropdowns = GetClientDropdowns(i)
                });
            }

            return clients;
        }

        private List<ClientDropdown> GetClientDropdowns(int clientId)
        {
            var clientDropDowns = new List<ClientDropdown>();
            for (int i = 0; i < 10; i++)
            {
                var clientDropDownItems = new List<ClientDropDownItem>();

                for (int j = 0; j < 4; j++)
                {
                    clientDropDownItems.Add(new ClientDropDownItem
                    {
                        Id = j,
                        Value = $"option {j}"
                    });
                }

                

                clientDropDowns.Add(new ClientDropdown
                {
                    ClientId = i,
                    Id = i,
                    DropDownItems = clientDropDownItems
                });
            }

            return clientDropDowns.Where(x => x.ClientId == clientId).ToList();
        }
    }
}
