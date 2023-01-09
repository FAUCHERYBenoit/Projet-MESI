using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using messages;

public abstract class AbstractManager : MonoBehaviour
{
    /// <summary>
    /// A method to send a message to a service 
    /// </summary>
    /// <param name="message"></param>
    public abstract void SendAMessage(Message message);
}

namespace messages
{
    public class Message { }

    public class GameToUIMessage : Message
    {
        public StyleSheet styleSheet { get; private set; }
        public void SetStyle(StyleSheet styleSheet)
        {
            this.styleSheet = styleSheet;
        }
    }

    public class UIToGameMessage : Message { }

    public class AudioMessage : Message { }
}