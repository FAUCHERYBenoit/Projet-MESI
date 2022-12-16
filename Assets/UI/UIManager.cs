using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class UIManager : AbstractManager
    {
        public void HandleMessage(GameToUIMessage gameToUIMessage)
        {
            throw new NotImplementedException();
        }

        public override void SendAMessage(Message message)
        {
            GameManager.Instance.SendAMessage(message);
        }
    }
}

