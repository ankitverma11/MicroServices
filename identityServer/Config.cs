using System;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using IdentityModel;

namespace identityServer
{
    public class Config
    {
        public static IEnumerable<Client> clients =>
            new Client[]
            {
                new Client
                {
                    ClientId ="movieClient",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,//for client authorization
                    ClientSecrets=
                    {
                        new Secret("secret".Sha256())
                    },  //provide token
                    AllowedScopes= {"movieAPI" } //which protact api 
                },
                new Client
                {
                    ClientId ="movies_mvc_client",
                    ClientName="Movies MVC Web Page",
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowRememberConsent = false,
                    RedirectUris = new List<string>()
                    {
                        "https://localhost:5002/signin-oidc",// this is client app port
                    },
                    PostLogoutRedirectUris = new List<string>()
                    {
                        "https://localhost:5002/signout-callback-oidc",
                    },
                     ClientSecrets=
                    {
                        new Secret("secret".Sha256())
                    },  //provide token
                     AllowedScopes = new List<string>()
                     {
                       IdentityServerConstants.StandardScopes.OpenId,
                       IdentityServerConstants.StandardScopes.Profile
                     }
                }

            };

        public static IEnumerable<IdentityResource> identityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()

            };
        public static IEnumerable<ApiResource> apiResources =>
            new ApiResource[]
            {

            };
        public static IEnumerable<ApiScope> apiScopes =>
            new ApiScope[]
            {
                new ApiScope("movieAPI","Movie API")
            };
        public static List<TestUser> testUsers =>
            new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "53aw322",
                    Username = "ankit",
                    Password="ankit",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.GivenName,"ankit"),
                        new Claim(JwtClaimTypes.FamilyName,"verma")
                    }
                }
            };
    }
}
