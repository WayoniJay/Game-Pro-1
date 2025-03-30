using UnityEngine;

namespace AG2189
{
    public class Sword : Weapon
    {
        private void Start()
        {
            weaponName = "Sword";
            damage = 50;
        }

        public override float Attack()
        {
            Debug.Log("Swinging the sword for " + damage + " damage.");
            return damage;
        }

        public override void Equip()
        {
            Debug.Log($"Equipping {weaponName}.");
        }

        public override void Unequip()  
        {
            Debug.Log($"Unequipping {weaponName}.");
        }
    }
     
}
