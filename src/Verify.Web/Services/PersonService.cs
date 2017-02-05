using Verify.Models; 

namespace Verify.Services
{
    /// <summary>
    /// This class handles retrieving a person with a given SSN from the database. 
    /// </summary>
    public class PersonService : IPersonService
    {
        private VerifyContext _verifyContext;

        /// <summary>
        /// Constructor. Our DbContext subclass is injected via the DI controller at runtime. 
        /// </summary>
        /// <param name="verifyContext"></param>
        public PersonService(VerifyContext verifyContext)
        {
            _verifyContext = verifyContext;
        }

        /// <summary>
        /// Retrieves and returns a Person instance identified by their ssn. If no person with the
        /// specified ssn is found in the database, this method returns null. 
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public Person RetrievePersonBySSN(string ssn)
        {
            ssn = RemoveNonNumericCharacters(ssn);
            Person requestedPerson = null;
            if (IsSSNValid(ssn))
            {
                //we have a nine digit SSN. Let's search to see who it belongs to!
                requestedPerson = _verifyContext.Person.Find(ssn);
            }
            return requestedPerson; 
        }

        /// <summary>
        /// Checks to make sure that the supplied SSN is nine characters in length. 
        /// </summary>
        /// <param name="ssn">The social security number that we are validating.</param>
        /// <returns></returns>
        private bool IsSSNValid(string ssn)
        {
            bool isValid = ssn.Length == 9;
            return isValid;
        }

        /// <summary>
        /// Returns a string containing only the numeric characters found in str. 
        /// </summary>
        private string RemoveNonNumericCharacters(string str)
        {
            string result = string.Empty;
            char[] charArray = str.ToCharArray();
            foreach (char currentChar in charArray)
            {
                if (char.IsDigit(currentChar))
                {
                    result += currentChar;
                }
            }
            return result;
        }
    }
}
