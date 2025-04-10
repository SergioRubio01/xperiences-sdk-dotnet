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
    /// Response schema for agent operations. Extends the base Agent schema with additional response-specific fields.
    /// </summary>
    public partial class AgentResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponse" /> class.
        /// </summary>
        /// <param name="name">Name of the agent</param>
        /// <param name="id">Unique identifier for the agent</param>
        /// <param name="status">Current status of the agent</param>
        /// <param name="varConfiguration">Additional configuration for the agent</param>
        /// <param name="createdAt">Creation timestamp</param>
        /// <param name="updatedAt">Last update timestamp</param>
        /// <param name="description">description</param>
        /// <param name="assistantId">assistantId</param>
        /// <param name="promptTemplate">promptTemplate</param>
        /// <param name="errorMessage">errorMessage</param>
        [JsonConstructor]
        public AgentResponse(string name, string id, AgentStatus status, Dictionary<string, Object> varConfiguration, DateTime createdAt, DateTime updatedAt, Option<string?> description = default, Option<string?> assistantId = default, Option<string?> promptTemplate = default, Option<string?> errorMessage = default)
        {
            Name = name;
            Id = id;
            Status = status;
            VarConfiguration = varConfiguration;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DescriptionOption = description;
            AssistantIdOption = assistantId;
            PromptTemplateOption = promptTemplate;
            ErrorMessageOption = errorMessage;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Current status of the agent
        /// </summary>
        /// <value>Current status of the agent</value>
        [JsonPropertyName("status")]
        public AgentStatus Status { get; set; }

        /// <summary>
        /// Name of the agent
        /// </summary>
        /// <value>Name of the agent</value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier for the agent
        /// </summary>
        /// <value>Unique identifier for the agent</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Additional configuration for the agent
        /// </summary>
        /// <value>Additional configuration for the agent</value>
        [JsonPropertyName("configuration")]
        public Dictionary<string, Object> VarConfiguration { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        /// <value>Creation timestamp</value>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        /// <value>Last update timestamp</value>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of AssistantId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AssistantIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets AssistantId
        /// </summary>
        [JsonPropertyName("assistant_id")]
        public string? AssistantId { get { return this.AssistantIdOption; } set { this.AssistantIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of PromptTemplate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PromptTemplateOption { get; private set; }

        /// <summary>
        /// Gets or Sets PromptTemplate
        /// </summary>
        [JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get { return this.PromptTemplateOption; } set { this.PromptTemplateOption = new(value); } }

        /// <summary>
        /// Used to track the state of ErrorMessage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ErrorMessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get { return this.ErrorMessageOption; } set { this.ErrorMessageOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgentResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
            sb.Append("  PromptTemplate: ").Append(PromptTemplate).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
    /// A Json converter for type <see cref="AgentResponse" />
    /// </summary>
    public class AgentResponseJsonConverter : JsonConverter<AgentResponse>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="AgentResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AgentResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> id = default;
            Option<AgentStatus?> status = default;
            Option<Dictionary<string, Object>?> varConfiguration = default;
            Option<DateTime?> createdAt = default;
            Option<DateTime?> updatedAt = default;
            Option<string?> description = default;
            Option<string?> assistantId = default;
            Option<string?> promptTemplate = default;
            Option<string?> errorMessage = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<AgentStatus?>(AgentStatusValueConverter.FromStringOrDefault(statusRawValue));
                            break;
                        case "configuration":
                            varConfiguration = new Option<Dictionary<string, Object>?>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "created_at":
                            createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updated_at":
                            updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "assistant_id":
                            assistantId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "prompt_template":
                            promptTemplate = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "error_message":
                            errorMessage = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class AgentResponse.", nameof(name));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AgentResponse.", nameof(id));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class AgentResponse.", nameof(status));

            if (!varConfiguration.IsSet)
                throw new ArgumentException("Property is required for class AgentResponse.", nameof(varConfiguration));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AgentResponse.", nameof(createdAt));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AgentResponse.", nameof(updatedAt));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class AgentResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AgentResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class AgentResponse.");

            if (varConfiguration.IsSet && varConfiguration.Value == null)
                throw new ArgumentNullException(nameof(varConfiguration), "Property is not nullable for class AgentResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AgentResponse.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AgentResponse.");

            return new AgentResponse(name.Value!, id.Value!, status.Value!.Value!, varConfiguration.Value!, createdAt.Value!.Value!, updatedAt.Value!.Value!, description, assistantId, promptTemplate, errorMessage);
        }

        /// <summary>
        /// Serializes a <see cref="AgentResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="agentResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AgentResponse agentResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, agentResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AgentResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="agentResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AgentResponse agentResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (agentResponse.Name == null)
                throw new ArgumentNullException(nameof(agentResponse.Name), "Property is required for class AgentResponse.");

            if (agentResponse.Id == null)
                throw new ArgumentNullException(nameof(agentResponse.Id), "Property is required for class AgentResponse.");

            if (agentResponse.VarConfiguration == null)
                throw new ArgumentNullException(nameof(agentResponse.VarConfiguration), "Property is required for class AgentResponse.");

            writer.WriteString("name", agentResponse.Name);

            writer.WriteString("id", agentResponse.Id);

            var statusRawValue = AgentStatusValueConverter.ToJsonValue(agentResponse.Status);
            writer.WriteString("status", statusRawValue);

            writer.WritePropertyName("configuration");
            JsonSerializer.Serialize(writer, agentResponse.VarConfiguration, jsonSerializerOptions);
            writer.WriteString("created_at", agentResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("updated_at", agentResponse.UpdatedAt.ToString(UpdatedAtFormat));

            if (agentResponse.DescriptionOption.IsSet)
                if (agentResponse.DescriptionOption.Value != null)
                    writer.WriteString("description", agentResponse.Description);
                else
                    writer.WriteNull("description");

            if (agentResponse.AssistantIdOption.IsSet)
                if (agentResponse.AssistantIdOption.Value != null)
                    writer.WriteString("assistant_id", agentResponse.AssistantId);
                else
                    writer.WriteNull("assistant_id");

            if (agentResponse.PromptTemplateOption.IsSet)
                if (agentResponse.PromptTemplateOption.Value != null)
                    writer.WriteString("prompt_template", agentResponse.PromptTemplate);
                else
                    writer.WriteNull("prompt_template");

            if (agentResponse.ErrorMessageOption.IsSet)
                if (agentResponse.ErrorMessageOption.Value != null)
                    writer.WriteString("error_message", agentResponse.ErrorMessage);
                else
                    writer.WriteNull("error_message");
        }
    }
}
