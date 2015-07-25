using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Azure.AppService.ApiApps.Service;
using System.Dynamic;

namespace DeviceConnectorSample.Controllers
{
    public class DeviceController : ApiController
    {
        [HttpGet]
        [Route("api/device/telemetry")]
        public HttpResponseMessage TelemetryDataPollTrigger(
            string triggerState = null,
            string rootNamespace = null)
        {

            IDataChannel chn;

            if (triggerState != null && triggerState.ToLower() == "mock")
                chn = new MockChannel();
            else
                chn = new SbChannel();

            var telemetryData = chn.GetTelemetryData();

            if (telemetryData.Count > 0)
            {
                // Extension method provided by the AppService service SDK.
                return this.Request.EventTriggered(new { Data = telemetryData });
            }
            // If there are no files touched after the timestamp, tell the caller to poll again after 1 mintue.
            else
            {
                // Extension method provided by the AppService service SDK.
                return this.Request.EventWaitPoll(new TimeSpan(0, 1, 0));
            }
        }


        public List<string> Get()
        {
            return new string[] {"aaa"}.ToList();
        }
    }
}
