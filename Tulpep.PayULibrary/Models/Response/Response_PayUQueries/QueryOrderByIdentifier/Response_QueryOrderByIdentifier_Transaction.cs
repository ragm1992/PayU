﻿using Tulpep.PayULibrary.Models.Response.Response_Cross;

namespace Tulpep.PayULibrary.Models.Response.Response_PayUQueries.QueryOrderByIdentifier
{
    public class Response_QueryOrderByIdentifier_Transaction
    {
        public string id { get; set; }
        public string order { get; set; }
        public Response_QueryOrderByIdentifier_CreditCard creditCard { get; set; }
        public string type { get; set; }
        public string parentTransactionId { get; set; }
        public string paymentMethod { get; set; }
        public string source { get; set; }
        public string paymentCountry { get; set; }
        public Response_QueryOrderByIdentifier_TransactionResponse transactionResponse { get; set; }
        public string deviceSessionId { get; set; }
        public string ipAddress { get; set; }
        public string cookie { get; set; }
        public string userAgent { get; set; }
        public string expirationDate { get; set; }
        public Response_QueryOrderByIdentifier_Payer payer { get; set; }
        public Response_AdditionalValues additionalValues { get; set; }
        public Response_ExtraParameters extraParameters { get; set; }
    }
}
