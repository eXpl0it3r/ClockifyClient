// <auto-generated/>
#pragma warning disable CS0618
using ClockifyClient.Models;
using ClockifyClient.V1.Workspaces.Item.TimeEntries.Invoiced;
using ClockifyClient.V1.Workspaces.Item.TimeEntries.Item;
using ClockifyClient.V1.Workspaces.Item.TimeEntries.Status;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClockifyClient.V1.Workspaces.Item.TimeEntries
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\workspaces\{workspaceId}\time-entries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TimeEntriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The invoiced property</summary>
        public global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Invoiced.InvoicedRequestBuilder Invoiced
        {
            get => new global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Invoiced.InvoicedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The status property</summary>
        public global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Status.StatusRequestBuilder Status
        {
            get => new global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Status.StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the ClockifyClient.v1.workspaces.item.timeEntries.item collection</summary>
        /// <param name="position">Represents time entry identifier across the system.</param>
        /// <returns>A <see cref="global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Item.TimeEntriesItemRequestBuilder"/></returns>
        public global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Item.TimeEntriesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::ClockifyClient.V1.Workspaces.Item.TimeEntries.Item.TimeEntriesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.Workspaces.Item.TimeEntries.TimeEntriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeEntriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/workspaces/{workspaceId}/time-entries", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.Workspaces.Item.TimeEntries.TimeEntriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeEntriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/workspaces/{workspaceId}/time-entries", rawUrl)
        {
        }
        /// <summary>
        /// Add a new time entry
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.TimeEntryDtoImplV1"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ClockifyClient.Models.TimeEntryDtoImplV1?> PostAsync(global::ClockifyClient.Models.CreateTimeEntryRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ClockifyClient.Models.TimeEntryDtoImplV1> PostAsync(global::ClockifyClient.Models.CreateTimeEntryRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::ClockifyClient.Models.TimeEntryDtoImplV1>(requestInfo, global::ClockifyClient.Models.TimeEntryDtoImplV1.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Add a new time entry
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ClockifyClient.Models.CreateTimeEntryRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ClockifyClient.Models.CreateTimeEntryRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.V1.Workspaces.Item.TimeEntries.TimeEntriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ClockifyClient.V1.Workspaces.Item.TimeEntries.TimeEntriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ClockifyClient.V1.Workspaces.Item.TimeEntries.TimeEntriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TimeEntriesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
