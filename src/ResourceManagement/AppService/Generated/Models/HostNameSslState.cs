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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSL-enabled hostname.
    /// </summary>
    public partial class HostNameSslState
    {
        /// <summary>
        /// Initializes a new instance of the HostNameSslState class.
        /// </summary>
        public HostNameSslState()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostNameSslState class.
        /// </summary>
        /// <param name="name">Hostname.</param>
        /// <param name="sslState">SSL type. Possible values include:
        /// 'Disabled', 'SniEnabled', 'IpBasedEnabled'</param>
        /// <param name="virtualIP">Virtual IP address assigned to the hostname
        /// if IP based SSL is enabled.</param>
        /// <param name="thumbprint">SSL certificate thumbprint.</param>
        /// <param name="toUpdate">Set to &lt;code&gt;true&lt;/code&gt; to
        /// update existing hostname.</param>
        /// <param name="hostType">Indicates whether the hostname is a standard
        /// or repository hostname. Possible values include: 'Standard',
        /// 'Repository'</param>
        public HostNameSslState(string name = default(string), SslState? sslState = default(SslState?), string virtualIP = default(string), string thumbprint = default(string), bool? toUpdate = default(bool?), HostType? hostType = default(HostType?))
        {
            Name = name;
            SslState = sslState;
            VirtualIP = virtualIP;
            Thumbprint = thumbprint;
            ToUpdate = toUpdate;
            HostType = hostType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hostname.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SSL type. Possible values include: 'Disabled',
        /// 'SniEnabled', 'IpBasedEnabled'
        /// </summary>
        [JsonProperty(PropertyName = "sslState")]
        public SslState? SslState { get; set; }

        /// <summary>
        /// Gets or sets virtual IP address assigned to the hostname if IP
        /// based SSL is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// Gets or sets SSL certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets set to &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;
        /// to update existing hostname.
        /// </summary>
        [JsonProperty(PropertyName = "toUpdate")]
        public bool? ToUpdate { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the hostname is a standard or
        /// repository hostname. Possible values include: 'Standard',
        /// 'Repository'
        /// </summary>
        [JsonProperty(PropertyName = "hostType")]
        public HostType? HostType { get; set; }

    }
}
