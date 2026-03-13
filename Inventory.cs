using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemInstance> items = new();
    [SerializeField]
    private List<ItemData> startingItems = new();

    private void Awake()
    {
        foreach (var data in startingItems)
            items.Add(data.CreateInstance());
    }

    public void AddItem(ItemData data)
    {
        items.Add(data.CreateInstance());
    }

    public ItemInstance AddItemWithOverrides(ItemData data, System.Action<ItemInstance> modify)
    {
        var instance = data.CreateInstance();
        modify?.Invoke(instance);
        items.Add(instance);
        return instance;
    }

}
