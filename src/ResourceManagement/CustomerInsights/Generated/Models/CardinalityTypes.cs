// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CardinalityTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardinalityTypes
    {
        [EnumMember(Value = "OneToOne")]
        OneToOne,
        [EnumMember(Value = "OneToMany")]
        OneToMany,
        [EnumMember(Value = "ManyToMany")]
        ManyToMany
    }
    internal static class CardinalityTypesEnumExtension
    {
        internal static string ToSerializedValue(this CardinalityTypes? value)
        {
            return value == null ? null : ((CardinalityTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CardinalityTypes value)
        {
            switch( value )
            {
                case CardinalityTypes.OneToOne:
                    return "OneToOne";
                case CardinalityTypes.OneToMany:
                    return "OneToMany";
                case CardinalityTypes.ManyToMany:
                    return "ManyToMany";
            }
            return null;
        }

        internal static CardinalityTypes? ParseCardinalityTypes(this string value)
        {
            switch( value )
            {
                case "OneToOne":
                    return CardinalityTypes.OneToOne;
                case "OneToMany":
                    return CardinalityTypes.OneToMany;
                case "ManyToMany":
                    return CardinalityTypes.ManyToMany;
            }
            return null;
        }
    }
}
