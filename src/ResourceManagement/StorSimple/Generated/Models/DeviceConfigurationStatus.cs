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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeviceConfigurationStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceConfigurationStatus
    {
        [EnumMember(Value = "Complete")]
        Complete,
        [EnumMember(Value = "Pending")]
        Pending
    }
    internal static class DeviceConfigurationStatusEnumExtension
    {
        internal static string ToSerializedValue(this DeviceConfigurationStatus? value)
        {
            return value == null ? null : ((DeviceConfigurationStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DeviceConfigurationStatus value)
        {
            switch( value )
            {
                case DeviceConfigurationStatus.Complete:
                    return "Complete";
                case DeviceConfigurationStatus.Pending:
                    return "Pending";
            }
            return null;
        }

        internal static DeviceConfigurationStatus? ParseDeviceConfigurationStatus(this string value)
        {
            switch( value )
            {
                case "Complete":
                    return DeviceConfigurationStatus.Complete;
                case "Pending":
                    return DeviceConfigurationStatus.Pending;
            }
            return null;
        }
    }
}
