// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Options when disabling a job.
    /// </summary>
    public partial class JobDisableParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobDisableParameter class.
        /// </summary>
        public JobDisableParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobDisableParameter class.
        /// </summary>
        /// <param name="disableTasks">What to do with active tasks associated
        /// with the job.</param>
        public JobDisableParameter(DisableJobOption disableTasks)
        {
            DisableTasks = disableTasks;
        }

        /// <summary>
        /// Gets or sets what to do with active tasks associated with the job.
        /// </summary>
        /// <remarks>
        /// requeue - Terminate running tasks and requeue them. The tasks will
        /// run again when the job is enabled. terminate - Terminate running
        /// tasks. The tasks will not run again. wait - Allow currently running
        /// tasks to complete. Possible values include: 'requeue', 'terminate',
        /// 'wait'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disableTasks")]
        public DisableJobOption DisableTasks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
