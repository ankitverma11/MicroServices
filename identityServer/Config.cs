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

            };
        public static List<TestUser> testUsers =>
            new List<TestUser>
            {

            };
    }
}
