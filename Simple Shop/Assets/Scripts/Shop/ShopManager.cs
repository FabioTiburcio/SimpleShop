using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public PlayerMoney playerMoney;

    public GameObject shopPanel;
    public GameObject changeClothPopup;

    public ItemEventChannel TryPurchasedItem;

    public ItemEventChannel ItemPurchased;

    public ItemEventChannel TrySellingItem;

    public IntEventChannel playerMoneyChangeChannel;

    private void OnEnable()
    {
        TryPurchasedItem.OnEventRaised += TryPuchase;
        TrySellingItem.OnEventRaised += TryToSell;
    }
    private void OnDisable()
    {
        TryPurchasedItem.OnEventRaised -= TryPuchase;
        TrySellingItem.OnEventRaised -= TryToSell;
    }
    public void TryPuchase(Item item)
    {
        if (item.buyValue > playerMoney.playerMoney)
        {
            Debug.Log("Not enough money");
        }
        else
        {
            playerMoneyChangeChannel.RaiseEvent(-item.buyValue);
            changeClothPopup.SetActive(true);
            ItemPurchased.RaiseEvent(item);
        }
    }

    public void TryToSell(Item item)
    {
        if (shopPanel.activeSelf)
        {
            
        }
        playerMoney.ChangePlayerMoney(item.sellValue);
    }


}
