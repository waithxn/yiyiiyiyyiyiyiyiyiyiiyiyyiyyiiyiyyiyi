using System.ComponentModel;
using UnityEngine;

[System.Serializable]
public abstract class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public ItemType itemType;
    public string description;
    public abstract ItemInstance CreateInstance();
}
