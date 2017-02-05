using Microsoft.AspNetCore.Mvc;
using Verify.Models;
using Verify.Services; 

namespace Verify.Controllers
{
    public class SearchController : Controller
    {
        private IPersonService _personService; 

        public SearchController(IPersonService personService)
        {
            _personService = personService; 
        }

        [HttpGet]
        public IActionResult Index(string ssn)
        {
            Person requestedPerson = _personService.RetrievePersonBySSN(ssn);
            return View(requestedPerson);
        }  
    }
}
