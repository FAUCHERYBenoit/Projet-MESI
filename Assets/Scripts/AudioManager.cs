using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace audio
{
    public class AudioManager : MonoBehaviour
    {
        public void HandleAudioMessage(AudioMessage audioMessage)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Message message)
        {
            GameManager.Instance.SendAMessage(message);
        }
    }
}
