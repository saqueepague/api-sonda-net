/* 
 * Sonda Saque e Pague
 *
 * Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.
 *
 * OpenAPI spec version: 1.1.0
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
    /// Objeto de resposta da sonda, contém o objeto da transação sondada. Caso não encontre a transação vai retornar estado pendente.
    /// </summary>
    [DataContract]
    public partial class SondaResp :  IEquatable<SondaResp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SondaResp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SondaResp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SondaResp" /> class.
        /// </summary>
        /// <param name="infTransacao">infTransacao (required).</param>
        public SondaResp(SondaRespInfTransacao infTransacao = default(SondaRespInfTransacao))
        {
            // to ensure "infTransacao" is required (not null)
            if (infTransacao == null)
            {
                throw new InvalidDataException("infTransacao is a required property for SondaResp and cannot be null");
            }
            else
            {
                this.InfTransacao = infTransacao;
            }
        }
        
        /// <summary>
        /// Gets or Sets InfTransacao
        /// </summary>
        [DataMember(Name="InfTransacao", EmitDefaultValue=false)]
        public SondaRespInfTransacao InfTransacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SondaResp {\n");
            sb.Append("  InfTransacao: ").Append(InfTransacao).Append("\n");
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
            return this.Equals(input as SondaResp);
        }

        /// <summary>
        /// Returns true if SondaResp instances are equal
        /// </summary>
        /// <param name="input">Instance of SondaResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SondaResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InfTransacao == input.InfTransacao ||
                    (this.InfTransacao != null &&
                    this.InfTransacao.Equals(input.InfTransacao))
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
                if (this.InfTransacao != null)
                    hashCode = hashCode * 59 + this.InfTransacao.GetHashCode();
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
