// See https://aka.ms/new-console-template for more information

using GrpcServiceTest;

var channel = Grpc.Net.Client.GrpcChannel.ForAddress("http://localhost:5237");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
    new HelloRequest() { Name = "Greeter Client Jr" });
Console.WriteLine($"Reply: {reply.Message}");
Console.ReadLine();