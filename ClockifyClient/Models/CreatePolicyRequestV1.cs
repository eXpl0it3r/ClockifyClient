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
    public partial class CreatePolicyRequestV1 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether policy allows half days.</summary>
        public bool? AllowHalfDay { get; set; }
        /// <summary>Indicates whether policy allows negative balances.</summary>
        public bool? AllowNegativeBalance { get; set; }
        /// <summary>Provide approval settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.ApproveDto? Approve { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.ApproveDto Approve { get; set; }
#endif
        /// <summary>Indicates whether policy is archived.</summary>
        public bool? Archived { get; set; }
        /// <summary>Provide automatic accrual settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.AutomaticAccrualRequest? AutomaticAccrual { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.AutomaticAccrualRequest AutomaticAccrual { get; set; }
#endif
        /// <summary>Provides automatic time entry creation settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.AutomaticTimeEntryCreationRequest? AutomaticTimeEntryCreation { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.AutomaticTimeEntryCreationRequest AutomaticTimeEntryCreation { get; set; }
#endif
        /// <summary>Provide color in format ^#(?:[0-9a-fA-F]{6}){1}$. Explanation: A valid color code should start with &apos;#&apos; and consist of six hexadecimal characters, representing a color in hexadecimal format. Color value is in standard RGB hexadecimal format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color { get; set; }
#nullable restore
#else
        public string Color { get; set; }
#endif
        /// <summary>Indicates whether the policy is to be applied to future new users.</summary>
        public bool? EveryoneIncludingNew { get; set; }
        /// <summary>Represents name of new policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Provide the negative balance data you would like to use for updating the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.NegativeBalanceRequest? NegativeBalance { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.NegativeBalanceRequest NegativeBalance { get; set; }
#endif
        /// <summary>Indicates time unit of the policy. </summary>
        public global::ClockifyClient.Models.CreatePolicyRequestV1_timeUnit? TimeUnit { get; set; }
        /// <summary>Provide list with user group ids and corresponding status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.UserGroupIdsSchema? UserGroups { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.UserGroupIdsSchema UserGroups { get; set; }
#endif
        /// <summary>Provide list with user ids and corresponding status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.UserIdsSchema? Users { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.UserIdsSchema Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.CreatePolicyRequestV1"/> and sets the default values.
        /// </summary>
        public CreatePolicyRequestV1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.CreatePolicyRequestV1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.CreatePolicyRequestV1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.CreatePolicyRequestV1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowHalfDay", n => { AllowHalfDay = n.GetBoolValue(); } },
                { "allowNegativeBalance", n => { AllowNegativeBalance = n.GetBoolValue(); } },
                { "approve", n => { Approve = n.GetObjectValue<global::ClockifyClient.Models.ApproveDto>(global::ClockifyClient.Models.ApproveDto.CreateFromDiscriminatorValue); } },
                { "archived", n => { Archived = n.GetBoolValue(); } },
                { "automaticAccrual", n => { AutomaticAccrual = n.GetObjectValue<global::ClockifyClient.Models.AutomaticAccrualRequest>(global::ClockifyClient.Models.AutomaticAccrualRequest.CreateFromDiscriminatorValue); } },
                { "automaticTimeEntryCreation", n => { AutomaticTimeEntryCreation = n.GetObjectValue<global::ClockifyClient.Models.AutomaticTimeEntryCreationRequest>(global::ClockifyClient.Models.AutomaticTimeEntryCreationRequest.CreateFromDiscriminatorValue); } },
                { "color", n => { Color = n.GetStringValue(); } },
                { "everyoneIncludingNew", n => { EveryoneIncludingNew = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "negativeBalance", n => { NegativeBalance = n.GetObjectValue<global::ClockifyClient.Models.NegativeBalanceRequest>(global::ClockifyClient.Models.NegativeBalanceRequest.CreateFromDiscriminatorValue); } },
                { "timeUnit", n => { TimeUnit = n.GetEnumValue<global::ClockifyClient.Models.CreatePolicyRequestV1_timeUnit>(); } },
                { "userGroups", n => { UserGroups = n.GetObjectValue<global::ClockifyClient.Models.UserGroupIdsSchema>(global::ClockifyClient.Models.UserGroupIdsSchema.CreateFromDiscriminatorValue); } },
                { "users", n => { Users = n.GetObjectValue<global::ClockifyClient.Models.UserIdsSchema>(global::ClockifyClient.Models.UserIdsSchema.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowHalfDay", AllowHalfDay);
            writer.WriteBoolValue("allowNegativeBalance", AllowNegativeBalance);
            writer.WriteObjectValue<global::ClockifyClient.Models.ApproveDto>("approve", Approve);
            writer.WriteBoolValue("archived", Archived);
            writer.WriteObjectValue<global::ClockifyClient.Models.AutomaticAccrualRequest>("automaticAccrual", AutomaticAccrual);
            writer.WriteObjectValue<global::ClockifyClient.Models.AutomaticTimeEntryCreationRequest>("automaticTimeEntryCreation", AutomaticTimeEntryCreation);
            writer.WriteStringValue("color", Color);
            writer.WriteBoolValue("everyoneIncludingNew", EveryoneIncludingNew);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ClockifyClient.Models.NegativeBalanceRequest>("negativeBalance", NegativeBalance);
            writer.WriteEnumValue<global::ClockifyClient.Models.CreatePolicyRequestV1_timeUnit>("timeUnit", TimeUnit);
            writer.WriteObjectValue<global::ClockifyClient.Models.UserGroupIdsSchema>("userGroups", UserGroups);
            writer.WriteObjectValue<global::ClockifyClient.Models.UserIdsSchema>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
