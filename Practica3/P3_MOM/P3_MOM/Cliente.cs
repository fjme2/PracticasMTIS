using System;
using Apache.NMS;


namespace P3_MOM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente activado.");

            String user = env("ACTIVEMQ_USER", "admin");
            String password = env("ACTIVEMQ_PASSWORD", "password");
            String host = env("ACTIVEMQ_HOST", "localhost");
            int port = Int32.Parse(env("ACTIVEMQ_PORT", "61616"));
            String destination = arg(args, 0, "event");

            String brokerUri = "activemq:tcp://" + host + ":" + port + "?transport.useLogging=true";
            NMSConnectionFactory factory = new NMSConnectionFactory(brokerUri);

            IConnection connection = factory.CreateConnection(user, password);
            connection.Start();
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);

            //Topics 
            //IDestination dest = session.GetTopic(destination);
            IDestination humInv1 = session.GetTopic("hInv1");
            IDestination humInv2 = session.GetTopic("hInv2");
            IDestination humi1 = session.GetTopic("humi1");
            IDestination humi2 = session.GetTopic("humi2");
            IDestination tempInv1 = session.GetTopic("tInv1");
            IDestination tempInv2 = session.GetTopic("tInv2");
            IDestination vent1 = session.GetTopic("vent1");
            IDestination vent2 = session.GetTopic("vent2");
            IDestination tempmaxima1 = session.GetTopic("tmax1");
            IDestination hummaxima1 = session.GetTopic("hmax1");
            IDestination tempmaxima2 = session.GetTopic("tmax2");
            IDestination hummaxima2 = session.GetTopic("hmax2");


            //consumers y producers
            IMessageConsumer hume1 = session.CreateConsumer(humInv1);
            IMessageConsumer hume2 = session.CreateConsumer(humInv2);
            IMessageProducer humidificador1 = session.CreateProducer(humi1);
            IMessageProducer humidificador2 = session.CreateProducer(humi2);
            IMessageConsumer temp1 = session.CreateConsumer(tempInv1);
            IMessageConsumer temp2 = session.CreateConsumer(tempInv2);
            IMessageProducer ventilador1 = session.CreateProducer(vent1);
            IMessageProducer ventilador2 = session.CreateProducer(vent2);
            IMessageProducer tmax1 = session.CreateProducer(tempmaxima1);
            IMessageProducer hmax1 = session.CreateProducer(hummaxima1);
            IMessageProducer tmax2 = session.CreateProducer(tempmaxima2);
            IMessageProducer hmax2 = session.CreateProducer(hummaxima2);


            Console.WriteLine("Inserta la temperatura máxima del invernadero 1");
            String tempmax1 = Console.ReadLine();
            Console.WriteLine("Inserta la humedad máxima del invernadero 1");
            String hummax1 = Console.ReadLine();
            Console.WriteLine("Inserta la temperatura máxima del invernadero 2");
            String tempmax2 = Console.ReadLine();
            Console.WriteLine("Inserta la humedad máxima del invernadero 2");
            String hummax2 = Console.ReadLine();

            //IMessageConsumer consumer = session.CreateConsumer(dest);
            //DateTime start = DateTime.Now;
            Console.WriteLine("Esperando a los invernaderos...");
            while (true)
            {
                tmax1.Send(session.CreateTextMessage(tempmax1));
                tmax2.Send(session.CreateTextMessage(tempmax2));
                hmax1.Send(session.CreateTextMessage(hummax1));
                hmax2.Send(session.CreateTextMessage(hummax2));
                IMessage msghume1 = hume1.ReceiveNoWait();
                IMessage msghume2 = hume2.ReceiveNoWait();
                IMessage msgtemp1 = temp1.ReceiveNoWait();
                IMessage msgtemp2 = temp2.ReceiveNoWait();

                if (msghume1 is ITextMessage)
                {
                    Console.WriteLine("__________________________________________");
                    ITextMessage txthume1 = msghume1 as ITextMessage;
                    String body = txthume1.Text;
                    Console.WriteLine("Invernadero 1:");
                    Console.WriteLine("Humedad -> " + body);
                    if (Int32.Parse(body) > Int32.Parse(hummax1))
                    {
                        humidificador1.Send(session.CreateTextMessage("Activado"));
                    }
                }
                if (msgtemp1 is ITextMessage)
                {
                    ITextMessage txttemp1 = msgtemp1 as ITextMessage;
                    String body = txttemp1.Text;
                    Console.WriteLine("Temperatura -> " + body);
                    if (Int32.Parse(body) > Int32.Parse(tempmax1))
                    {
                        ventilador1.Send(session.CreateTextMessage("Activado"));
                    }
                }
                if (msghume2 is ITextMessage)
                {
                    Console.WriteLine("__________________________________________");
                    ITextMessage txthume2 = msghume2 as ITextMessage;
                    String body = txthume2.Text;
                    Console.WriteLine("Invernadero 2:");
                    Console.WriteLine("Humedad -> " + body);
                    if (Int32.Parse(body) > Int32.Parse(hummax2))
                    {
                        humidificador2.Send(session.CreateTextMessage("Activado"));
                    }
                }
                if (msgtemp2 is ITextMessage)
                {
                    ITextMessage txttemp2 = msgtemp2 as ITextMessage;
                    String body = txttemp2.Text;
                    Console.WriteLine("Temperatura -> " + body);
                    if (Int32.Parse(body) > Int32.Parse(tempmax2))
                    {
                        ventilador2.Send(session.CreateTextMessage("Activado"));
                    }
                }
            }
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
