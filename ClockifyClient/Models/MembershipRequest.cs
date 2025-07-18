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
    /// Represents a list of membership request objects.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MembershipRequest : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents an hourly rate request object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.HourlyRateRequest? HourlyRate { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.HourlyRateRequest HourlyRate { get; set; }
#endif
        /// <summary>Represents a membership status enum.</summary>
        public global::ClockifyClient.Models.MembershipRequest_membershipStatus? MembershipStatus { get; set; }
        /// <summary>Represents membership type enum.</summary>
        public global::ClockifyClient.Models.MembershipRequest_membershipType? MembershipType { get; set; }
        /// <summary>Represents user identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.MembershipRequest"/> and sets the default values.
        /// </summary>
        public MembershipRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.MembershipRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.MembershipRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.MembershipRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hourlyRate", n => { HourlyRate = n.GetObjectValue<global::ClockifyClient.Models.HourlyRateRequest>(global::ClockifyClient.Models.HourlyRateRequest.CreateFromDiscriminatorValue); } },
                { "membershipStatus", n => { MembershipStatus = n.GetEnumValue<global::ClockifyClient.Models.MembershipRequest_membershipStatus>(); } },
                { "membershipType", n => { MembershipType = n.GetEnumValue<global::ClockifyClient.Models.MembershipRequest_membershipType>(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ClockifyClient.Models.HourlyRateRequest>("hourlyRate", HourlyRate);
            writer.WriteEnumValue<global::ClockifyClient.Models.MembershipRequest_membershipStatus>("membershipStatus", MembershipStatus);
            writer.WriteEnumValue<global::ClockifyClient.Models.MembershipRequest_membershipType>("membershipType", MembershipType);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
