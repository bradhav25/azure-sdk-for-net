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
    /// Defines values for UsageState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UsageState
    {
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Exceeded")]
        Exceeded
    }
    internal static class UsageStateEnumExtension
    {
        internal static string ToSerializedValue(this UsageState? value)  =>
            value == null ? null : ((UsageState)value).ToSerializedValue();

        internal static string ToSerializedValue(this UsageState value)
        {
            switch( value )
            {
                case UsageState.Normal:
                    return "Normal";
                case UsageState.Exceeded:
                    return "Exceeded";
            }
            return null;
        }

        internal static UsageState? ParseUsageState(this string value)
        {
            switch( value )
            {
                case "Normal":
                    return UsageState.Normal;
                case "Exceeded":
                    return UsageState.Exceeded;
            }
            return null;
        }
    }
}