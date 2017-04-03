using System;
using System.Threading;
using Apache.NMS;

namespace Invernadero2
{
    class Invernadero2
    {
        static void Main(string[] args)
        {
            String user = env("ACTIVEMQ_USER", "admin");
            String password = env("ACTIVEMQ_PASSWORD", "password");
            String host = env("ACTIVEMQ_HOST", "localhost");
            int port = Int32.Parse(env("ACTIVEMQ_PORT", "61616"));
            String destination = arg(args, 0, "event");


            String brokerUri = "activemq:tcp://" + host + ":" + port;
            NMSConnectionFactory factory = new NMSConnectionFactory(brokerUri);

            IConnection connection = factory.CreateConnection(user, password);
            connection.Start();
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);

            //topics 
            //IDestination dest = session.GetTopic(destination);
            IDestination humInv2 = session.GetTopic("hInv2");
            IDestination tempInv2 = session.GetTopic("tInv2");
            IDestination humi2 = session.GetTopic("humi2");
            IDestination vent2 = session.GetTopic("vent2");
            IDestination tempmaxima2 = session.GetTopic("tmax2");
            IDestination hummaxima2 = session.GetTopic("hmax2");


            //consumers y producers
            IMessageProducer hume2 = session.CreateProducer(humInv2);
            IMessageProducer temp2 = session.CreateProducer(tempInv2);
            IMessageConsumer tmax = session.CreateConsumer(tempmaxima2);
            IMessageConsumer hmax = session.CreateConsumer(hummaxima2);
            IMessageConsumer ventilador2 = session.CreateConsumer(vent2);
            IMessageConsumer humidificador2 = session.CreateConsumer(humi2);

            //IMessageProducer producer = session.CreateProducer(dest);
            //hume1.DeliveryMode = MsgDeliveryMode.NonPersistent;

            while (true)
            {
                IMessage msghumemax = hmax.ReceiveNoWait();
                IMessage msgtempmax = tmax.ReceiveNoWait();
                IMessage msghumi = humidificador2.ReceiveNoWait();
                IMessage msgvent = ventilador2.ReceiveNoWait();
                if (msghumemax is ITextMessage)
                {
                    Console.WriteLine("__________________________________________");
                    ITextMessage txthumemax = msghumemax as ITextMessage;
                    String body = txthumemax.Text;
                    if (msghumi is ITextMessage)
                    {
                        ITextMessage txthumi = msghumi as ITextMessage;
                        String humi = txthumi.Text;
                        if ("Activado".Equals(humi))
                        {
                            int rand = crearRandom(Int32.Parse(body) - 1);
                            hume2.Send(session.CreateTextMessage(rand.ToString()));
                            Console.WriteLine("Humedad -> " + rand.ToString());
                            Console.WriteLine("Humidificador Activado!");
                        }
                    }
                    else
                    {
                        int rand = crearRandom(Int32.Parse(body) + 50);
                        hume2.Send(session.CreateTextMessage(rand.ToString()));
                        Console.WriteLine("Humedad -> " + rand.ToString());
                    }
                }
                if (msgtempmax is ITextMessage)
                {
                    ITextMessage txttempmax = msgtempmax as ITextMessage;
                    String body = txttempmax.Text;
                    if (msgvent is ITextMessage)
                    {
                        ITextMessage txtvent = msgvent as ITextMessage;
                        String vent = txtvent.Text;
                        if ("Activado".Equals(vent))
                        {
                            int rand = crearRandom(Int32.Parse(body) - 1);
                            temp2.Send(session.CreateTextMessage(rand.ToString()));
                            Console.WriteLine("Temperatura -> " + rand.ToString());
                            Console.WriteLine("Ventilador Activado!");
                        }
                    }
                    else
                    {
                        int rand = crearRandom(Int32.Parse(body) + 50);
                        temp2.Send(session.CreateTextMessage(rand.ToString()));
                        Console.WriteLine("Temperatura -> " + rand.ToString());
                    }
                }
                Thread.Sleep(5000);
            }
        }


        private static int crearRandom(int cant)
        {
            Random random = new Random();
            int num = random.Next(0, cant);
            return num;

        }

        private static String env(String key, String defaultValue)
        {
            String rc = System.Environment.GetEnvironmentVariable(key);
            if (rc == null)
            {
                return defaultValue;
            }
            return rc;
        }

        private static String arg(String[] args, int index, String defaultValue)
        {
            if (index < args.Length)
            {

                return args[index];
            }
            return defaultValue;
        }
    }
}
