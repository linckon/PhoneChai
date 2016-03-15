using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhoneChai.Model;
using PhoneChai.Service;
using PhoneChai.ViewModel;

namespace PhoneChai.WebApp.Controllers
{
    public class PhoneQueryController : ApiController
    {
        public IHttpActionResult Get()
        {
            PhoneService phoneService = new PhoneService(new BusinessDbContext());
            List<PhoneViewModel> phoneViewModels = phoneService.GetAll();
            return Ok(phoneViewModels);
        }
    }
}
