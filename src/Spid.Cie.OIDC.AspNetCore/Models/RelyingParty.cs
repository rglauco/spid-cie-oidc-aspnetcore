﻿using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Spid.Cie.OIDC.AspNetCore.Models;

[ExcludeFromCodeCoverage]
public sealed class RelyingParty
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public string ClientId { get; set; }
    public string ClientName { get; set; }
    public SecurityLevel SecurityLevel { get; set; }
    public string[] AuthorityHints { get; set; }
    public string Issuer { get; set; }
    public TrustMarkDefinition[] TrustMarks { get; set; }
    public X509Certificate2[] OpenIdFederationCertificates { get; set; }
    public X509Certificate2[] OpenIdCoreCertificates { get; set; }
    public string[] Contacts { get; set; }
    public bool LongSessionsEnabled { get; set; }
    public string[] RedirectUris { get; set; }
    public ClaimTypes[] RequestedClaims { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
