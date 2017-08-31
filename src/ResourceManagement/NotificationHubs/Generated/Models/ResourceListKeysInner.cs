// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Microsoft.Azure.Management.NotificationHubs.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Namespace/NotificationHub Connection String
    /// </summary>
    public partial class ResourceListKeysInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceListKeysInner class.
        /// </summary>
        public ResourceListKeysInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceListKeysInner class.
        /// </summary>
        /// <param name="primaryConnectionString">PrimaryConnectionString of
        /// the AuthorizationRule.</param>
        /// <param name="secondaryConnectionString">SecondaryConnectionString
        /// of the created AuthorizationRule</param>
        /// <param name="primaryKey">PrimaryKey of the created
        /// AuthorizationRule.</param>
        /// <param name="secondaryKey">SecondaryKey of the created
        /// AuthorizationRule</param>
        /// <param name="keyName">KeyName of the created
        /// AuthorizationRule</param>
        public ResourceListKeysInner(string primaryConnectionString = default(string), string secondaryConnectionString = default(string), string primaryKey = default(string), string secondaryKey = default(string), string keyName = default(string))
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets primaryConnectionString of the AuthorizationRule.
        /// </summary>
        [JsonProperty(PropertyName = "primaryConnectionString")]
        public string PrimaryConnectionString { get; set; }

        /// <summary>
        /// Gets or sets secondaryConnectionString of the created
        /// AuthorizationRule
        /// </summary>
        [JsonProperty(PropertyName = "secondaryConnectionString")]
        public string SecondaryConnectionString { get; set; }

        /// <summary>
        /// Gets or sets primaryKey of the created AuthorizationRule.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets secondaryKey of the created AuthorizationRule
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Gets or sets keyName of the created AuthorizationRule
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

    }
}
