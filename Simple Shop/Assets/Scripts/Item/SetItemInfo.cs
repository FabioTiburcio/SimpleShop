using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SetItemInfo : MonoBehaviour
{

    public Item itemInfo;
    public bool storeItem;
    public int itemBuyValue;
    public int itemSellValue;
    public int itemValue;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemValueUi;
    public Image itemImage;
    private Button itemButton;
    public ItemEventChannel purchasedItem;
    public ItemEventChannel sellingItem;

    private void Awake()
    {
        AttitemInfo();
        itemButton = GetComponent<Button>();
    }

    private void OnEnable()
    {
        if (storeItem)
        {
            itemButton.onClick.AddListener(Purchasing);
        }
        else
        {
            itemButton.onClick.AddListener(Selling);
        }
    }
    private void OnDisable()
    {
        itemButton.onClick.RemoveAllListeners();
    }

    public void AttitemInfo()
    {
        itemName.text = itemInfo.itemName;
        itemBuyValue = itemInfo.buyValue;
        itemSellValue = itemInfo.sellValue;
        itemImage.sprite = itemInfo.icon;
        if(storeItem )
        {
            itemValueUi.text = itemBuyValue.ToString();
        }
        else
        {
            itemValueUi.text = itemSellValue.ToString();
        }
        
    }

    public void Purchasing()
    {
        purchasedItem.OnEventRaised(itemInfo);
    }
    public void Selling()
    {
        sellingItem.OnEventRaised(itemInfo);
        Destroy(gameObject);
    }

}
