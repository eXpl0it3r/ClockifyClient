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
namespace ClockifyClient.V1.SharedReports.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\shared-reports\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SharedReportsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SharedReportsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/shared-reports/{id}{?dateRangeEnd*,dateRangeStart*,exportType*,page*,pageSize*,sortColumn*,sortOrder*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SharedReportsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/shared-reports/{id}{?dateRangeEnd*,dateRangeStart*,exportType*,page*,pageSize*,sortColumn*,sortOrder*}", rawUrl)
        {
        }
        /// <summary>
        /// Response depends on report type and export type. Given example is for SUMMARY report and JSON exportType. Shared report data on FREE subscription plan is limited to a maximum interval length of one year (366 days).
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.TimeEntrySummaryReportDto"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ClockifyClient.Models.TimeEntrySummaryReportDto?> GetAsync(Action<RequestConfiguration<global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder.SharedReportsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ClockifyClient.Models.TimeEntrySummaryReportDto> GetAsync(Action<RequestConfiguration<global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder.SharedReportsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::ClockifyClient.Models.TimeEntrySummaryReportDto>(requestInfo, global::ClockifyClient.Models.TimeEntrySummaryReportDto.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Response depends on report type and export type. Given example is for SUMMARY report and JSON exportType. Shared report data on FREE subscription plan is limited to a maximum interval length of one year (366 days).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder.SharedReportsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder.SharedReportsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Response depends on report type and export type. Given example is for SUMMARY report and JSON exportType. Shared report data on FREE subscription plan is limited to a maximum interval length of one year (366 days).
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SharedReportsItemRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dateRangeEnd")]
            public string? DateRangeEnd { get; set; }
#nullable restore
#else
            [QueryParameter("dateRangeEnd")]
            public string DateRangeEnd { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dateRangeStart")]
            public string? DateRangeStart { get; set; }
#nullable restore
#else
            [QueryParameter("dateRangeStart")]
            public string DateRangeStart { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("exportType")]
            public string? ExportType { get; set; }
#nullable restore
#else
            [QueryParameter("exportType")]
            public string ExportType { get; set; }
#endif
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("pageSize")]
            public int? PageSize { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortColumn")]
            public string? SortColumn { get; set; }
#nullable restore
#else
            [QueryParameter("sortColumn")]
            public string SortColumn { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public string? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public string SortOrder { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SharedReportsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ClockifyClient.V1.SharedReports.Item.SharedReportsItemRequestBuilder.SharedReportsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
