using UnityEngine;

namespace AG2189
{
    public abstract class AbstractWeapon : MonoBehaviour
    {


        public string weaponName;
        public int damage;

        public abstract void Attack(); // Must be implemented by subclasses

        public void Equip()
        {
            Debug.Log(weaponName + " is equipped.");
        }

    } 
}
