using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using messages;

namespace audio
{
    public class AudioManager : AbstractManager
    {
        /// <summary>
        /// Handle an audio message and dispatch it to the right place 
        /// </summary>
        /// <param name="audioMessage"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void HandleAudioMessage(AudioMessage audioMessage)
        {
            throw new NotImplementedException();
        }

        public override void SendAMessage(Message message)
        {
            GameManager.Instance.SendAMessage(message);
        }
    }
}
