using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVisuals : MonoBehaviour
{

    public ItemEventChannel purchasedItem;

    public GameObject playerHood;
    public GameObject playerTorso;
    public GameObject playerPants;

    private Item itemToChange;
    public void OnEnable()
    {
        purchasedItem.OnEventRaised += ItemPurchased;
    }

    private void OnDisable()
    {
        purchasedItem.OnEventRaised -= ItemPurchased;
    }

    public void ItemPurchased(Item item)
    {
        itemToChange = item;
    }

    public void ChangePlayerVisuals()
    {
        switch (itemToChange.type)
        {
            case Item.ItemType.Hood:
                playerHood.GetComponent<SpriteRenderer>().sprite = itemToChange.icon;
                break;
            case Item.ItemType.Chest:
                playerTorso.GetComponent<SpriteRenderer>().sprite = itemToChange.icon;
                break;
            case Item.ItemType.Pants:
                playerPants.GetComponent<SpriteRenderer>().sprite = itemToChange.icon;
                break;
        }
    }

}
