using System;

namespace gRPC.Message
{
    [Serializable]
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}