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
    /// Defines values for CloneAbilityResult.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CloneAbilityResult
    {
        [EnumMember(Value = "Cloneable")]
        Cloneable,
        [EnumMember(Value = "PartiallyCloneable")]
        PartiallyCloneable,
        [EnumMember(Value = "NotCloneable")]
        NotCloneable
    }
    internal static class CloneAbilityResultEnumExtension
    {
        internal static string ToSerializedValue(this CloneAbilityResult? value)  =>
            value == null ? null : ((CloneAbilityResult)value).ToSerializedValue();

        internal static string ToSerializedValue(this CloneAbilityResult value)
        {
            switch( value )
            {
                case CloneAbilityResult.Cloneable:
                    return "Cloneable";
                case CloneAbilityResult.PartiallyCloneable:
                    return "PartiallyCloneable";
                case CloneAbilityResult.NotCloneable:
                    return "NotCloneable";
            }
            return null;
        }

        internal static CloneAbilityResult? ParseCloneAbilityResult(this string value)
        {
            switch( value )
            {
                case "Cloneable":
                    return CloneAbilityResult.Cloneable;
                case "PartiallyCloneable":
                    return CloneAbilityResult.PartiallyCloneable;
                case "NotCloneable":
                    return CloneAbilityResult.NotCloneable;
            }
            return null;
        }
    }
}
