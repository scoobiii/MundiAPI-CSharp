/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class GetCheckoutCardPaymentResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string statementDescriptor;
        private List<Models.GetCheckoutCardInstallmentOptionsResponse> installments;

        /// <summary>
        /// Descrição na fatura
        /// </summary>
        [JsonProperty("statementDescriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Parcelas
        /// </summary>
        [JsonProperty("installments")]
        public List<Models.GetCheckoutCardInstallmentOptionsResponse> Installments 
        { 
            get 
            {
                return this.installments; 
            } 
            set 
            {
                this.installments = value;
                onPropertyChanged("Installments");
            }
        }
    }
} 