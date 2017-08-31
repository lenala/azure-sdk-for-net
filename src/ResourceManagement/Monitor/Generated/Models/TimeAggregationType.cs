// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TimeAggregationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeAggregationType
    {
        [EnumMember(Value = "Average")]
        Average,
        [EnumMember(Value = "Minimum")]
        Minimum,
        [EnumMember(Value = "Maximum")]
        Maximum,
        [EnumMember(Value = "Total")]
        Total,
        [EnumMember(Value = "Count")]
        Count
    }
    internal static class TimeAggregationTypeEnumExtension
    {
        internal static string ToSerializedValue(this TimeAggregationType? value)  =>
            value == null ? null : ((TimeAggregationType)value).ToSerializedValue();

        internal static string ToSerializedValue(this TimeAggregationType value)
        {
            switch( value )
            {
                case TimeAggregationType.Average:
                    return "Average";
                case TimeAggregationType.Minimum:
                    return "Minimum";
                case TimeAggregationType.Maximum:
                    return "Maximum";
                case TimeAggregationType.Total:
                    return "Total";
                case TimeAggregationType.Count:
                    return "Count";
            }
            return null;
        }

        internal static TimeAggregationType? ParseTimeAggregationType(this string value)
        {
            switch( value )
            {
                case "Average":
                    return TimeAggregationType.Average;
                case "Minimum":
                    return TimeAggregationType.Minimum;
                case "Maximum":
                    return TimeAggregationType.Maximum;
                case "Total":
                    return TimeAggregationType.Total;
                case "Count":
                    return TimeAggregationType.Count;
            }
            return null;
        }
    }
}
