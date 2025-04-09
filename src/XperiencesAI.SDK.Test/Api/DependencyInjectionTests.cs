/*
 * Xperiences API
 *
 * API for VR mentoring experiences
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: support@xperiences.ai
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Extensions;
using Xunit;

namespace XperiencesAI.SDK.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                BearerToken bearerToken1 = new("<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(bearerToken1);
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                BearerToken bearerToken1 = new("<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(bearerToken1);
                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    BearerToken bearerToken1 = new("<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(bearerToken1);
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    BearerToken bearerToken1 = new("<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(bearerToken1);
                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var agentsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAgentsApi>();
            Assert.True(agentsApi.HttpClient.BaseAddress != null);

            var chatApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IChatApi>();
            Assert.True(chatApi.HttpClient.BaseAddress != null);

            var healthApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IHealthApi>();
            Assert.True(healthApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var agentsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAgentsApi>();
            Assert.True(agentsApi.HttpClient.BaseAddress != null);

            var chatApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IChatApi>();
            Assert.True(chatApi.HttpClient.BaseAddress != null);

            var healthApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IHealthApi>();
            Assert.True(healthApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var agentsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAgentsApi>();
            Assert.True(agentsApi.HttpClient.BaseAddress != null);
            
            var chatApi = _hostUsingAddWithAClient.Services.GetRequiredService<IChatApi>();
            Assert.True(chatApi.HttpClient.BaseAddress != null);
            
            var healthApi = _hostUsingAddWithAClient.Services.GetRequiredService<IHealthApi>();
            Assert.True(healthApi.HttpClient.BaseAddress != null);
            
            var usersApi = _hostUsingAddWithAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var agentsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAgentsApi>();
            Assert.True(agentsApi.HttpClient.BaseAddress != null);

            var chatApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IChatApi>();
            Assert.True(chatApi.HttpClient.BaseAddress != null);

            var healthApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IHealthApi>();
            Assert.True(healthApi.HttpClient.BaseAddress != null);

            var usersApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IUsersApi>();
            Assert.True(usersApi.HttpClient.BaseAddress != null);
        }
    }
}
