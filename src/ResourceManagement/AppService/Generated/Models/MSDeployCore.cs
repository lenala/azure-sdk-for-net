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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// MSDeploy ARM PUT core information
    /// </summary>
    public partial class MSDeployCore
    {
        /// <summary>
        /// Initializes a new instance of the MSDeployCore class.
        /// </summary>
        public MSDeployCore()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MSDeployCore class.
        /// </summary>
        /// <param name="packageUri">Package URI</param>
        /// <param name="connectionString">SQL Connection String</param>
        /// <param name="dbType">Database Type</param>
        /// <param name="setParametersXmlFileUri">URI of MSDeploy Parameters
        /// file. Must not be set if SetParameters is used.</param>
        /// <param name="setParameters">MSDeploy Parameters. Must not be set if
        /// SetParametersXmlFileUri is used.</param>
        /// <param name="skipAppData">Controls whether the MSDeploy operation
        /// skips the AppData directory. If set to true, the existing AppData
        /// directory on the destination will not be deleted and
        /// overwritten.</param>
        /// <param name="appOffline">Sets the AppOffline rule while the
        /// MSDeploy operation executes.</param>
        public MSDeployCore(string packageUri = default(string), string connectionString = default(string), string dbType = default(string), string setParametersXmlFileUri = default(string), IDictionary<string, string> setParameters = default(IDictionary<string, string>), bool? skipAppData = default(bool?), bool? appOffline = default(bool?))
        {
            PackageUri = packageUri;
            ConnectionString = connectionString;
            DbType = dbType;
            SetParametersXmlFileUri = setParametersXmlFileUri;
            SetParameters = setParameters;
            SkipAppData = skipAppData;
            AppOffline = appOffline;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets package URI
        /// </summary>
        [JsonProperty(PropertyName = "packageUri")]
        public string PackageUri { get; set; }

        /// <summary>
        /// Gets or sets SQL Connection String
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets database Type
        /// </summary>
        [JsonProperty(PropertyName = "dbType")]
        public string DbType { get; set; }

        /// <summary>
        /// Gets or sets URI of MSDeploy Parameters file. Must not be set if
        /// SetParameters is used.
        /// </summary>
        [JsonProperty(PropertyName = "setParametersXmlFileUri")]
        public string SetParametersXmlFileUri { get; set; }

        /// <summary>
        /// Gets or sets mSDeploy Parameters. Must not be set if
        /// SetParametersXmlFileUri is used.
        /// </summary>
        [JsonProperty(PropertyName = "setParameters")]
        public IDictionary<string, string> SetParameters { get; set; }

        /// <summary>
        /// Gets or sets controls whether the MSDeploy operation skips the
        /// AppData directory. If set to true, the existing AppData directory
        /// on the destination will not be deleted and overwritten.
        /// </summary>
        [JsonProperty(PropertyName = "skipAppData")]
        public bool? SkipAppData { get; set; }

        /// <summary>
        /// Gets or sets sets the AppOffline rule while the MSDeploy operation
        /// executes.
        /// </summary>
        [JsonProperty(PropertyName = "appOffline")]
        public bool? AppOffline { get; set; }

    }
}
