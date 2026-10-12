using MQTTnet;
using MQTTnet.Client;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace IndustrialDataLogger
{
    public class MqttHelper
    {
        private IMqttClient mqttClient;
        private string mqttIP;
        private int mqttPort;
        public MqttHelper()
        {
            mqttIP = ConfigurationManager.AppSettings["MqttIP"];

            mqttPort = int.Parse(
                ConfigurationManager.AppSettings["MqttPort"]
            );
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                var factory = new MqttFactory();

                mqttClient = factory.CreateMqttClient();

                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer(mqttIP, mqttPort)
                    .WithClientId("IndustrialDataLogger")
                    .Build();

                await mqttClient.ConnectAsync(options);

                return mqttClient.IsConnected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("MQTT Connection Error: " + ex.Message);
                return false;
            }
        }

        public async Task PublishAsync(string topic, string message)
        {
            try
            {
                if (mqttClient == null || !mqttClient.IsConnected)
                {
                    return;
                }

                var mqttMessage = new MqttApplicationMessageBuilder()
                    .WithTopic(topic)
                    .WithPayload(Encoding.UTF8.GetBytes(message))
                    .Build();

                await mqttClient.PublishAsync(mqttMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MQTT Publish Error: " + ex.Message);
            }
        }
    }
}