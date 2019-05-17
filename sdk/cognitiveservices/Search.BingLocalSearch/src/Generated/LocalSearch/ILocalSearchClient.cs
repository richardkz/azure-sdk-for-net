// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.LocalSearch
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Local Search client lets you send a search query to Bing and get
    /// back search results that include local businesses such as restaurants,
    /// hotels, retail stores, or other local businesses. The query can specify
    /// the name of the local business or it can ask for a list (for example,
    /// restaurants near me).
    /// </summary>
    public partial interface ILocalSearchClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the ILocal.
        /// </summary>
        ILocal Local { get; }

    }
}