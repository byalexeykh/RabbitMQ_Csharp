using System;

namespace RMQChatLib
{
    // Struct to store info about user
    public struct UserClientInfo
    {
        readonly Guid UserRoutingKey;
        readonly string Nickname;

        public UserClientInfo(Guid UserRoutingKey, string Nickname)
        {
            this.UserRoutingKey = UserRoutingKey;
            this.Nickname = Nickname;
        }
    }
}
