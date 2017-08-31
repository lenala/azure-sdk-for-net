// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of an artifact.
    /// </summary>
    public partial class ArtifactInstallPropertiesFragment
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactInstallPropertiesFragment
        /// class.
        /// </summary>
        public ArtifactInstallPropertiesFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactInstallPropertiesFragment
        /// class.
        /// </summary>
        /// <param name="artifactId">The artifact's identifier.</param>
        /// <param name="parameters">The parameters of the artifact.</param>
        /// <param name="status">The status of the artifact.</param>
        /// <param name="deploymentStatusMessage">The status message from the
        /// deployment.</param>
        /// <param name="vmExtensionStatusMessage">The status message from the
        /// virtual machine extension.</param>
        /// <param name="installTime">The time that the artifact starts to
        /// install on the virtual machine.</param>
        public ArtifactInstallPropertiesFragment(string artifactId = default(string), IList<ArtifactParameterPropertiesFragment> parameters = default(IList<ArtifactParameterPropertiesFragment>), string status = default(string), string deploymentStatusMessage = default(string), string vmExtensionStatusMessage = default(string), System.DateTime? installTime = default(System.DateTime?))
        {
            ArtifactId = artifactId;
            Parameters = parameters;
            Status = status;
            DeploymentStatusMessage = deploymentStatusMessage;
            VmExtensionStatusMessage = vmExtensionStatusMessage;
            InstallTime = installTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the artifact's identifier.
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<ArtifactParameterPropertiesFragment> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the status of the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status message from the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "deploymentStatusMessage")]
        public string DeploymentStatusMessage { get; set; }

        /// <summary>
        /// Gets or sets the status message from the virtual machine extension.
        /// </summary>
        [JsonProperty(PropertyName = "vmExtensionStatusMessage")]
        public string VmExtensionStatusMessage { get; set; }

        /// <summary>
        /// Gets or sets the time that the artifact starts to install on the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "installTime")]
        public System.DateTime? InstallTime { get; set; }

    }
}
