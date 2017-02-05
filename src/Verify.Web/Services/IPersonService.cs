using Verify.Models; 

namespace Verify.Services
{
    public interface IPersonService
    {
        Person RetrievePersonBySSN(string ssn);
    }
}
