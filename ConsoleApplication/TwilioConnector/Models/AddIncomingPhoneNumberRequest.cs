// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication.Models
{
    public partial class AddIncomingPhoneNumberRequest
    {
        private string _areaCode;
        
        /// <summary>
        /// Optional. Area Code
        /// </summary>
        public string AreaCode
        {
            get { return this._areaCode; }
            set { this._areaCode = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Friendly Name
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _phoneNumber;
        
        /// <summary>
        /// Required. Phone Number
        /// </summary>
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AddIncomingPhoneNumberRequest
        /// class.
        /// </summary>
        public AddIncomingPhoneNumberRequest()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AddIncomingPhoneNumberRequest
        /// class with required arguments.
        /// </summary>
        public AddIncomingPhoneNumberRequest(string phoneNumber)
            : this()
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("phoneNumber");
            }
            this.PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type AddIncomingPhoneNumberRequest
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.PhoneNumber == null)
            {
                throw new ArgumentNullException("PhoneNumber");
            }
            if (this.AreaCode != null)
            {
                outputObject["AreaCode"] = this.AreaCode;
            }
            if (this.FriendlyName != null)
            {
                outputObject["FriendlyName"] = this.FriendlyName;
            }
            if (this.PhoneNumber != null)
            {
                outputObject["PhoneNumber"] = this.PhoneNumber;
            }
            return outputObject;
        }
    }
}
