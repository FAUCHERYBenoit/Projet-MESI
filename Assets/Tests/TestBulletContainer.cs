using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using messages;
using UI;
using System.Linq;

namespace test
{
    public class TestBulletContainer
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }

        [UnityTest]
        public IEnumerator TestAddBullets()
        {
            for (int i = 0; i < 50; i++)
            {
                BulletContainerMessage bulletContainerMessage = new BulletContainerMessage(1, BulletTypes.normal);
                BulletContainer bulletContainer = GameManager.Instance.GetUIManager.bulletContainer;
                GameManager.Instance.SendAMessage(bulletContainerMessage);

                //Assert.IsTrue(bulletContainer.Children().Count() == 50);

                yield return new WaitForSeconds(0.1f);
            } 
        }

        [UnityTest]
        public IEnumerator TestRemoveBullets()
        {
            BulletContainerMessage bulletContainerMessage = new BulletContainerMessage(300, BulletTypes.normal);
            BulletContainer bulletContainer = GameManager.Instance.GetUIManager.bulletContainer;
            GameManager.Instance.SendAMessage(bulletContainerMessage);

            yield return new WaitForSeconds(0.1f);


            for (int i = 0; i < 25; i++)
            {
                bulletContainerMessage = new BulletContainerMessage(-1, BulletTypes.normal);
                GameManager.Instance.SendAMessage(bulletContainerMessage);

                //Assert.IsTrue(bulletContainer.Children().Count() == 24);

                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}

