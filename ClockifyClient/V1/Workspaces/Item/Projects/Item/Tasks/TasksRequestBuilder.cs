// <auto-generated/>
#pragma warning disable CS0618
using ClockifyClient.Models;
using ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks
{
    /// <summary>
    /// Builds and executes requests for operations under \v1\workspaces\{workspaceId}\projects\{projectId}\tasks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TasksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the ClockifyClient.v1.workspaces.item.projects.item.tasks.item collection</summary>
        /// <param name="position">Represents task identifier across the system.</param>
        /// <returns>A <see cref="global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.Item.ItemRequestBuilder"/></returns>
        public global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.Item.ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("%2Did", position);
                return new global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.Item.ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TasksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/workspaces/{workspaceId}/projects/{projectId}/tasks{?contains%2Dassignee*,is%2Dactive*,name*,page*,page%2Dsize*,sort%2Dcolumn*,sort%2Dorder*,strict%2Dname%2Dsearch*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TasksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/workspaces/{workspaceId}/projects/{projectId}/tasks{?contains%2Dassignee*,is%2Dactive*,name*,page*,page%2Dsize*,sort%2Dcolumn*,sort%2Dorder*,strict%2Dname%2Dsearch*}", rawUrl)
        {
        }
        /// <summary>
        /// Find tasks on project
        /// </summary>
        /// <returns>A List&lt;global::ClockifyClient.Models.TaskDtoV1&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::ClockifyClient.Models.TaskDtoV1>?> GetAsync(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::ClockifyClient.Models.TaskDtoV1>> GetAsync(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::ClockifyClient.Models.TaskDtoV1>(requestInfo, global::ClockifyClient.Models.TaskDtoV1.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Add a new task on project
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.TaskDtoV1"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::ClockifyClient.Models.TaskDtoV1?> PostAsync(global::ClockifyClient.Models.TaskRequestV1 body, Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::ClockifyClient.Models.TaskDtoV1> PostAsync(global::ClockifyClient.Models.TaskRequestV1 body, Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::ClockifyClient.Models.TaskDtoV1>(requestInfo, global::ClockifyClient.Models.TaskDtoV1.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Find tasks on project
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Add a new task on project
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::ClockifyClient.Models.TaskRequestV1 body, Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::ClockifyClient.Models.TaskRequestV1 body, Action<RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Find tasks on project
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TasksRequestBuilderGetQueryParameters 
        {
            /// <summary>Filters search results whether task is active or not.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("is%2Dactive")]
            public string? IsActive { get; set; }
#nullable restore
#else
            [QueryParameter("is%2Dactive")]
            public string IsActive { get; set; }
#endif
            /// <summary>If provided, you&apos;ll get a filtered list of tasks that matches the provided string in their name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>Page number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page")]
            public string? Page { get; set; }
#nullable restore
#else
            [QueryParameter("page")]
            public string Page { get; set; }
#endif
            /// <summary>Page size.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%2Dsize")]
            public string? PageSize { get; set; }
#nullable restore
#else
            [QueryParameter("page%2Dsize")]
            public string PageSize { get; set; }
#endif
            /// <summary>Represents the column as criteria for sorting tasks.</summary>
            [Obsolete("This property is deprecated, use SortColumnAsGetSortColumnQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort%2Dcolumn")]
            public string? SortColumn { get; set; }
#nullable restore
#else
            [QueryParameter("sort%2Dcolumn")]
            public string SortColumn { get; set; }
#endif
            /// <summary>Represents the column as criteria for sorting tasks.</summary>
            [QueryParameter("sort%2Dcolumn")]
            public global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.GetSortColumnQueryParameterType? SortColumnAsGetSortColumnQueryParameterType { get; set; }
            /// <summary>Sorting mode.</summary>
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
            /// <summary>Sorting mode.</summary>
            [QueryParameter("sort%2Dorder")]
            public global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
            /// <summary>Flag to toggle on/off strict search mode. When set to true, search by name only will return tasks whose name exactly matches the string value given for the &apos;name&apos; parameter. When set to false, results will also include tasks whose name contain the string value, but could be longer than the string value itself. For example, if there is a task with the name &apos;applications&apos;, and the search value is &apos;app&apos;, setting strict-name-search to true will not return that task in the results, whereas setting it to false will.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("strict%2Dname%2Dsearch")]
            public string? StrictNameSearch { get; set; }
#nullable restore
#else
            [QueryParameter("strict%2Dname%2Dsearch")]
            public string StrictNameSearch { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TasksRequestBuilderGetRequestConfiguration : RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Add a new task on project
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TasksRequestBuilderPostQueryParameters 
        {
            /// <summary>Flag to set whether task will have assignee or none.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("contains%2Dassignee")]
            public string? ContainsAssignee { get; set; }
#nullable restore
#else
            [QueryParameter("contains%2Dassignee")]
            public string ContainsAssignee { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TasksRequestBuilderPostRequestConfiguration : RequestConfiguration<global::ClockifyClient.V1.Workspaces.Item.Projects.Item.Tasks.TasksRequestBuilder.TasksRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
