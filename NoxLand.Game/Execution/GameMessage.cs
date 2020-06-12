using System;
using System.Collections.Generic;

namespace NoxLand.Game.Execution
{
    public enum MessageVerb
    {
        CreateRoom,
        RoomCreated,
        RatCreated
    }

    public class GameMessage
    {
        public Guid CorrelationId
        {
            get; private set;
        }

        public MessageVerb Verb
        {
            get; private set;
        }

        public Dictionary<string, string> Data
        {
            get; private set;

        }


        public GameMessage(Guid correlationId, MessageVerb verb, Dictionary<string, string> data)
        {
            CorrelationId = correlationId;
            Verb = verb;
            Data = data;
        }
    }
}
