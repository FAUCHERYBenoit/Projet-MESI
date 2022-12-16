using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractManager : MonoBehaviour
{
    public abstract void SendAMessage(Message message);
}

#region messages
public class Message { }

public class GameToUIMessage : Message { }

public class UIToGameMessage : Message { }

public class AudioMessage : Message { }

#endregion