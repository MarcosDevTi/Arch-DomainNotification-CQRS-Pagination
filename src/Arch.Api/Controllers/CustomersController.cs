using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Arch.Cqrs.Client.Command.Customer;
using Arch.Cqrs.Client.Query.Customer.Models;
using Arch.Cqrs.Client.Query.Customer.Queries;
using Arch.Cqrs.Client.Test;
using Arch.Cqrs.Contracts;
using Arch.Cqrs.Contracts.DomainNotifications;
using Arch.Cqrs.Contracts.Paging;

namespace Arch.Api.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private readonly IProcessor _processor;
        private readonly NotificationContext _notificationContext;

        public CustomersController(IProcessor processor, NotificationContext notificationContext)
        {
            _processor = processor;
            _notificationContext = notificationContext;
        }

        [HttpGet, Route("")]
        public IHttpActionResult Get([FromUri]Paging<CustomerIndex> paging, string search = null)
        {
            return Ok(_processor.Get(new GetCustomersIndex(paging, search)));
        }

        [HttpGet, Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customers
        [HttpPost, Route("")]
        public async Task<HttpResponseMessage> Post([FromBody]CreateCustomer customer)
        {
           
            _processor.Send(customer);

            if(_notificationContext.HasNotifications)

                return Request.CreateResponse(HttpStatusCode.BadRequest, _notificationContext.Notifications);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
