using UnityEngine;

namespace AG2189
{
    public class Rock : Weapon, IThrowable
    {
        public GameObject RockPrefab;
        [SerializeField] private Transform equipper;
        public Transform ThrowWeaponHolder;
        public float throwSpeed = 10.0f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                equipper = other.GetComponent<Transform>();
                Equip();
            }
            
        }
        public override float Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Equip()
        {
            ThrowWeaponHolder = equipper.Find("ThrowWeaponHolder");
            transform.position = ThrowWeaponHolder.position;
            transform.parent = ThrowWeaponHolder;
        }

        public override void Unequip()
        {
            throw new System.NotImplementedException();
        }

        public void Throw()
        {
            Debug.Log($"Throwing a {name}");
            GameObject throwableObject = Instantiate(RockPrefab, transform.position, transform.rotation);
            Vector3 throwVector = ThrowWeaponHolder.forward * throwSpeed;
            throwableObject.GetComponent<Rigidbody>().AddForce(throwVector);

        }
 
    } 
}
