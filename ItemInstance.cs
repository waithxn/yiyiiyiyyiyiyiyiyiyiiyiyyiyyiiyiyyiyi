[System.Serializable]
public abstract class ItemInstance
{
    public ItemData data;

    protected ItemInstance(ItemData data)
    {
        this.data = data;
    }
}
