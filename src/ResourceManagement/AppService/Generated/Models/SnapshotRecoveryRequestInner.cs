// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details about app recovery operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SnapshotRecoveryRequestInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SnapshotRecoveryRequestInner
        /// class.
        /// </summary>
        public SnapshotRecoveryRequestInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SnapshotRecoveryRequestInner
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="snapshotTime">Point in time in which the app recovery
        /// should be attempted.</param>
        /// <param name="recoveryTarget">Specifies the web app that snapshot
        /// contents will be written to.</param>
        /// <param name="overwrite">&lt;code&gt;true&lt;/code&gt; if the
        /// recovery operation can overwrite source app; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="recoverConfiguration">Site configuration, in addition
        /// to content, will be reverted if this is true.</param>
        public SnapshotRecoveryRequestInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), System.DateTime? snapshotTime = default(System.DateTime?), SnapshotRecoveryTarget recoveryTarget = default(SnapshotRecoveryTarget), bool? overwrite = default(bool?), bool? recoverConfiguration = default(bool?))
            : base(id, name, kind, type)
        {
            SnapshotTime = snapshotTime;
            RecoveryTarget = recoveryTarget;
            Overwrite = overwrite;
            RecoverConfiguration = recoverConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets point in time in which the app recovery should be
        /// attempted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.snapshotTime")]
        public System.DateTime? SnapshotTime { get; set; }

        /// <summary>
        /// Gets or sets specifies the web app that snapshot contents will be
        /// written to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoveryTarget")]
        public SnapshotRecoveryTarget RecoveryTarget { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if the
        /// recovery operation can overwrite source app; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Gets or sets site configuration, in addition to content, will be
        /// reverted if this is true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoverConfiguration")]
        public bool? RecoverConfiguration { get; set; }

    }
}
