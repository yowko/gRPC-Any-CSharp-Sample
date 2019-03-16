using System;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using gRPC.Message;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace gRPC.Server
{

    public class gRPCServiceImplforAny : gRPCService.gRPCServiceBase
    {
        public override Task<Response> AddUser(AddUserRequest request, ServerCallContext context)
        {
            return base.AddUser(request, context);
        }

        public override Task<Response> GetUsers(GetUsersRequest request, ServerCallContext context)
        {
            return base.GetUsers(request, context);
        }

        public override Task<Response> DeleteUser(DeleteUserRequest request, ServerCallContext context)
        {
            return base.DeleteUser(request, context);
        }
    }

    public class gRPCServiceImpl : gRPCService.gRPCServiceBase
    {
        public override Task<Response> AddUser(AddUserRequest request, ServerCallContext context)
        {
            var user = FakeUserRule().Generate();

            user.Age = request.Age;
            user.Name = request.Name;
            var response = new Response
            {
                IsSuccess = true,
                ResultMsg = new Any
                {
                    Value = Google.Protobuf.ByteString.CopyFrom(ByteStringUtility.ToByteArray(user))
                }
            };
            
            return Task.FromResult(response);
        }

        public override Task<Response> DeleteUser(DeleteUserRequest request, ServerCallContext context)
        {
            var response = new Response
            {
                IsSuccess = true,
                ResultMsg = new Any
                {
                    Value = Google.Protobuf.ByteString.CopyFrom(ByteStringUtility.ToByteArray("User has deleted !!"))
                }
            };

            return Task.FromResult(response);
        }

        public override Task<Response> GetUsers(GetUsersRequest request, ServerCallContext context)
        {
            var response = new Response
            {
                IsSuccess = true
            };
            var users = FakeUserRule().Generate(3);
            response.ResultMsgs.AddRange(users.Select(a => new Any()
            {
                Value = Google.Protobuf.ByteString.CopyFrom(ByteStringUtility.ToByteArray(a))
            }));

            return Task.FromResult(response);
        }

        private static Faker<UserModel> FakeUserRule()
        {
            return new Faker<UserModel>()
                .RuleFor(a => a.Id, b => Guid.NewGuid())
                .RuleFor(a => a.Name, (f, u) => f.Name.FirstName())
                .RuleFor(a => a.Age, f => f.Random.Number(1, 10));
        }
    }
}