using System.Net;
using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using AspNetBlankAppTest.Dto;
using AspNetBlankAppTest.Models;
using AspNetBlankAppTest.Service;
using AspNetBlankAppTest.Repo.Util;
using AspNetBlankAppTest.Exceptions;
using AspNetBlankAppTest.Util.Validation;

namespace AspNetBlankAppTest.Controllers
{
    public class PaymentController : ApiController
    {
        private static readonly FormValidator<PaymentFormDto> payFormValidator = new PayFormValidator();
        private static readonly PayService payService = new PayService(WebApiApplication.DI.Resolve<IRepoFactory>());

        public PaymentController() : base() { }

        [HttpPost]
        public async Task Add([FromBody]PaymentFormDto payForm)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            if (!WebApiApplication.DI.Resolve<SessionTable>().IsActive(payForm.session))
                throw new NotAutorizedException();

            payFormValidator.Validate(payForm);
            await payService.Pay(payForm);

            throw new HttpResponseException(HttpStatusCode.OK);
        }

        [HttpGet]
        public async Task<IEnumerable<PaymentInfo>> GetAll() => await payService.GetAll();

        [HttpGet]
        public async Task<IEnumerable<PaymentInfo>> GetByCreator(int id) => await payService.Get(id);
    }
}
