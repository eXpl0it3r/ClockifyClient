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
    /// Represents an entity creation permission object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EntityCreationPermissionsDtoV1 : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents an entity creation permission enum.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.EntityCreationPermission? WhoCanCreateProjectsAndClients { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.EntityCreationPermission WhoCanCreateProjectsAndClients { get; set; }
#endif
        /// <summary>Represents an entity creation permission enum.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.EntityCreationPermission? WhoCanCreateTags { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.EntityCreationPermission WhoCanCreateTags { get; set; }
#endif
        /// <summary>Represents an entity creation permission enum.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ClockifyClient.Models.EntityCreationPermission? WhoCanCreateTasks { get; set; }
#nullable restore
#else
        public global::ClockifyClient.Models.EntityCreationPermission WhoCanCreateTasks { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ClockifyClient.Models.EntityCreationPermissionsDtoV1"/> and sets the default values.
        /// </summary>
        public EntityCreationPermissionsDtoV1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ClockifyClient.Models.EntityCreationPermissionsDtoV1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ClockifyClient.Models.EntityCreationPermissionsDtoV1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ClockifyClient.Models.EntityCreationPermissionsDtoV1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "whoCanCreateProjectsAndClients", n => { WhoCanCreateProjectsAndClients = n.GetObjectValue<global::ClockifyClient.Models.EntityCreationPermission>(global::ClockifyClient.Models.EntityCreationPermission.CreateFromDiscriminatorValue); } },
                { "whoCanCreateTags", n => { WhoCanCreateTags = n.GetObjectValue<global::ClockifyClient.Models.EntityCreationPermission>(global::ClockifyClient.Models.EntityCreationPermission.CreateFromDiscriminatorValue); } },
                { "whoCanCreateTasks", n => { WhoCanCreateTasks = n.GetObjectValue<global::ClockifyClient.Models.EntityCreationPermission>(global::ClockifyClient.Models.EntityCreationPermission.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ClockifyClient.Models.EntityCreationPermission>("whoCanCreateProjectsAndClients", WhoCanCreateProjectsAndClients);
            writer.WriteObjectValue<global::ClockifyClient.Models.EntityCreationPermission>("whoCanCreateTags", WhoCanCreateTags);
            writer.WriteObjectValue<global::ClockifyClient.Models.EntityCreationPermission>("whoCanCreateTasks", WhoCanCreateTasks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
