using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameItemsData", menuName = "Item/Create New ItemGame Data")]
public class ItemsInGameData : ScriptableObject
{
    public Item[] itemsInGame; 
}
