// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication.Models
{
    public partial class MessageResponse
    {
        private string _body;
        
        /// <summary>
        /// Optional. Body
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }
        
        private DateTimeOffset? _dateCreated;
        
        /// <summary>
        /// Optional. Date Created
        /// </summary>
        public DateTimeOffset? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }
        
        private DateTimeOffset? _dateSent;
        
        /// <summary>
        /// Optional. Date Sent
        /// </summary>
        public DateTimeOffset? DateSent
        {
            get { return this._dateSent; }
            set { this._dateSent = value; }
        }
        
        private string _direction;
        
        /// <summary>
        /// Optional. Direction
        /// </summary>
        public string Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }
        
        private string _errorCode;
        
        /// <summary>
        /// Optional. Direction
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Direction
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _fromVariable;
        
        /// <summary>
        /// Optional. From Phone Number
        /// </summary>
        public string From
        {
            get { return this._fromVariable; }
            set { this._fromVariable = value; }
        }
        
        private double? _price;
        
        /// <summary>
        /// Optional. Price
        /// </summary>
        public double? Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        
        private string _sid;
        
        /// <summary>
        /// Optional. Sid
        /// </summary>
        public string Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Status
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _to;
        
        /// <summary>
        /// Optional. To Phone number
        /// </summary>
        public string TO
        {
            get { return this._to; }
            set { this._to = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MessageResponse class.
        /// </summary>
        public MessageResponse()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken bodyValue = inputObject["body"];
                if (bodyValue != null && bodyValue.Type != JTokenType.Null)
                {
                    this.Body = ((string)bodyValue);
                }
                JToken dateCreatedValue = inputObject["date_created"];
                if (dateCreatedValue != null && dateCreatedValue.Type != JTokenType.Null)
                {
                    this.DateCreated = ((DateTimeOffset)dateCreatedValue);
                }
                JToken dateSentValue = inputObject["date_sent"];
                if (dateSentValue != null && dateSentValue.Type != JTokenType.Null)
                {
                    this.DateSent = ((DateTimeOffset)dateSentValue);
                }
                JToken directionValue = inputObject["direction"];
                if (directionValue != null && directionValue.Type != JTokenType.Null)
                {
                    this.Direction = ((string)directionValue);
                }
                JToken errorCodeValue = inputObject["error_code"];
                if (errorCodeValue != null && errorCodeValue.Type != JTokenType.Null)
                {
                    this.ErrorCode = ((string)errorCodeValue);
                }
                JToken errorMessageValue = inputObject["error_message"];
                if (errorMessageValue != null && errorMessageValue.Type != JTokenType.Null)
                {
                    this.ErrorMessage = ((string)errorMessageValue);
                }
                JToken fromValue = inputObject["from"];
                if (fromValue != null && fromValue.Type != JTokenType.Null)
                {
                    this.From = ((string)fromValue);
                }
                JToken priceValue = inputObject["price"];
                if (priceValue != null && priceValue.Type != JTokenType.Null)
                {
                    this.Price = ((double)priceValue);
                }
                JToken sidValue = inputObject["sid"];
                if (sidValue != null && sidValue.Type != JTokenType.Null)
                {
                    this.Sid = ((string)sidValue);
                }
                JToken statusValue = inputObject["status"];
                if (statusValue != null && statusValue.Type != JTokenType.Null)
                {
                    this.Status = ((string)statusValue);
                }
                JToken toValue = inputObject["to"];
                if (toValue != null && toValue.Type != JTokenType.Null)
                {
                    this.TO = ((string)toValue);
                }
            }
        }
    }
}
