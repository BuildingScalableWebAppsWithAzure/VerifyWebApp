using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Verify.Models;
using Verify.Services; 

namespace Verify.Controllers
{
    [Route("api/person")]
    public class ApiController : Controller
    {
        private IPersonService _personService;

        public ApiController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/values/5
        [HttpGet("{ssn}")]
        public Person Get(string ssn)
        {
            Person requestedPerson = _personService.RetrievePersonBySSN(ssn);
            return requestedPerson;
        }
    }
}
