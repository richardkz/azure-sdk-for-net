// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ServicePrincipalsOperations.
    /// </summary>
    public static partial class ServicePrincipalsOperationsExtensions
    {
            /// <summary>
            /// Creates a service principal in the  directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create a service principal.
            /// </param>
            public static ServicePrincipalInner Create(this IServicePrincipalsOperations operations, ServicePrincipalCreateParametersInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).CreateAsync(parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a service principal in the  directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create a service principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServicePrincipalInner> CreateAsync(this IServicePrincipalsOperations operations, ServicePrincipalCreateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ServicePrincipalInner> List(this IServicePrincipalsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ServicePrincipalInner> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ServicePrincipalInner>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).ListAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ServicePrincipalInner>> ListAsync(this IServicePrincipalsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ServicePrincipalInner> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ServicePrincipalInner>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes service principal from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to delete service principal information.
            /// </param>
            public static void Delete(this IServicePrincipalsOperations operations, string objectId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).DeleteAsync(objectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes service principal from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to delete service principal information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IServicePrincipalsOperations operations, string objectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets service principal information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            public static ServicePrincipalInner Get(this IServicePrincipalsOperations operations, string objectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).GetAsync(objectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets service principal information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServicePrincipalInner> GetAsync(this IServicePrincipalsOperations operations, string objectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get keyCredentials associated with the service principal by object Id.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            public static System.Collections.Generic.IEnumerable<KeyCredential> ListKeyCredentials(this IServicePrincipalsOperations operations, string objectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).ListKeyCredentialsAsync(objectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get keyCredentials associated with the service principal by object Id.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<KeyCredential>> ListKeyCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListKeyCredentialsWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update keyCredentials associated with an existing service principal.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update keyCredentials of an existing service principal.
            /// </param>
            public static void UpdateKeyCredentials(this IServicePrincipalsOperations operations, string objectId, KeyCredentialsUpdateParametersInner parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).UpdateKeyCredentialsAsync(objectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update keyCredentials associated with an existing service principal.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update keyCredentials of an existing service principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdateKeyCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, KeyCredentialsUpdateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdateKeyCredentialsWithHttpMessagesAsync(objectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets passwordCredentials associated with an existing service principal.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            public static System.Collections.Generic.IEnumerable<PasswordCredential> ListPasswordCredentials(this IServicePrincipalsOperations operations, string objectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).ListPasswordCredentialsAsync(objectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets passwordCredentials associated with an existing service principal.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<PasswordCredential>> ListPasswordCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListPasswordCredentialsWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates passwordCredentials associated with an existing service principal.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update passwordCredentials of an existing service principal.
            /// </param>
            public static void UpdatePasswordCredentials(this IServicePrincipalsOperations operations, string objectId, PasswordCredentialsUpdateParametersInner parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).UpdatePasswordCredentialsAsync(objectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates passwordCredentials associated with an existing service principal.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Object id to get service principal information.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update passwordCredentials of an existing service principal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdatePasswordCredentialsAsync(this IServicePrincipalsOperations operations, string objectId, PasswordCredentialsUpdateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdatePasswordCredentialsWithHttpMessagesAsync(objectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for list operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ServicePrincipalInner> ListNext(this IServicePrincipalsOperations operations, string nextLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicePrincipalsOperations)s).ListNextAsync(nextLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets list of service principals from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ServicePrincipalInner>> ListNextAsync(this IServicePrincipalsOperations operations, string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
