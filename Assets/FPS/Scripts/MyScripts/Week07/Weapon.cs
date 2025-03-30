using UnityEngine;

namespace AG2189
{
    public abstract class Weapon : MonoBehaviour
    {
        public string weaponName;
        [SerializeField] public float damage = 1.0f;
        [SerializeField] private float modifier = 0.0f;
        //[SerializeField] private bool isNotUsable = false;
        public WeaponTypes weaponType;

        public virtual void Equip()
        {
            print($"Equipping weapon of type {weaponType}");
        }

        public abstract void Unequip();

        public abstract float Attack();
    }

    public enum WeaponTypes
    {
        Melee,
        Projectile,
        Explosives,
        Scifi
    }
    public enum DamageType
    {
        None = 0,
        Kinetic,
        Electric,
        Incindiary,
        Ice,
        Poison,
        Air,
        Nature,
        Magical
    }
}
