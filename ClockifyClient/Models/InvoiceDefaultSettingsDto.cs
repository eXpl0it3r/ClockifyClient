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
    /// Represents an invoice default settings object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InvoiceDefaultSettingsDto : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents company identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyId { get; set; }
#nullable restore
#else
        public string CompanyId { get; set; }
#endif
        /// <summary>Represents item type identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultImportExpenseItemTypeId { get; set; }
#nullable restore
#else
        public string DefaultImportExpenseItemTypeId { get; set; }
#endif
        /// <summary>Represents item type identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultImportTimeItemTypeId { get; set; }
#nullable restore
#else
        public string DefaultImportTimeItemTypeId { get; set; }
#endif
        /// <summary>Represents an invoice number of due days.</summary>
        public int? DueDays { get; set; }
        /// <summary>The itemType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemType { get; set; }
#nullable restore
#else
        public string ItemType { get; set; }
#endif
        /// <summary>Represents item type identifier across the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemTypeId { get; set; }
#nullable restore
#else
        public string ItemTypeId { get; set; }
#endif
        /// <summary>Represents an invoice note.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>Represents an invoice subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The tax property</summary>
        [Obsolete("")]
        public long? Tax { get; set; }
        /// <summary>The tax2 property</summary>
        [Obsolete("")]
        public long? Tax2 { get; set; }
        /// <summary>Represents a tax amount in percentage.</summary>
        public double? Tax2Percent { get; set; }
        /// <summary>Represents a tax amount in percentage.</summary>
        public double? TaxPercent { get; set; }
        /// <summary>Represents a tax type.</summary>
        public global::ClockifyClient.Models.InvoiceDefaultSettingsDto_taxType? TaxType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.InvoiceDefaultSettingsDto"/> and sets the default values.
        /// </summary>
        public InvoiceDefaultSettingsDto()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.InvoiceDefaultSettingsDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.InvoiceDefaultSettingsDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.InvoiceDefaultSettingsDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "companyId", n => { CompanyId = n.GetStringValue(); } },
                { "defaultImportExpenseItemTypeId", n => { DefaultImportExpenseItemTypeId = n.GetStringValue(); } },
                { "defaultImportTimeItemTypeId", n => { DefaultImportTimeItemTypeId = n.GetStringValue(); } },
                { "dueDays", n => { DueDays = n.GetIntValue(); } },
                { "itemType", n => { ItemType = n.GetStringValue(); } },
                { "itemTypeId", n => { ItemTypeId = n.GetStringValue(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "tax", n => { Tax = n.GetLongValue(); } },
                { "tax2", n => { Tax2 = n.GetLongValue(); } },
                { "tax2Percent", n => { Tax2Percent = n.GetDoubleValue(); } },
                { "taxPercent", n => { TaxPercent = n.GetDoubleValue(); } },
                { "taxType", n => { TaxType = n.GetEnumValue<global::ClockifyClient.Models.InvoiceDefaultSettingsDto_taxType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("companyId", CompanyId);
            writer.WriteStringValue("defaultImportExpenseItemTypeId", DefaultImportExpenseItemTypeId);
            writer.WriteStringValue("defaultImportTimeItemTypeId", DefaultImportTimeItemTypeId);
            writer.WriteIntValue("dueDays", DueDays);
            writer.WriteStringValue("itemType", ItemType);
            writer.WriteStringValue("itemTypeId", ItemTypeId);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("subject", Subject);
            writer.WriteLongValue("tax", Tax);
            writer.WriteLongValue("tax2", Tax2);
            writer.WriteDoubleValue("tax2Percent", Tax2Percent);
            writer.WriteDoubleValue("taxPercent", TaxPercent);
            writer.WriteEnumValue<global::ClockifyClient.Models.InvoiceDefaultSettingsDto_taxType>("taxType", TaxType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
