using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int playerMoney;
    public TextMeshProUGUI playerMoneyUi;
    public IntEventChannel ChangePlayerMoneyChannel;

    private void OnEnable()
    {
        playerMoneyUi.text = playerMoney.ToString();
        ChangePlayerMoneyChannel.OnEventRaised += ChangePlayerMoney;
    }

    private void OnDisable()
    {
        ChangePlayerMoneyChannel.OnEventRaised -= ChangePlayerMoney;
    }

    public void ChangePlayerMoney(int amount)
    {
        if (amount < 0)
        {
            int money = playerMoney;
            if (money + amount < 0)
            {
                Debug.Log("Not enough gold");
            }
            else
            {
                playerMoney += amount;
            }
        }
        else
        {
            playerMoney += amount;
        }
        playerMoneyUi.text = playerMoney.ToString();
    }
}
