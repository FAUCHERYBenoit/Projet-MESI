using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager uIManager;
    public UIManager GetUIManager { get; private set; }

    [SerializeField] private AudioManager audioManager;
    public AudioManager GetAudioManager { get; private set; }

    public void SendAMessage(Message message)
    {
        switch (message)
        {
            case GameToUIMessage gtum:
                SendMessageToUI(gtum);
                break;
            case UIToGameMessage utgm:
                SendMessageToGame(utgm);
                break;
            case AudioMessage am:
                SendMessageToAudio(am);
                break;
        }
    }

    private void SendMessageToAudio(AudioMessage am)
    {
        throw new NotImplementedException();
    }

    private void SendMessageToGame(UIToGameMessage utgm)
    {
        throw new NotImplementedException();
    }

    private void SendMessageToUI(GameToUIMessage gtum)
    {
        throw new NotImplementedException();
    } 
}

#region messages
public class Message { }

public class GameToUIMessage : Message { }

public class UIToGameMessage : Message { }

public class AudioMessage : Message { }

#endregion
