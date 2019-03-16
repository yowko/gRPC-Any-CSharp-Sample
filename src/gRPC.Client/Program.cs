using System;
using System.Linq;
using gRPC.Message;
using Grpc.Core;

namespace gRPC.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "127.0.0.1";
            var port = "8888";


            var channel = new Channel($"{host}:{port}", ChannelCredentials.Insecure);

            var serviceClient = new gRPCService.gRPCServiceClient(channel);

            var result = serviceClient.AddUser(new AddUserRequest
            {
                Name = "Yowko",
                Age = 35
            });

            var addResult =
                ByteStringUtility.FromByteArray<UserModel>(result.ResultMsg.Value
                    .ToByteArray());
            Console.WriteLine($"Id:{addResult.Id};Name:{addResult.Name};Age:{addResult.Age}");

            var usersResult = serviceClient.GetUsers(new GetUsersRequest());

            var users = usersResult.ResultMsgs.Select(a =>
                ByteStringUtility.FromByteArray<UserModel>(a.Value.ToByteArray()));


            foreach (var user in users)
            {
                Console.WriteLine($"Id:{user.Id};Name:{user.Name};Age:{user.Age}");
            }
            

            var deleteResult = serviceClient.DeleteUser(new DeleteUserRequest()
            {
                Name = "Yowko"
            });

            var delResult = ByteStringUtility.FromByteArray<string>(deleteResult.ResultMsg.Value
                .ToByteArray());
            Console.WriteLine($"Msg:{delResult}");
        }
    }
}