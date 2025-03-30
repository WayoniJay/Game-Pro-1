using AG2189;
using UnityEngine;

namespace AG2189
{
    public class Bow : Weapon
    {
        private void Start()
        {
            weaponName = "Bow";
            damage = 30;
        }

        public override float Attack()
        {
            Debug.Log("Shooting an arrow for " + damage + " damage.");
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


