using ACS.Interfaces;

namespace ACS.Droid
{
    internal class Acs : IAcs
    {


        public void Initialize(string acsConnectionString, string acsUserId)
        {
            _identityClient = new CommunicationIdentityClient(connectionString);
        }
    }
}