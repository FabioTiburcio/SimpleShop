using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName ="Item/Create New Item")]
public class Item : ScriptableObject
{

    public enum ItemType
    {
        Hood,
        Chest,
        Pants,
    }

    public int id;
    public ItemType type;
    public string itemName;
    public Sprite icon;
    public int buyValue;
    public int sellValue;
   
}
