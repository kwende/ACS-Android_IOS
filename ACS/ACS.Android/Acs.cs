using ACS.Interfaces;
using Azure.Communication;
using Azure.Communication.Identity;
using Com.Azure.Android.Communication.Calling;
using System;
using System.Threading.Tasks;

namespace ACS.Droid
{
    internal class Acs : IAcs
    {
        private string _acsConnectionString;
        private CommunicationIdentityClient _identityClient;
        private CallClient _callClient;

        public void Initialize(string acsConnectionString)
        {
            _acsConnectionString = acsConnectionString;
            _identityClient = new CommunicationIdentityClient(acsConnectionString);
            _callClient = new CallClient();
        }

        public async Task<string> CreateAccessTokenForUserAsync(string acsUserId, TimeSpan validFor)
        {

            var response = await _identityClient.GetTokenAsync(
                new CommunicationUserIdentifier(acsUserId),
                new[] { CommunicationTokenScope.VoIP },
                validFor);

            return response.Value.Token;
        }

        public void StartCallAsync(string acsCallerToken, string acsCalleeId)
        {
            var callClient = new CallClient();

            var result = callClient.CreateCallAgent(Android.App.Application.Context,
                new Com.Azure.Android.Communication.Common.CommunicationTokenCredential(acsCallerToken),
                new CallAgentOptions());
        }
    }
}