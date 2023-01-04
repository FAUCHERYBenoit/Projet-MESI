using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character
{
    public abstract class AbstractCharacterManager : AbstractManager
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public override void SendAMessage(Message message)
        {
            GameManager.Instance.SendAMessage(message);
        }
    }
}

