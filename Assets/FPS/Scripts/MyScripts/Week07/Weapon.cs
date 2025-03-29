using UnityEngine;

namespace AG2189
{
    public abstract class Weapon : MonoBehaviour
    {
        public string name;
        [SerializeField] private float damage = 1.0f;
        [SerializeField] private float modifier = 1.0f;
        //[SerializeField] private bool isNotUsable = false;

        //[SerializeField] private float canUnequip = false;
        //[SerializeField] private float cooldownForEquip = 1.0f;

        //public virtual void Cooldown()
        //{}

        public abstract void Equip();

        public abstract void Unequip();

        public abstract float Attack();
    }
}
