using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class UIManager : AbstractManager
    {
        BulletContainer bulletContainer;

        public void Init()
        {
            ///
        }

        public void HandleMessage(GameToUIMessage gameToUIMessage)
        {
            switch (gameToUIMessage)
            {
                case BulletContainerMessage bulletContainerMessage:
                    bulletContainer.ReceiveMessage(bulletContainerMessage);
                    break;
            }
        }

        public override void SendAMessage(Message message)
        {
            GameManager.Instance.SendAMessage(message);
        }
    }
}

