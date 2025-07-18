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
    /// Represents a list of custom field value objects.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomFieldValueDtoV1 : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents custom field identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomFieldId { get; set; }
#nullable restore
#else
        public string CustomFieldId { get; set; }
#endif
        /// <summary>Represents custom field name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Represents time entry identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeEntryId { get; set; }
#nullable restore
#else
        public string TimeEntryId { get; set; }
#endif
        /// <summary>Represents a custom field value source type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>Represents custom field value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.CustomFieldValueDtoV1_value? Value { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.CustomFieldValueDtoV1_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.CustomFieldValueDtoV1"/> and sets the default values.
        /// </summary>
        public CustomFieldValueDtoV1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.CustomFieldValueDtoV1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.CustomFieldValueDtoV1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.CustomFieldValueDtoV1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "customFieldId", n => { CustomFieldId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "timeEntryId", n => { TimeEntryId = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "value", n => { Value = n.GetObjectValue<global::ClockifyClient.Models.CustomFieldValueDtoV1_value>(global::ClockifyClient.Models.CustomFieldValueDtoV1_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customFieldId", CustomFieldId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("timeEntryId", TimeEntryId);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<global::ClockifyClient.Models.CustomFieldValueDtoV1_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
