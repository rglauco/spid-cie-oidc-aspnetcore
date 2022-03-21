﻿using Spid.Cie.OIDC.AspNetCore.Models;
using Spid.Cie.OIDC.AspNetCore.OpenIdFederation;
using System.Threading.Tasks;

namespace Spid.Cie.OIDC.AspNetCore.Tests.Mocks;

internal class MockTrustChainManager : ITrustChainManager
{
    public async Task<IdPEntityConfiguration?> BuildTrustChain(string url)
    {
        await Task.CompletedTask;
        return new IdPEntityConfiguration()
        {
            Issuer = url
        };
    }
}
