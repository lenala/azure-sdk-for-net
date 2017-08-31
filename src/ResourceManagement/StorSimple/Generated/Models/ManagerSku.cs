// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Sku.
    /// </summary>
    public partial class ManagerSku
    {
        /// <summary>
        /// Initializes a new instance of the ManagerSku class.
        /// </summary>
        public ManagerSku()
        {
          CustomInit();
        }

        /// <summary>
        /// Static constructor for ManagerSku class.
        /// </summary>
        static ManagerSku()
        {
            Name = "Standard";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Refers to the sku name which should be "Standard"
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public static string Name { get; private set; }

    }
}
