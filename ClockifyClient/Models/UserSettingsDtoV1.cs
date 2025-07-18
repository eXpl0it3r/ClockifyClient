// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ClockifyClient.Models
{
    /// <summary>
    /// Represents user settings object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserSettingsDtoV1 : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alerts property</summary>
        public bool? Alerts { get; set; }
        /// <summary>The approval property</summary>
        public bool? Approval { get; set; }
        /// <summary>The collapseAllProjectLists property</summary>
        public bool? CollapseAllProjectLists { get; set; }
        /// <summary>The dashboardPinToTop property</summary>
        public bool? DashboardPinToTop { get; set; }
        /// <summary>The dashboardSelection property</summary>
        public global::ClockifyClient.Models.UserSettingsDtoV1_dashboardSelection? DashboardSelection { get; set; }
        /// <summary>The dashboardViewType property</summary>
        public global::ClockifyClient.Models.UserSettingsDtoV1_dashboardViewType? DashboardViewType { get; set; }
        /// <summary>Represents a date format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateFormat { get; set; }
#nullable restore
#else
        public string DateFormat { get; set; }
#endif
        /// <summary>The groupSimilarEntriesDisabled property</summary>
        public bool? GroupSimilarEntriesDisabled { get; set; }
        /// <summary>The isCompactViewOn property</summary>
        public bool? IsCompactViewOn { get; set; }
        /// <summary>The lang property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Lang { get; set; }
#nullable restore
#else
        public string Lang { get; set; }
#endif
        /// <summary>The longRunning property</summary>
        public bool? LongRunning { get; set; }
        /// <summary>The multiFactorEnabled property</summary>
        public bool? MultiFactorEnabled { get; set; }
        /// <summary>The myStartOfDay property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MyStartOfDay { get; set; }
#nullable restore
#else
        public string MyStartOfDay { get; set; }
#endif
        /// <summary>The onboarding property</summary>
        public bool? Onboarding { get; set; }
        /// <summary>The projectListCollapse property</summary>
        public int? ProjectListCollapse { get; set; }
        /// <summary>The projectPickerTaskFilter property</summary>
        public bool? ProjectPickerTaskFilter { get; set; }
        /// <summary>The pto property</summary>
        public bool? Pto { get; set; }
        /// <summary>The reminders property</summary>
        public bool? Reminders { get; set; }
        /// <summary>The scheduledReports property</summary>
        public bool? ScheduledReports { get; set; }
        /// <summary>The scheduling property</summary>
        public bool? Scheduling { get; set; }
        /// <summary>The sendNewsletter property</summary>
        public bool? SendNewsletter { get; set; }
        /// <summary>The showOnlyWorkingDays property</summary>
        public bool? ShowOnlyWorkingDays { get; set; }
        /// <summary>Represents a summary report settings object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.SummaryReportSettingsDtoV1? SummaryReportSettings { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.SummaryReportSettingsDtoV1 SummaryReportSettings { get; set; }
#endif
        /// <summary>The theme property</summary>
        public global::ClockifyClient.Models.UserSettingsDtoV1_theme? Theme { get; set; }
        /// <summary>Represents a time format enum.</summary>
        public global::ClockifyClient.Models.UserSettingsDtoV1_timeFormat? TimeFormat { get; set; }
        /// <summary>The timeTrackingManual property</summary>
        public bool? TimeTrackingManual { get; set; }
        /// <summary>Represents a valid timezone ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone { get; set; }
#nullable restore
#else
        public string TimeZone { get; set; }
#endif
        /// <summary>The weeklyUpdates property</summary>
        public bool? WeeklyUpdates { get; set; }
        /// <summary>Represents a day of the week.</summary>
        public global::ClockifyClient.Models.UserSettingsDtoV1_weekStart? WeekStart { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.UserSettingsDtoV1"/> and sets the default values.
        /// </summary>
        public UserSettingsDtoV1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.UserSettingsDtoV1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.UserSettingsDtoV1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.UserSettingsDtoV1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alerts", n => { Alerts = n.GetBoolValue(); } },
                { "approval", n => { Approval = n.GetBoolValue(); } },
                { "collapseAllProjectLists", n => { CollapseAllProjectLists = n.GetBoolValue(); } },
                { "dashboardPinToTop", n => { DashboardPinToTop = n.GetBoolValue(); } },
                { "dashboardSelection", n => { DashboardSelection = n.GetEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_dashboardSelection>(); } },
                { "dashboardViewType", n => { DashboardViewType = n.GetEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_dashboardViewType>(); } },
                { "dateFormat", n => { DateFormat = n.GetStringValue(); } },
                { "groupSimilarEntriesDisabled", n => { GroupSimilarEntriesDisabled = n.GetBoolValue(); } },
                { "isCompactViewOn", n => { IsCompactViewOn = n.GetBoolValue(); } },
                { "lang", n => { Lang = n.GetStringValue(); } },
                { "longRunning", n => { LongRunning = n.GetBoolValue(); } },
                { "multiFactorEnabled", n => { MultiFactorEnabled = n.GetBoolValue(); } },
                { "myStartOfDay", n => { MyStartOfDay = n.GetStringValue(); } },
                { "onboarding", n => { Onboarding = n.GetBoolValue(); } },
                { "projectListCollapse", n => { ProjectListCollapse = n.GetIntValue(); } },
                { "projectPickerTaskFilter", n => { ProjectPickerTaskFilter = n.GetBoolValue(); } },
                { "pto", n => { Pto = n.GetBoolValue(); } },
                { "reminders", n => { Reminders = n.GetBoolValue(); } },
                { "scheduledReports", n => { ScheduledReports = n.GetBoolValue(); } },
                { "scheduling", n => { Scheduling = n.GetBoolValue(); } },
                { "sendNewsletter", n => { SendNewsletter = n.GetBoolValue(); } },
                { "showOnlyWorkingDays", n => { ShowOnlyWorkingDays = n.GetBoolValue(); } },
                { "summaryReportSettings", n => { SummaryReportSettings = n.GetObjectValue<global::ClockifyClient.Models.SummaryReportSettingsDtoV1>(global::ClockifyClient.Models.SummaryReportSettingsDtoV1.CreateFromDiscriminatorValue); } },
                { "theme", n => { Theme = n.GetEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_theme>(); } },
                { "timeFormat", n => { TimeFormat = n.GetEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_timeFormat>(); } },
                { "timeTrackingManual", n => { TimeTrackingManual = n.GetBoolValue(); } },
                { "timeZone", n => { TimeZone = n.GetStringValue(); } },
                { "weekStart", n => { WeekStart = n.GetEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_weekStart>(); } },
                { "weeklyUpdates", n => { WeeklyUpdates = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("alerts", Alerts);
            writer.WriteBoolValue("approval", Approval);
            writer.WriteBoolValue("collapseAllProjectLists", CollapseAllProjectLists);
            writer.WriteBoolValue("dashboardPinToTop", DashboardPinToTop);
            writer.WriteEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_dashboardSelection>("dashboardSelection", DashboardSelection);
            writer.WriteEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_dashboardViewType>("dashboardViewType", DashboardViewType);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteBoolValue("groupSimilarEntriesDisabled", GroupSimilarEntriesDisabled);
            writer.WriteBoolValue("isCompactViewOn", IsCompactViewOn);
            writer.WriteStringValue("lang", Lang);
            writer.WriteBoolValue("longRunning", LongRunning);
            writer.WriteBoolValue("multiFactorEnabled", MultiFactorEnabled);
            writer.WriteStringValue("myStartOfDay", MyStartOfDay);
            writer.WriteBoolValue("onboarding", Onboarding);
            writer.WriteIntValue("projectListCollapse", ProjectListCollapse);
            writer.WriteBoolValue("projectPickerTaskFilter", ProjectPickerTaskFilter);
            writer.WriteBoolValue("pto", Pto);
            writer.WriteBoolValue("reminders", Reminders);
            writer.WriteBoolValue("scheduledReports", ScheduledReports);
            writer.WriteBoolValue("scheduling", Scheduling);
            writer.WriteBoolValue("sendNewsletter", SendNewsletter);
            writer.WriteBoolValue("showOnlyWorkingDays", ShowOnlyWorkingDays);
            writer.WriteObjectValue<global::ClockifyClient.Models.SummaryReportSettingsDtoV1>("summaryReportSettings", SummaryReportSettings);
            writer.WriteEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_theme>("theme", Theme);
            writer.WriteEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_timeFormat>("timeFormat", TimeFormat);
            writer.WriteBoolValue("timeTrackingManual", TimeTrackingManual);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteBoolValue("weeklyUpdates", WeeklyUpdates);
            writer.WriteEnumValue<global::ClockifyClient.Models.UserSettingsDtoV1_weekStart>("weekStart", WeekStart);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
