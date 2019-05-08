using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Arch.Api.Models;
using Arch.Cqrs.Client.Command.Customer;
using Arch.Cqrs.Client.Query.Customer.Models;
using Arch.Cqrs.Client.Query.Customer.Queries;
using Arch.Cqrs.Client.Test;
using Arch.Cqrs.Contracts;
using Arch.Cqrs.Contracts.DomainNotifications;
using Arch.Cqrs.Contracts.Paging;
using Arch.Domain;
using Arch.Domain.Core;
using Arch.Domain.Repository;
using Arch.Domain.Specifications;

namespace Arch.Api.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private readonly IProcessor _processor;
        private readonly ICustomerRepository _customerRepository;
        private readonly NotificationContext _notificationContext;

        public CustomersController(IProcessor processor, NotificationContext notificationContext, ICustomerRepository customerRepository)
        {
            _processor = processor;
            _notificationContext = notificationContext;
            _customerRepository = customerRepository;
        }

        [HttpGet, Route("")]
        public IHttpActionResult Get([FromUri]Paging<Customer> paging, string search = null)
        {
            var specification = new CustomerPremium().And(new CustomerOfAge());

           var customers = _customerRepository.FindCustomers<CustomerDto>(specification, paging);

            return Ok(customers);
        }


        [HttpGet, Route("")]
        public IHttpActionResult Get([FromUri]Paging<Customer> paging, bool premium, bool ofAge, string search = null)
        {
            var spec = Specification<Customer>.All;
            if (premium)
            {
                spec.And(new CustomerPremium());
            }

            if (ofAge)
            {
                spec.And(new CustomerOfAge());
            }
           
            var resultOk = _customerRepository.FindCustomers<CustomerDto>(spec, paging);
            return Ok(resultOk);
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
