using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;

namespace DeviceConnectorSample
{
    public class SbChannel : IDataChannel
    {
        private string m_SbConnStr = "PUT YOUR SERVICE BUS CONNECTION STRING HERE";

        public List<Command> GetTelemetryData()
        {
            DateTime startTime = DateTime.Now;

            List<Command> commands = new List<Command>();

            var queueClient = QueueClient.CreateFromConnectionString(m_SbConnStr, "ingress", ReceiveMode.ReceiveAndDelete);

            while (DateTime.Now - startTime < TimeSpan.FromSeconds(30))
            {
                var msgs = queueClient.ReceiveBatch(100, TimeSpan.FromSeconds(15));
                if (msgs != null)
                {
                    foreach (var msg in msgs)
                    {
                        try
                        {
                            Command cmd = msg.GetBody<Command>(new DataContractJsonSerializer(typeof(Command)));
                            commands.Add(cmd);
                        }
                        catch (Exception) { };
                    }                  
                }              
            }

            return commands;
        }
    }
}