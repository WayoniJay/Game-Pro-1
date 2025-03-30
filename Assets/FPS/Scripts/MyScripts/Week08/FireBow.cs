namespace AG2189
{
    using UnityEngine;

    public class FireBow : Bow, IEnchantable
    {
        private void Start()
        {
            weaponName = "Fire Bow";
            damage = 40;
        }

        public override float Attack()
        {
            Debug.Log("Shooting a fire arrow for " + damage + " damage!");
            return damage;
        }

        public void Enchant()
        {
            Debug.Log(weaponName + " is enchanted with extra fire damage!");
        }
    }

}
