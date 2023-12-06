using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShopItems : MonoBehaviour
{
    public GameObject shopPage;
    public ItemsInGameData gameItemsData;
    public GameObject itemPrefab;

    public void Awake()
    {
        for (int i = 0; i < gameItemsData.itemsInGame.Length; i++)
        {
            GameObject itemInstantiated = Instantiate(itemPrefab, shopPage.transform);
            itemInstantiated.GetComponent<SetItemInfo>().itemInfo = gameItemsData.itemsInGame[i];
            itemInstantiated.GetComponent<SetItemInfo>().AttitemInfo();
        }        
    }
}
