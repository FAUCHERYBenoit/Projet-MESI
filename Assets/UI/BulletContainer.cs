using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class BulletContainer : VisualElement
    {
        public new class UxmlFactory : UxmlFactory<BulletContainer, GraphView.UxmlTraits>
        {

        }

        public BulletContainer()
        {

        }

        List<VisualElement> bulletsLeft = new List<VisualElement>();
        BulletTypes currentBulletType = BulletTypes.normal;
        StyleBackground currentSprite;

        public void ReceiveMessage(BulletContainerMessage bulletContainerMessage)
        {
            if(bulletContainerMessage.bulletTypes != currentBulletType)
            {
                int bulletDelta = bulletsLeft.Count - bulletContainerMessage.amount;
                ChangeBulletType(bulletContainerMessage);
                AddBullets(bulletDelta);
            }
            else
            {
                AddBullets(bulletContainerMessage.amount);
            }
        }

        private void ChangeBulletType(BulletContainerMessage bulletContainerMessage)
        {
            currentBulletType = bulletContainerMessage.bulletTypes;
            bulletsLeft.ForEach(b =>
            {
                Background back = new Background();
                back.sprite = bulletContainerMessage.bulletSprite;
                currentSprite = new StyleBackground { value = back };
                b.style.backgroundImage = currentSprite;
            });
        }

        private void AddBullets(int amount)
        {
            if (amount < 0)
            {
                int startPos = (bulletsLeft.Count - 1) - amount;
                bulletsLeft.RemoveRange(startPos, amount);
            }
            else if (amount > 0)
            {
                for(int i = 0; i < amount; i++)
                {
                    VisualElement VE = new VisualElement();
                    VE.style.backgroundImage = currentSprite;
                    bulletsLeft.Add(VE);
                }
            }
        }
    }
}

public class BulletContainerMessage : GameToUIMessage
{
    public BulletContainerMessage(int amount, BulletTypes bulletTypes)
    {
        this.amount = amount;
        this.bulletTypes = bulletTypes;
    }

    public int amount { get; private set; }
    public BulletTypes bulletTypes { get; private set; }
    public Sprite bulletSprite { get; private set; }

    public void AddBulletImage(Sprite bulletSprite)
    {
        this.bulletSprite = bulletSprite;
    }
}

public enum BulletTypes
{
    normal, special
}

