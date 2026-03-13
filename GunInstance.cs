using UnityEngine;
using System;

[System.Serializable]
public class GunInstance : ItemInstance
{
    public float? damageOverride;
    public float? slideshotDamageOverride;
    public float? knockbackStrengthOverride;
    public float? slideshotKnockbackStrengthOverride;

    public GunItemData Data => (GunItemData)data;

    public float damage => damageOverride ?? Data.damage;
    public float slideshotDamage => slideshotDamageOverride ?? Data.slideShotDamage;
    public float knockbackStrength => knockbackStrengthOverride ?? Data.knockbackStrength;
    public float slideshotKnockbackStrength => slideshotKnockbackStrengthOverride ?? Data.slideShotKnockbackStrength;

    public GunInstance(GunItemData data) : base(data)
    { }


}
