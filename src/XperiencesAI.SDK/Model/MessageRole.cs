// <auto-generated>
/*
 * Xperiences API
 *
 * API for VR mentoring experiences
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: support@xperiences.ai
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using XperiencesAI.SDK.Client;

namespace XperiencesAI.SDK.Model
{
    /// <summary>
    /// Enum for message roles.
    /// </summary>
    /// <value>Enum for message roles.</value>
    public enum MessageRole
    {
        /// <summary>
        /// Enum System for value: system
        /// </summary>
        System = 1,

        /// <summary>
        /// Enum User for value: user
        /// </summary>
        User = 2,

        /// <summary>
        /// Enum Assistant for value: assistant
        /// </summary>
        Assistant = 3,

        /// <summary>
        /// Enum Function for value: function
        /// </summary>
        Function = 4
    }

    /// <summary>
    /// Converts <see cref="MessageRole"/> to and from the JSON value
    /// </summary>
    public static class MessageRoleValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="MessageRole"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MessageRole FromString(string value)
        {
            if (value.Equals("system"))
                return MessageRole.System;

            if (value.Equals("user"))
                return MessageRole.User;

            if (value.Equals("assistant"))
                return MessageRole.Assistant;

            if (value.Equals("function"))
                return MessageRole.Function;

            throw new NotImplementedException($"Could not convert value to type MessageRole: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="MessageRole"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MessageRole? FromStringOrDefault(string value)
        {
            if (value.Equals("system"))
                return MessageRole.System;

            if (value.Equals("user"))
                return MessageRole.User;

            if (value.Equals("assistant"))
                return MessageRole.Assistant;

            if (value.Equals("function"))
                return MessageRole.Function;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="MessageRole"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(MessageRole value)
        {
            if (value == MessageRole.System)
                return "system";

            if (value == MessageRole.User)
                return "user";

            if (value == MessageRole.Assistant)
                return "assistant";

            if (value == MessageRole.Function)
                return "function";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MessageRole"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class MessageRoleJsonConverter : JsonConverter<MessageRole>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MessageRole Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            MessageRole? result = rawValue == null
                ? null
                : MessageRoleValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the MessageRole to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="messageRole"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MessageRole messageRole, JsonSerializerOptions options)
        {
            writer.WriteStringValue(messageRole.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MessageRole"/>
    /// </summary>
    public class MessageRoleNullableJsonConverter : JsonConverter<MessageRole?>
    {
        /// <summary>
        /// Returns a MessageRole from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MessageRole? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            MessageRole? result = rawValue == null
                ? null
                : MessageRoleValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="messageRole"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MessageRole? messageRole, JsonSerializerOptions options)
        {
            writer.WriteStringValue(messageRole?.ToString() ?? "null");
        }
    }
}
