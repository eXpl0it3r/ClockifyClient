// <auto-generated/>
#pragma warning disable CS0618
using ClockifyClient.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\workspaces\{workspaceId}\balance\policy\{policyId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithPolicyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/workspaces/{workspaceId}/balance/policy/{policyId}{?page*,page%2Dsize*,sort*,sort%2Dorder*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/workspaces/{workspaceId}/balance/policy/{policyId}{?page*,page%2Dsize*,sort*,sort%2Dorder*}", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint is deprecated. It will be available until 1st of July 2025. Use [Balance](#tag/Balance/operation/getBalancesForPolicy) instead.
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.BalancesWithCountDtoV1"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ClockifyClient.Models.BalancesWithCountDtoV1?> GetAsync(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder.WithPolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ClockifyClient.Models.BalancesWithCountDtoV1> GetAsync(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder.WithPolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::ClockifyClient.Models.BalancesWithCountDtoV1>(requestInfo, global::ClockifyClient.Models.BalancesWithCountDtoV1.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint is deprecated. It will be available until 1st of July 2025. Use [Balance](#tag/Balance/operation/updateBalance) instead.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PatchAsync(global::ClockifyClient.Models.ChangeBalanceRequestV1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PatchAsync(global::ClockifyClient.Models.ChangeBalanceRequestV1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint is deprecated. It will be available until 1st of July 2025. Use [Balance](#tag/Balance/operation/getBalancesForPolicy) instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder.WithPolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder.WithPolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This endpoint is deprecated. It will be available until 1st of July 2025. Use [Balance](#tag/Balance/operation/updateBalance) instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::ClockifyClient.Models.ChangeBalanceRequestV1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::ClockifyClient.Models.ChangeBalanceRequestV1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This endpoint is deprecated. It will be available until 1st of July 2025. Use [Balance](#tag/Balance/operation/getBalancesForPolicy) instead.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithPolicyItemRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page")]
            public string? Page { get; set; }
#nullable restore
#else
            [QueryParameter("page")]
            public string Page { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%2Dsize")]
            public string? PageSize { get; set; }
#nullable restore
#else
            [QueryParameter("page%2Dsize")]
            public string PageSize { get; set; }
#endif
            /// <summary>If provided, you&apos;ll get result sorted by sort column.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>If provided, you&apos;ll get result sorted by sort column.</summary>
            [QueryParameter("sort")]
            public global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
            /// <summary>Sort results in ascending or descending order.</summary>
            [Obsolete("This property is deprecated, use SortOrderAsGetSortOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort%2Dorder")]
            public string? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sort%2Dorder")]
            public string SortOrder { get; set; }
#endif
            /// <summary>Sort results in ascending or descending order.</summary>
            [QueryParameter("sort%2Dorder")]
            public global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithPolicyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Balance.Policy.Item.WithPolicyItemRequestBuilder.WithPolicyItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithPolicyItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
