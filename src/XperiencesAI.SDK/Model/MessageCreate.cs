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
    /// Schema for creating a new message.
    /// </summary>
    public partial class MessageCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCreate" /> class.
        /// </summary>
        /// <param name="role">Role of the message sender</param>
        /// <param name="content">Content of the message</param>
        /// <param name="metaData">Additional meta_data for the message</param>
        [JsonConstructor]
        public MessageCreate(MessageRole role, string content, Option<Dictionary<string, Object>?> metaData = default)
        {
            Role = role;
            Content = content;
            MetaDataOption = metaData;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Role of the message sender
        /// </summary>
        /// <value>Role of the message sender</value>
        [JsonPropertyName("role")]
        public MessageRole Role { get; set; }

        /// <summary>
        /// Content of the message
        /// </summary>
        /// <value>Content of the message</value>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// Used to track the state of MetaData
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, Object>?> MetaDataOption { get; private set; }

        /// <summary>
        /// Additional meta_data for the message
        /// </summary>
        /// <value>Additional meta_data for the message</value>
        [JsonPropertyName("meta_data")]
        public Dictionary<string, Object>? MetaData { get { return this.MetaDataOption; } set { this.MetaDataOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageCreate {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MessageCreate" />
    /// </summary>
    public class MessageCreateJsonConverter : JsonConverter<MessageCreate>
    {
        /// <summary>
        /// Deserializes json to <see cref="MessageCreate" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MessageCreate Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<MessageRole?> role = default;
            Option<string?> content = default;
            Option<Dictionary<string, Object>?> metaData = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "role":
                            string? roleRawValue = utf8JsonReader.GetString();
                            if (roleRawValue != null)
                                role = new Option<MessageRole?>(MessageRoleValueConverter.FromStringOrDefault(roleRawValue));
                            break;
                        case "content":
                            content = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "meta_data":
                            metaData = new Option<Dictionary<string, Object>?>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!role.IsSet)
                throw new ArgumentException("Property is required for class MessageCreate.", nameof(role));

            if (!content.IsSet)
                throw new ArgumentException("Property is required for class MessageCreate.", nameof(content));

            if (role.IsSet && role.Value == null)
                throw new ArgumentNullException(nameof(role), "Property is not nullable for class MessageCreate.");

            if (content.IsSet && content.Value == null)
                throw new ArgumentNullException(nameof(content), "Property is not nullable for class MessageCreate.");

            if (metaData.IsSet && metaData.Value == null)
                throw new ArgumentNullException(nameof(metaData), "Property is not nullable for class MessageCreate.");

            return new MessageCreate(role.Value!.Value!, content.Value!, metaData);
        }

        /// <summary>
        /// Serializes a <see cref="MessageCreate" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="messageCreate"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MessageCreate messageCreate, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, messageCreate, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MessageCreate" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="messageCreate"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MessageCreate messageCreate, JsonSerializerOptions jsonSerializerOptions)
        {
            if (messageCreate.Content == null)
                throw new ArgumentNullException(nameof(messageCreate.Content), "Property is required for class MessageCreate.");

            if (messageCreate.MetaDataOption.IsSet && messageCreate.MetaData == null)
                throw new ArgumentNullException(nameof(messageCreate.MetaData), "Property is required for class MessageCreate.");

            var roleRawValue = MessageRoleValueConverter.ToJsonValue(messageCreate.Role);
            writer.WriteString("role", roleRawValue);

            writer.WriteString("content", messageCreate.Content);

            if (messageCreate.MetaDataOption.IsSet)
            {
                writer.WritePropertyName("meta_data");
                JsonSerializer.Serialize(writer, messageCreate.MetaData, jsonSerializerOptions);
            }
        }
    }
}
