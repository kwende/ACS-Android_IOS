using ACS.Interfaces;
using Azure.Communication;
using Azure.Communication.Identity;
using System;
using System.Threading.Tasks;

namespace ACS.Droid
{
    internal class Acs : IAcs
    {
        private string _acsConnectionString;
        private CommunicationIdentityClient _identityClient;

        public void Initialize(string acsConnectionString)
        {
            _acsConnectionString = acsConnectionString;
            _identityClient = new CommunicationIdentityClient(acsConnectionString);
        }

        public async Task<string> CreateAccessTokenForUserAsync(string acsUserId, TimeSpan validFor)
        {
            var response = await _identityClient.GetTokenAsync(
                new CommunicationUserIdentifier(acsUserId),
                new[] { CommunicationTokenScope.VoIP },
                validFor);

            return response.Value.Token;
        }
    }
}