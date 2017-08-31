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
    /// Application logs configuration.
    /// </summary>
    public partial class ApplicationLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationLogsConfig class.
        /// </summary>
        public ApplicationLogsConfig()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationLogsConfig class.
        /// </summary>
        /// <param name="fileSystem">Application logs to file system
        /// configuration.</param>
        /// <param name="azureTableStorage">Application logs to azure table
        /// storage configuration.</param>
        /// <param name="azureBlobStorage">Application logs to blob storage
        /// configuration.</param>
        public ApplicationLogsConfig(FileSystemApplicationLogsConfig fileSystem = default(FileSystemApplicationLogsConfig), AzureTableStorageApplicationLogsConfig azureTableStorage = default(AzureTableStorageApplicationLogsConfig), AzureBlobStorageApplicationLogsConfig azureBlobStorage = default(AzureBlobStorageApplicationLogsConfig))
        {
            FileSystem = fileSystem;
            AzureTableStorage = azureTableStorage;
            AzureBlobStorage = azureBlobStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application logs to file system configuration.
        /// </summary>
        [JsonProperty(PropertyName = "fileSystem")]
        public FileSystemApplicationLogsConfig FileSystem { get; set; }

        /// <summary>
        /// Gets or sets application logs to azure table storage configuration.
        /// </summary>
        [JsonProperty(PropertyName = "azureTableStorage")]
        public AzureTableStorageApplicationLogsConfig AzureTableStorage { get; set; }

        /// <summary>
        /// Gets or sets application logs to blob storage configuration.
        /// </summary>
        [JsonProperty(PropertyName = "azureBlobStorage")]
        public AzureBlobStorageApplicationLogsConfig AzureBlobStorage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AzureTableStorage != null)
            {
                AzureTableStorage.Validate();
            }
        }
    }
}
