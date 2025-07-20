using System;
using System.Threading.Tasks;
using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        Console.WriteLine("Kafka Chat Producer Started");
        Console.WriteLine("Type a message and press Enter to send it (type 'exit' to quit)");

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        while (true)
        {
            Console.Write("You: ");
            var message = Console.ReadLine();

            if (message?.ToLower() == "exit")
                break;

            var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
            Console.WriteLine($"[Sent] Offset: {result.Offset}, Partition: {result.Partition}");
        }
    }
}

