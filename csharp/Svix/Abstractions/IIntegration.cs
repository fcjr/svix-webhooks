﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Svix.Model;
using Svix.Models;

namespace Svix.Abstractions
{
    public interface IIntegration
    {
        IntegrationOut Create(string appId, IntegrationIn integration, string idempotencyKey = default);

        Task<IntegrationOut> CreateAsync(string appId, IntegrationIn integration, string idempotencyKey = default,
            CancellationToken cancellationToken = default);

        bool Delete(string appId, string integrationId, string idempotencyKey = default);

        Task<bool> DeleteAsync(string appId, string integrationId, string idempotencyKey = default,
            CancellationToken cancellationToken = default);

        IntegrationOut Get(string appId, string integrationId, string idempotencyKey = default);

        Task<IntegrationOut> GetAsync(string appId, string integrationId, string idempotencyKey = default, CancellationToken cancellationToken = default);

        string GetKey(string appId, string integrationId, string idempotencyKey = default);

        Task<string> GetKeyAsync(string appId, string integrationId, string idempotencyKey = default,
            CancellationToken cancellationToken = default);

        List<IntegrationOut> List(string appId, ListOptions options, string idempotencyKey = default);

        Task<List<IntegrationOut>> ListAsync(string appId, ListOptions options, string idempotencyKey = default,
            CancellationToken cancellationToken = default);

        string RotateKey(string appId, string integrationId, string idempotencyKey = default);

        Task<string> RotateKeyAsync(string appId, string integrationId, string idempotencyKey = default,
            CancellationToken cancellationToken = default);

        IntegrationOut Update(string appId, string integrationId, IntegrationUpdate integration, string idempotencyKey = default);

        Task<IntegrationOut> UpdateAsync(string appId, string integrationId, IntegrationUpdate integration, string idempotencyKey = default, CancellationToken cancellationToken = default);
    }
}