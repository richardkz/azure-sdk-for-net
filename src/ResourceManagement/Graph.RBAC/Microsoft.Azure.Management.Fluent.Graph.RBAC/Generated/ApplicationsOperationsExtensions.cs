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
    /// Extension methods for ApplicationsOperations.
    /// </summary>
    public static partial class ApplicationsOperationsExtensions
    {
            /// <summary>
            /// Create a new application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            public static ApplicationInner Create(this IApplicationsOperations operations, ApplicationCreateParametersInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).CreateAsync(parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApplicationInner> CreateAsync(this IApplicationsOperations operations, ApplicationCreateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists applications by filter parameters. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static System.Collections.Generic.IEnumerable<ApplicationInner> List(this IApplicationsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ApplicationInner> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ApplicationInner>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).ListAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists applications by filter parameters. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
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
            public static async Task<System.Collections.Generic.IEnumerable<ApplicationInner>> ListAsync(this IApplicationsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ApplicationInner> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ApplicationInner>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static void Delete(this IApplicationsOperations operations, string applicationObjectId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).DeleteAsync(applicationObjectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IApplicationsOperations operations, string applicationObjectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get an application by object Id. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static ApplicationInner Get(this IApplicationsOperations operations, string applicationObjectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).GetAsync(applicationObjectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an application by object Id. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApplicationInner> GetAsync(this IApplicationsOperations operations, string applicationObjectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update existing application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            public static void Patch(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParametersInner parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).PatchAsync(applicationObjectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update existing application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PatchAsync(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PatchWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get keyCredentials associated with the application by object Id.
            /// Reference: https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static System.Collections.Generic.IEnumerable<KeyCredential> ListKeyCredentials(this IApplicationsOperations operations, string applicationObjectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).ListKeyCredentialsAsync(applicationObjectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get keyCredentials associated with the application by object Id.
            /// Reference: https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<KeyCredential>> ListKeyCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListKeyCredentialsWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update keyCredentials associated with an existing application. Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update keyCredentials of an existing application.
            /// </param>
            public static void UpdateKeyCredentials(this IApplicationsOperations operations, string applicationObjectId, KeyCredentialsUpdateParametersInner parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).UpdateKeyCredentialsAsync(applicationObjectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update keyCredentials associated with an existing application. Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#keycredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update keyCredentials of an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdateKeyCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, KeyCredentialsUpdateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdateKeyCredentialsWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets passwordCredentials associated with an existing application.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static System.Collections.Generic.IEnumerable<PasswordCredential> ListPasswordCredentials(this IApplicationsOperations operations, string applicationObjectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).ListPasswordCredentialsAsync(applicationObjectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets passwordCredentials associated with an existing application.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<PasswordCredential>> ListPasswordCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListPasswordCredentialsWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates passwordCredentials associated with an existing application.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update passwordCredentials of an existing application.
            /// </param>
            public static void UpdatePasswordCredentials(this IApplicationsOperations operations, string applicationObjectId, PasswordCredentialsUpdateParametersInner parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationsOperations)s).UpdatePasswordCredentialsAsync(applicationObjectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates passwordCredentials associated with an existing application.
            /// Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/entity-and-complex-type-reference#passwordcredential-type
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update passwordCredentials of an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdatePasswordCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, PasswordCredentialsUpdateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.UpdatePasswordCredentialsWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
