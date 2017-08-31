// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Scheduler.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Scheduler;
    using Microsoft.Azure.Management.Scheduler.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JobStatus
    {
        /// <summary>
        /// Initializes a new instance of the JobStatus class.
        /// </summary>
        public JobStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStatus class.
        /// </summary>
        /// <param name="executionCount">Gets the number of times this job has
        /// executed.</param>
        /// <param name="failureCount">Gets the number of times this job has
        /// failed.</param>
        /// <param name="faultedCount">Gets the number of faulted occurrences
        /// (occurrences that were retried and failed as many times as the
        /// retry policy states).</param>
        /// <param name="lastExecutionTime">Gets the time the last occurrence
        /// executed in ISO-8601 format.  Could be empty if job has not run
        /// yet.</param>
        /// <param name="nextExecutionTime">Gets the time of the next
        /// occurrence in ISO-8601 format. Could be empty if the job is
        /// completed.</param>
        public JobStatus(int? executionCount = default(int?), int? failureCount = default(int?), int? faultedCount = default(int?), System.DateTime? lastExecutionTime = default(System.DateTime?), System.DateTime? nextExecutionTime = default(System.DateTime?))
        {
            ExecutionCount = executionCount;
            FailureCount = failureCount;
            FaultedCount = faultedCount;
            LastExecutionTime = lastExecutionTime;
            NextExecutionTime = nextExecutionTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the number of times this job has executed.
        /// </summary>
        [JsonProperty(PropertyName = "executionCount")]
        public int? ExecutionCount { get; private set; }

        /// <summary>
        /// Gets the number of times this job has failed.
        /// </summary>
        [JsonProperty(PropertyName = "failureCount")]
        public int? FailureCount { get; private set; }

        /// <summary>
        /// Gets the number of faulted occurrences (occurrences that were
        /// retried and failed as many times as the retry policy states).
        /// </summary>
        [JsonProperty(PropertyName = "faultedCount")]
        public int? FaultedCount { get; private set; }

        /// <summary>
        /// Gets the time the last occurrence executed in ISO-8601 format.
        /// Could be empty if job has not run yet.
        /// </summary>
        [JsonProperty(PropertyName = "lastExecutionTime")]
        public System.DateTime? LastExecutionTime { get; private set; }

        /// <summary>
        /// Gets the time of the next occurrence in ISO-8601 format. Could be
        /// empty if the job is completed.
        /// </summary>
        [JsonProperty(PropertyName = "nextExecutionTime")]
        public System.DateTime? NextExecutionTime { get; private set; }

    }
}
