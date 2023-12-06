using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Inventory inventory;

    public GameObject inventoryUi;

    public Transform inventoryContentFather;

    public GameObject inventoryItemPrefab;

    public ItemEventChannel PurchasedItem;

    public ItemEventChannel SoldItem;

    public GameObject shopPanel;

   // private List<GameObject> listOfInventoryItems = new List<GameObject>();

    public void Awake()
    {
        for (int i = 0; i < inventory.itemsInInventory.Count; i++)
        {
            GameObject instantiadedInventoryItem = Instantiate(inventoryItemPrefab, inventoryContentFather);
            instantiadedInventoryItem.GetComponent<SetItemInfo>().itemInfo = inventory.itemsInInventory[i];
            instantiadedInventoryItem.GetComponent<SetItemInfo>().AttitemInfo();
            //listOfInventoryItems[i] = instantiadedInventoryItem;
        }
    }
    private void OnEnable()
    {
        PurchasedItem.OnEventRaised += AddItem;
        SoldItem.OnEventRaised += RemoveItem;
    }
    private void OnDisable()
    {
        PurchasedItem.OnEventRaised -= AddItem;
        SoldItem.OnEventRaised -= RemoveItem;
    }
    public void OpenInventory()
    {
        inventoryUi.SetActive(!inventoryUi.activeInHierarchy);
    }
    public void AddItem(Item item)
    {
        inventory.itemsInInventory.Add(item);
        GameObject instantiadedInventoryItem = Instantiate(inventoryItemPrefab, inventoryContentFather);
        instantiadedInventoryItem.GetComponent<SetItemInfo>().itemInfo = item;
        instantiadedInventoryItem.GetComponent<SetItemInfo>().AttitemInfo();
        //listOfInventoryItems.Add(instantiadedInventoryItem);
    }

    public void RemoveItem(Item item)
    {
        if (shopPanel.activeSelf)
        {
            inventory.itemsInInventory.Remove(item);
            //Destroy(listOfInventoryItems[listOfInventoryItems.Count - 1]);
        }
        

    }
}
