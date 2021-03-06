// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApplication;
using ConsoleApplication.Models;
using Microsoft.Rest;

namespace ConsoleApplication
{
    public static partial class TwilioConnectorExtensions
    {
        /// <summary>
        /// If a phone number is provided instead, adds a new phone number to
        /// your account. If an area code is provided, adds a random phone
        /// number available for the area depending on the Area Code provided.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='addIncomingPhoneNumberRequest'>
        /// Required. Add Incoming Phone Number Request Model
        /// </param>
        public static IncomingPhoneNumber AddIncomingNumber(this ITwilioConnector operations, AddIncomingPhoneNumberRequest addIncomingPhoneNumberRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).AddIncomingNumberAsync(addIncomingPhoneNumberRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// If a phone number is provided instead, adds a new phone number to
        /// your account. If an area code is provided, adds a random phone
        /// number available for the area depending on the Area Code provided.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='addIncomingPhoneNumberRequest'>
        /// Required. Add Incoming Phone Number Request Model
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IncomingPhoneNumber> AddIncomingNumberAsync(this ITwilioConnector operations, AddIncomingPhoneNumberRequest addIncomingPhoneNumberRequest, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ConsoleApplication.Models.IncomingPhoneNumber> result = await operations.AddIncomingNumberWithOperationResponseAsync(addIncomingPhoneNumberRequest, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns a list of local available phone numbers, each representing
        /// a phone number that is currently available for your account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='isoCountryCode'>
        /// Required. Iso country code of the Local Numbers
        /// </param>
        /// <param name='areaCode'>
        /// Optional. Area Code of the Toll Free Numbers
        /// </param>
        /// <param name='contains'>
        /// Optional. Local Numbers Contains a specific number
        /// </param>
        /// <param name='smsEnabled'>
        /// Optional. Sms Enabled on the numbers?
        /// </param>
        /// <param name='mmsEnabled'>
        /// Optional. Mms Enabled on the numbers?
        /// </param>
        /// <param name='voiceEnabled'>
        /// Optional. Voice Enabled on the numbers?
        /// </param>
        /// <param name='inPostalCode'>
        /// Optional. Postal code of the number
        /// </param>
        /// <param name='inRegion'>
        /// Optional. Number belongs to which region
        /// </param>
        public static IList<AvailablePhoneNumbers> GetAvailableLocalNumbers(this ITwilioConnector operations, string isoCountryCode, string areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, string inPostalCode = null, string inRegion = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).GetAvailableLocalNumbersAsync(isoCountryCode, areaCode, contains, smsEnabled, mmsEnabled, voiceEnabled, inPostalCode, inRegion);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a list of local available phone numbers, each representing
        /// a phone number that is currently available for your account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='isoCountryCode'>
        /// Required. Iso country code of the Local Numbers
        /// </param>
        /// <param name='areaCode'>
        /// Optional. Area Code of the Toll Free Numbers
        /// </param>
        /// <param name='contains'>
        /// Optional. Local Numbers Contains a specific number
        /// </param>
        /// <param name='smsEnabled'>
        /// Optional. Sms Enabled on the numbers?
        /// </param>
        /// <param name='mmsEnabled'>
        /// Optional. Mms Enabled on the numbers?
        /// </param>
        /// <param name='voiceEnabled'>
        /// Optional. Voice Enabled on the numbers?
        /// </param>
        /// <param name='inPostalCode'>
        /// Optional. Postal code of the number
        /// </param>
        /// <param name='inRegion'>
        /// Optional. Number belongs to which region
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<AvailablePhoneNumbers>> GetAvailableLocalNumbersAsync(this ITwilioConnector operations, string isoCountryCode, string areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, string inPostalCode = null, string inRegion = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ConsoleApplication.Models.AvailablePhoneNumbers>> result = await operations.GetAvailableLocalNumbersWithOperationResponseAsync(isoCountryCode, areaCode, contains, smsEnabled, mmsEnabled, voiceEnabled, inPostalCode, inRegion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns a list of mobile available phone numbers, each representing
        /// a phone number that is currently available for your account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='isoCountryCode'>
        /// Required. Iso country code of the Mobile Numbers
        /// </param>
        /// <param name='areaCode'>
        /// Optional. Area Code of the Toll Free Numbers
        /// </param>
        /// <param name='contains'>
        /// Optional. Mobile Numbers Contains a specific number
        /// </param>
        /// <param name='smsEnabled'>
        /// Optional. Sms Enabled on the numbers?
        /// </param>
        /// <param name='mmsEnabled'>
        /// Optional. Mms Enabled on the numbers?
        /// </param>
        /// <param name='voiceEnabled'>
        /// Optional. Voice Enabled on the numbers?
        /// </param>
        public static IList<AvailablePhoneNumbers> GetAvailableMobileNumbers(this ITwilioConnector operations, string isoCountryCode, string areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).GetAvailableMobileNumbersAsync(isoCountryCode, areaCode, contains, smsEnabled, mmsEnabled, voiceEnabled);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a list of mobile available phone numbers, each representing
        /// a phone number that is currently available for your account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='isoCountryCode'>
        /// Required. Iso country code of the Mobile Numbers
        /// </param>
        /// <param name='areaCode'>
        /// Optional. Area Code of the Toll Free Numbers
        /// </param>
        /// <param name='contains'>
        /// Optional. Mobile Numbers Contains a specific number
        /// </param>
        /// <param name='smsEnabled'>
        /// Optional. Sms Enabled on the numbers?
        /// </param>
        /// <param name='mmsEnabled'>
        /// Optional. Mms Enabled on the numbers?
        /// </param>
        /// <param name='voiceEnabled'>
        /// Optional. Voice Enabled on the numbers?
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<AvailablePhoneNumbers>> GetAvailableMobileNumbersAsync(this ITwilioConnector operations, string isoCountryCode, string areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ConsoleApplication.Models.AvailablePhoneNumbers>> result = await operations.GetAvailableMobileNumbersWithOperationResponseAsync(isoCountryCode, areaCode, contains, smsEnabled, mmsEnabled, voiceEnabled, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns a list of toll-free available phone numbers, each
        /// representing a phone number that is currently available for your
        /// account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='isoCountryCode'>
        /// Required. Iso country code of the Toll Free Numbers
        /// </param>
        /// <param name='areaCode'>
        /// Optional. Area Code of the Toll Free Numbers
        /// </param>
        /// <param name='contains'>
        /// Optional. Toll Free Numbers Contains a specific number
        /// </param>
        public static IList<AvailablePhoneNumbers> GetAvailableTollFreeNumbers(this ITwilioConnector operations, string isoCountryCode, string areaCode = null, string contains = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).GetAvailableTollFreeNumbersAsync(isoCountryCode, areaCode, contains);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a list of toll-free available phone numbers, each
        /// representing a phone number that is currently available for your
        /// account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='isoCountryCode'>
        /// Required. Iso country code of the Toll Free Numbers
        /// </param>
        /// <param name='areaCode'>
        /// Optional. Area Code of the Toll Free Numbers
        /// </param>
        /// <param name='contains'>
        /// Optional. Toll Free Numbers Contains a specific number
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<AvailablePhoneNumbers>> GetAvailableTollFreeNumbersAsync(this ITwilioConnector operations, string isoCountryCode, string areaCode = null, string contains = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ConsoleApplication.Models.AvailablePhoneNumbers>> result = await operations.GetAvailableTollFreeNumbersWithOperationResponseAsync(isoCountryCode, areaCode, contains, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Fetches the details of a phone number purchased from Twilio.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='incomingPhoneNumberSid'>
        /// Required. Incoming Phone number ID
        /// </param>
        public static IncomingPhoneNumber GetIncomingPhoneNumber(this ITwilioConnector operations, string incomingPhoneNumberSid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).GetIncomingPhoneNumberAsync(incomingPhoneNumberSid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Fetches the details of a phone number purchased from Twilio.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='incomingPhoneNumberSid'>
        /// Required. Incoming Phone number ID
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IncomingPhoneNumber> GetIncomingPhoneNumberAsync(this ITwilioConnector operations, string incomingPhoneNumberSid, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ConsoleApplication.Models.IncomingPhoneNumber> result = await operations.GetIncomingPhoneNumberWithOperationResponseAsync(incomingPhoneNumberSid, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns a single Message Specified by the provided Message ID.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='messageId'>
        /// Required. Message ID
        /// </param>
        public static MessageResponse GetMessage(this ITwilioConnector operations, string messageId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).GetMessageAsync(messageId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a single Message Specified by the provided Message ID.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='messageId'>
        /// Required. Message ID
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<MessageResponse> GetMessageAsync(this ITwilioConnector operations, string messageId, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ConsoleApplication.Models.MessageResponse> result = await operations.GetMessageWithOperationResponseAsync(messageId, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns a list of incoming phone number resources, each
        /// representing a phone number given to your account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='phoneNumber'>
        /// Optional. Specific Phone numbers to be queried
        /// </param>
        /// <param name='friendlyName'>
        /// Optional. Friendly Name
        /// </param>
        /// <param name='pageSize'>
        /// Optional. Maximum number of results
        /// </param>
        public static IList<IncomingPhoneNumber> ListIncomingPhoneNumbers(this ITwilioConnector operations, string phoneNumber = null, string friendlyName = null, int? pageSize = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).ListIncomingPhoneNumbersAsync(phoneNumber, friendlyName, pageSize);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a list of incoming phone number resources, each
        /// representing a phone number given to your account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='phoneNumber'>
        /// Optional. Specific Phone numbers to be queried
        /// </param>
        /// <param name='friendlyName'>
        /// Optional. Friendly Name
        /// </param>
        /// <param name='pageSize'>
        /// Optional. Maximum number of results
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<IncomingPhoneNumber>> ListIncomingPhoneNumbersAsync(this ITwilioConnector operations, string phoneNumber = null, string friendlyName = null, int? pageSize = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ConsoleApplication.Models.IncomingPhoneNumber>> result = await operations.ListIncomingPhoneNumbersWithOperationResponseAsync(phoneNumber, friendlyName, pageSize, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns a list of messages associated with your account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='to'>
        /// Optional. Phone Number the message was sent To
        /// </param>
        /// <param name='fromParameter'>
        /// Optional. Phone Number the message was sent From
        /// </param>
        /// <param name='dateSent'>
        /// Optional. Date the message was sent
        /// </param>
        /// <param name='pageSize'>
        /// Optional. Maximum number of results
        /// </param>
        public static IList<MessageResponse> ListMessages(this ITwilioConnector operations, string to = null, string fromParameter = null, DateTimeOffset? dateSent = null, int? pageSize = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).ListMessagesAsync(to, fromParameter, dateSent, pageSize);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a list of messages associated with your account
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='to'>
        /// Optional. Phone Number the message was sent To
        /// </param>
        /// <param name='fromParameter'>
        /// Optional. Phone Number the message was sent From
        /// </param>
        /// <param name='dateSent'>
        /// Optional. Date the message was sent
        /// </param>
        /// <param name='pageSize'>
        /// Optional. Maximum number of results
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<MessageResponse>> ListMessagesAsync(this ITwilioConnector operations, string to = null, string fromParameter = null, DateTimeOffset? dateSent = null, int? pageSize = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ConsoleApplication.Models.MessageResponse>> result = await operations.ListMessagesWithOperationResponseAsync(to, fromParameter, dateSent, pageSize, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Returns Usage records for usage categories
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='category'>
        /// Optional. Category of usage
        /// </param>
        /// <param name='subResource'>
        /// Optional. Sub Resource
        /// </param>
        /// <param name='endDate'>
        /// Optional. List usage upto a given date
        /// </param>
        /// <param name='startDate'>
        /// Optional. List usage from a given date
        /// </param>
        /// <param name='pageSize'>
        /// Optional. Maximum number of results
        /// </param>
        public static IList<UsageRecords> ListUsage(this ITwilioConnector operations, string category = null, string subResource = null, string endDate = null, string startDate = null, int? pageSize = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).ListUsageAsync(category, subResource, endDate, startDate, pageSize);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns Usage records for usage categories
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='category'>
        /// Optional. Category of usage
        /// </param>
        /// <param name='subResource'>
        /// Optional. Sub Resource
        /// </param>
        /// <param name='endDate'>
        /// Optional. List usage upto a given date
        /// </param>
        /// <param name='startDate'>
        /// Optional. List usage from a given date
        /// </param>
        /// <param name='pageSize'>
        /// Optional. Maximum number of results
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<UsageRecords>> ListUsageAsync(this ITwilioConnector operations, string category = null, string subResource = null, string endDate = null, string startDate = null, int? pageSize = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ConsoleApplication.Models.UsageRecords>> result = await operations.ListUsageWithOperationResponseAsync(category, subResource, endDate, startDate, pageSize, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <summary>
        /// Send a new outgoing message to a mobile number.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='sendMessageRequest'>
        /// Required. Send Message Request Model
        /// </param>
        public static SendMessageResponse SendMessage(this ITwilioConnector operations, SendMessageRequest sendMessageRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITwilioConnector)s).SendMessageAsync(sendMessageRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Send a new outgoing message to a mobile number.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the ConsoleApplication.ITwilioConnector.
        /// </param>
        /// <param name='sendMessageRequest'>
        /// Required. Send Message Request Model
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<SendMessageResponse> SendMessageAsync(this ITwilioConnector operations, SendMessageRequest sendMessageRequest, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ConsoleApplication.Models.SendMessageResponse> result = await operations.SendMessageWithOperationResponseAsync(sendMessageRequest, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
