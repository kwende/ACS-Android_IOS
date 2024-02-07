using System;
using System.Threading.Tasks;

namespace ACS.Interfaces
{
    public interface IAcs
    {
        void Initialize(string acsConnectionString);
        Task<string> CreateAccessTokenForUserAsync(string acsUserId, TimeSpan validFor);
    }
}
