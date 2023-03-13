using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UI;
using UnityEngine;
using UnityEngine.TestTools;
using messages;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace test
{
    public class TestUIManager
    {
        UIManager uIManager;
        [UnitySetUp]
        public void SetUp()
        {

        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }

        [UnityTest]
        public IEnumerator TestAddLife()
        {
            bool isTrue = false;

            for (int i = 0; i < 11; i++)
            {
                ProgressBarMessage progressBarMessage = new ProgressBarMessage(i, 100, BarType.Life);
                ProgressBar progressBar = GameManager.Instance.GetUIManager.healthBar;
                progressBar.value = 90;
                float oldValue = progressBar.value;
                GameManager.Instance.SendAMessage(progressBarMessage);

                isTrue = progressBar.value == i;

                yield return new WaitForFixedUpdate();
            }

            Assert.IsTrue(isTrue);
        }

        [UnityTest]
        public IEnumerator TestAddArmor()
        {
            bool isTrue = false;

            for (int i = 0; i < 11; i++)
            {
                ProgressBarMessage progressBarMessage = new ProgressBarMessage(i, 100, BarType.Armor);
                ProgressBar progressBar = GameManager.Instance.GetUIManager.armorBar;
                progressBar.value = 90;
                float oldValue = progressBar.value;
                GameManager.Instance.SendAMessage(progressBarMessage);

                isTrue = progressBar.value == i;

                yield return new WaitForFixedUpdate();
            }

            Assert.IsTrue(isTrue);
        }

        [UnityTest]
        public IEnumerator TestAddMoney()
        {
            Label label = GameManager.Instance.GetUIManager.moneyAmount;
            MoneyAmountMessage moneyAmountMessage = new MoneyAmountMessage(1500);
            GameManager.Instance.SendAMessage(moneyAmountMessage);

            Assert.IsTrue(label.text == 1500.ToString());

            yield return null;
        }
    }
}

