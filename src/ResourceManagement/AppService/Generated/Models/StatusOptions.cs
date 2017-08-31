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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StatusOptions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusOptions
    {
        [EnumMember(Value = "Ready")]
        Ready,
        [EnumMember(Value = "Pending")]
        Pending
    }
    internal static class StatusOptionsEnumExtension
    {
        internal static string ToSerializedValue(this StatusOptions? value)  =>
            value == null ? null : ((StatusOptions)value).ToSerializedValue();

        internal static string ToSerializedValue(this StatusOptions value)
        {
            switch( value )
            {
                case StatusOptions.Ready:
                    return "Ready";
                case StatusOptions.Pending:
                    return "Pending";
            }
            return null;
        }

        internal static StatusOptions? ParseStatusOptions(this string value)
        {
            switch( value )
            {
                case "Ready":
                    return StatusOptions.Ready;
                case "Pending":
                    return StatusOptions.Pending;
            }
            return null;
        }
    }
}
