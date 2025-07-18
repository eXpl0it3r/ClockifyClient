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
    public partial class UpdateCustomFieldRequestV1 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents a list of custom field&apos;s allowed values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedValues { get; set; }
#nullable restore
#else
        public List<string> AllowedValues { get; set; }
#endif
        /// <summary>Represents custom field description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Represents custom field name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Flag to set whether custom field is modifiable only by admin users.</summary>
        public bool? OnlyAdminCanEdit { get; set; }
        /// <summary>Represents a custom field placeholder value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Placeholder { get; set; }
#nullable restore
#else
        public string Placeholder { get; set; }
#endif
        /// <summary>Flag to set whether custom field is mandatory or not.</summary>
        public bool? Required { get; set; }
        /// <summary>Represents custom field status</summary>
        public global::ClockifyClient.Models.UpdateCustomFieldRequestV1_status? Status { get; set; }
        /// <summary>Represents custom field type.</summary>
        public global::ClockifyClient.Models.UpdateCustomFieldRequestV1_type? Type { get; set; }
        /// <summary>Represents a custom field&apos;s default value in the workspace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.UpdateCustomFieldRequestV1_workspaceDefaultValue? WorkspaceDefaultValue { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.UpdateCustomFieldRequestV1_workspaceDefaultValue WorkspaceDefaultValue { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.UpdateCustomFieldRequestV1"/> and sets the default values.
        /// </summary>
        public UpdateCustomFieldRequestV1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.UpdateCustomFieldRequestV1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.UpdateCustomFieldRequestV1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.UpdateCustomFieldRequestV1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowedValues", n => { AllowedValues = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "onlyAdminCanEdit", n => { OnlyAdminCanEdit = n.GetBoolValue(); } },
                { "placeholder", n => { Placeholder = n.GetStringValue(); } },
                { "required", n => { Required = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::ClockifyClient.Models.UpdateCustomFieldRequestV1_status>(); } },
                { "type", n => { Type = n.GetEnumValue<global::ClockifyClient.Models.UpdateCustomFieldRequestV1_type>(); } },
                { "workspaceDefaultValue", n => { WorkspaceDefaultValue = n.GetObjectValue<global::ClockifyClient.Models.UpdateCustomFieldRequestV1_workspaceDefaultValue>(global::ClockifyClient.Models.UpdateCustomFieldRequestV1_workspaceDefaultValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedValues", AllowedValues);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("onlyAdminCanEdit", OnlyAdminCanEdit);
            writer.WriteStringValue("placeholder", Placeholder);
            writer.WriteBoolValue("required", Required);
            writer.WriteEnumValue<global::ClockifyClient.Models.UpdateCustomFieldRequestV1_status>("status", Status);
            writer.WriteEnumValue<global::ClockifyClient.Models.UpdateCustomFieldRequestV1_type>("type", Type);
            writer.WriteObjectValue<global::ClockifyClient.Models.UpdateCustomFieldRequestV1_workspaceDefaultValue>("workspaceDefaultValue", WorkspaceDefaultValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
