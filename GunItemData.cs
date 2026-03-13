using UnityEngine;

[CreateAssetMenu(menuName = "Items/Gun")]
public class GunItemData : ItemData
{
    public float damage;
    public float shootDelay;
    public float knockbackStrength;
    public float slideShotDamage;
    public float slideShotKnockbackStrength;

    public override ItemInstance CreateInstance()
        => new GunInstance(this);
}
