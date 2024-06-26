using UnityEngine;

[CreateAssetMenu(fileName = "DoubleAttackWeaponScriptableObject", menuName = "ScriptableObjects/DoubleAttackWeapon")]
public class DoubleAttackWeapon : Weapon
{
    public override void OnValidate()
    {
        hasAugment = true;
    }
    public override int[] GetBasicAttackDamage() {
        return new int[] {damage,damage};
    }
}