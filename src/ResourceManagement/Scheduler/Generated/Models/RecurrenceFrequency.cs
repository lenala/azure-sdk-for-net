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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RecurrenceFrequency.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurrenceFrequency
    {
        [EnumMember(Value = "Minute")]
        Minute,
        [EnumMember(Value = "Hour")]
        Hour,
        [EnumMember(Value = "Day")]
        Day,
        [EnumMember(Value = "Week")]
        Week,
        [EnumMember(Value = "Month")]
        Month
    }
    internal static class RecurrenceFrequencyEnumExtension
    {
        internal static string ToSerializedValue(this RecurrenceFrequency? value)  =>
            value == null ? null : ((RecurrenceFrequency)value).ToSerializedValue();

        internal static string ToSerializedValue(this RecurrenceFrequency value)
        {
            switch( value )
            {
                case RecurrenceFrequency.Minute:
                    return "Minute";
                case RecurrenceFrequency.Hour:
                    return "Hour";
                case RecurrenceFrequency.Day:
                    return "Day";
                case RecurrenceFrequency.Week:
                    return "Week";
                case RecurrenceFrequency.Month:
                    return "Month";
            }
            return null;
        }

        internal static RecurrenceFrequency? ParseRecurrenceFrequency(this string value)
        {
            switch( value )
            {
                case "Minute":
                    return RecurrenceFrequency.Minute;
                case "Hour":
                    return RecurrenceFrequency.Hour;
                case "Day":
                    return RecurrenceFrequency.Day;
                case "Week":
                    return RecurrenceFrequency.Week;
                case "Month":
                    return RecurrenceFrequency.Month;
            }
            return null;
        }
    }
}
