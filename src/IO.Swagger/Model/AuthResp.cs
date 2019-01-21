/* 
 * Saque e Pague Sonda
 *
 * Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.
 *
 * OpenAPI spec version: 1.1.1-sw2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Objeto de resposta de autenticação.
    /// </summary>
    [DataContract]
    public partial class AuthResp :  IEquatable<AuthResp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResp" /> class.
        /// </summary>
        /// <param name="accessToken">Token de acesso para requisição de sonda. (required).</param>
        /// <param name="expiresIn">Tempo de expiração do token em segundos. (required).</param>
        /// <param name="tokenType">Tipo de token gerado para ser usado na requisição sonda. Deve ser sempre \&quot;bearer\&quot; (required).</param>
        public AuthResp(string accessToken = default(string), long? expiresIn = default(long?), string tokenType = default(string))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new InvalidDataException("accessToken is a required property for AuthResp and cannot be null");
            }
            else
            {
                this.AccessToken = accessToken;
            }
            // to ensure "expiresIn" is required (not null)
            if (expiresIn == null)
            {
                throw new InvalidDataException("expiresIn is a required property for AuthResp and cannot be null");
            }
            else
            {
                this.ExpiresIn = expiresIn;
            }
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new InvalidDataException("tokenType is a required property for AuthResp and cannot be null");
            }
            else
            {
                this.TokenType = tokenType;
            }
        }
        
        /// <summary>
        /// Token de acesso para requisição de sonda.
        /// </summary>
        /// <value>Token de acesso para requisição de sonda.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Tempo de expiração do token em segundos.
        /// </summary>
        /// <value>Tempo de expiração do token em segundos.</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// Tipo de token gerado para ser usado na requisição sonda. Deve ser sempre \&quot;bearer\&quot;
        /// </summary>
        /// <value>Tipo de token gerado para ser usado na requisição sonda. Deve ser sempre \&quot;bearer\&quot;</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthResp {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthResp);
        }

        /// <summary>
        /// Returns true if AuthResp instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}