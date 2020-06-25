using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Configuration
{

    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[] {
                new ApiResource("ApiOne")
                {
                    UserClaims = new [] { "email" }
                }
            };
        }

        public static IEnumerable<Client> Clients()
        {
            return new[] {
                new Client
                {
                    ClientId = "client_id",
                    ClientSecrets = new [] { new Secret("secret".Sha256())},
                    AllowedGrantTypes = IdentityServer4.Models.GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new [] { "ApiOne" },
                },
                new Client
                {
                    ClientId = "client_id_implicit",
                    ClientSecrets = new [] { new Secret("secret".Sha256())},
                    AllowedGrantTypes = IdentityServer4.Models.GrantTypes.Implicit,
                    AllowedScopes = new [] { 
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "ApiOne" 
                    },
                    RedirectUris = new  [] { "http://localhost:54717/signin-oidc" },
                    PostLogoutRedirectUris = { "http://localhost:54717/signout-callback-oidc" }

                }
            };
        }

        public static IEnumerable<ApiScope> Scopes()
        {
            return new[] {
                new ApiScope
                {
                   Name = "ApiOne"
                },
            };
        }

        public static IEnumerable<IdentityResource> IdentityResources()
        {
            return new IdentityResource[] {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<TestUser> Users()
        {
            return new[] {
               new TestUser
               {
                   SubjectId = "1",
                   Username = "mail@akshaytiwari.se",
                   Password = "test@123",
                   Claims = new [] { new Claim("enmail", "mail@akshaytiwari.se" )}
               }
           };

        }

    }
}