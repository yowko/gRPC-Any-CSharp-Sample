using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace gRPC.Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = "127.0.0.1";
            var port = 8888;

            var serverInstance = new Grpc.Core.Server
            {
                Ports =
                {
                    new ServerPort(host, port, ServerCredentials.Insecure)
                }
            };

            Console.WriteLine($"Demo server listening on host:{host} and port:{port}");

            serverInstance.Services.Add(
                Message.gRPCService.BindService(
                    new gRPCServiceImpl()));

            serverInstance.Start();

            Console.ReadKey();

            await serverInstance.ShutdownAsync();
        }
    }
}