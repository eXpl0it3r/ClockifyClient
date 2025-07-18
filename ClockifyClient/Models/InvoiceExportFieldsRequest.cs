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
    /// Represents an invoice export fields object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InvoiceExportFieldsRequest : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether to export item type.</summary>
        public bool? ItemType { get; set; }
        /// <summary>Indicates whether to export quantity.</summary>
        public bool? Quantity { get; set; }
        /// <summary>Indicates whether to export RTL.</summary>
        public bool? Rtl { get; set; }
        /// <summary>Indicates whether to export tax.</summary>
        public bool? Tax { get; set; }
        /// <summary>Indicates whether to export tax2.</summary>
        public bool? Tax2 { get; set; }
        /// <summary>Indicates whether to export unit price.</summary>
        public bool? UnitPrice { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.InvoiceExportFieldsRequest"/> and sets the default values.
        /// </summary>
        public InvoiceExportFieldsRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.InvoiceExportFieldsRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.InvoiceExportFieldsRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.InvoiceExportFieldsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "itemType", n => { ItemType = n.GetBoolValue(); } },
                { "quantity", n => { Quantity = n.GetBoolValue(); } },
                { "rtl", n => { Rtl = n.GetBoolValue(); } },
                { "tax", n => { Tax = n.GetBoolValue(); } },
                { "tax2", n => { Tax2 = n.GetBoolValue(); } },
                { "unitPrice", n => { UnitPrice = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("itemType", ItemType);
            writer.WriteBoolValue("quantity", Quantity);
            writer.WriteBoolValue("rtl", Rtl);
            writer.WriteBoolValue("tax", Tax);
            writer.WriteBoolValue("tax2", Tax2);
            writer.WriteBoolValue("unitPrice", UnitPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
