﻿using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Spid.Cie.OIDC.AspNetCore.Resources;
using Spid.Cie.OIDC.AspNetCore.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Spid.Cie.OIDC.AspNetCore.Configuration;

internal class ConfigurationManager : IConfigurationManager<OpenIdConnectConfiguration>
{
    private readonly IIdentityProviderSelector _idpSelector;

    public ConfigurationManager(IIdentityProviderSelector idpSelector)
    {
        _idpSelector = idpSelector;
    }

    public async Task<OpenIdConnectConfiguration> GetConfigurationAsync(CancellationToken cancel)
        => (await _idpSelector.GetSelectedIdentityProvider())?.EntityConfiguration?.Metadata?.OpenIdProvider
            ?? throw new Exception(ErrorLocalization.IdentityProviderNotFound);

    public void RequestRefresh() { }
}