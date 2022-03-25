using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

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
                }

            };

        public static IEnumerable<IdentityResource> identityResources =>
            new IdentityResource[]
            {

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

            };
    }
}
