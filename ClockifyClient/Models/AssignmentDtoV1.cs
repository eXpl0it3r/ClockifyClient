// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ClockifyClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AssignmentDtoV1 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether assignment is billable or not.</summary>
        public bool? Billable { get; set; }
        /// <summary>Represents a list of excluded days objects</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ClockifyClient.Models.SchedulingExcludeDay>? ExcludeDays { get; set; }
#nullable restore
#else
        public List<global::ClockifyClient.Models.SchedulingExcludeDay> ExcludeDays { get; set; }
#endif
        /// <summary>Represents assignment total hours per day.</summary>
        public double? HoursPerDay { get; set; }
        /// <summary>Represents assignment identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Indicates whether assignment should include non-working days or not.</summary>
        public bool? IncludeNonWorkingDays { get; set; }
        /// <summary>Represents assignment note.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>Represents a date range object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.DateRangeDto? Period { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.DateRangeDto Period { get; set; }
#endif
        /// <summary>Represents project identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>Indicates whether assignment is published or not.</summary>
        public bool? Published { get; set; }
        /// <summary>Represents recurring assignment object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.RecurringAssignmentDto? Recurring { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.RecurringAssignmentDto Recurring { get; set; }
#endif
        /// <summary>Represents start time in hh:mm:ss format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>Represents user identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>Represents workspace identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkspaceId { get; set; }
#nullable restore
#else
        public string WorkspaceId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.AssignmentDtoV1"/> and sets the default values.
        /// </summary>
        public AssignmentDtoV1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.AssignmentDtoV1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.AssignmentDtoV1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.AssignmentDtoV1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "billable", n => { Billable = n.GetBoolValue(); } },
                { "excludeDays", n => { ExcludeDays = n.GetCollectionOfObjectValues<global::ClockifyClient.Models.SchedulingExcludeDay>(global::ClockifyClient.Models.SchedulingExcludeDay.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hoursPerDay", n => { HoursPerDay = n.GetDoubleValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "includeNonWorkingDays", n => { IncludeNonWorkingDays = n.GetBoolValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "period", n => { Period = n.GetObjectValue<global::ClockifyClient.Models.DateRangeDto>(global::ClockifyClient.Models.DateRangeDto.CreateFromDiscriminatorValue); } },
                { "projectId", n => { ProjectId = n.GetStringValue(); } },
                { "published", n => { Published = n.GetBoolValue(); } },
                { "recurring", n => { Recurring = n.GetObjectValue<global::ClockifyClient.Models.RecurringAssignmentDto>(global::ClockifyClient.Models.RecurringAssignmentDto.CreateFromDiscriminatorValue); } },
                { "startTime", n => { StartTime = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "workspaceId", n => { WorkspaceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("billable", Billable);
            writer.WriteCollectionOfObjectValues<global::ClockifyClient.Models.SchedulingExcludeDay>("excludeDays", ExcludeDays);
            writer.WriteDoubleValue("hoursPerDay", HoursPerDay);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("includeNonWorkingDays", IncludeNonWorkingDays);
            writer.WriteStringValue("note", Note);
            writer.WriteObjectValue<global::ClockifyClient.Models.DateRangeDto>("period", Period);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteBoolValue("published", Published);
            writer.WriteObjectValue<global::ClockifyClient.Models.RecurringAssignmentDto>("recurring", Recurring);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("workspaceId", WorkspaceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
