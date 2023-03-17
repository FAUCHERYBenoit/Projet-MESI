using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using audio;
using messages;
using System.Threading.Tasks;

public class GameManager : AbstractManager
{
    #region Singleton
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    [SerializeField] private UIManager uIManager;
    public UIManager GetUIManager { get { return uIManager; }}

    [SerializeField] private AudioManager audioManager;
    public AudioManager GetAudioManager { get { return audioManager; } }

    [SerializeField] private float tick = 0.5f;
    public float Tick { get => tick; }

    [SerializeField] private Transform playerTransform;
    public Transform PlayerTransform { get { return playerTransform; }}

    /// <summary>
    /// Use this methods to handle any messages 
    /// </summary>
    /// <param name="message"></param>
    public override void SendAMessage(Message message)
    {
        UnityMainThreadDispatcher.Instance().Enqueue(() =>
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
        });
    }

    private void SendMessageToAudio(AudioMessage am)
    {
        audioManager.HandleAudioMessage(am);
    }

    private void SendMessageToUI(GameToUIMessage gtum)
    {
        uIManager.HandleMessage(gtum);
    }

    private void SendMessageToGame(UIToGameMessage utgm)
    {
        throw new NotImplementedException();
    }
}
