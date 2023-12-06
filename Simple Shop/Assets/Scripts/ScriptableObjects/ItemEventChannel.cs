using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "ItemEventChannel", menuName = "Event Channels/Item")]
public class ItemEventChannel : ScriptableObject
{
    public UnityAction<Item> OnEventRaised;

    public void RaiseEvent(Item value)
    {
        OnEventRaised?.Invoke(value);
    }
}
