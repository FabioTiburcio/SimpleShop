using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/Create New inventory")]
public class Inventory : ScriptableObject
{
    public List<Item> itemsInInventory = new List<Item>();
}
