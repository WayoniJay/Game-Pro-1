using UnityEngine;

namespace AG2189
{
    public class Bomb : Weapon, IThrowable
    {
        [SerializeField] private bool canEquip = true;
        [SerializeField] private bool hasEquiped = false;
        [SerializeField] private bool canUnEquip = false;
        [SerializeField] private float coolDownForEquip = 5.0f;
        [SerializeField] private new float damage = 5.0f;
        [SerializeField] private float damageDone = 0.0f;

        private void Start()
        {
            name = gameObject.name;
            Attack();
        }

        void Update()
        {
            if (Input.anyKey)
            {
                Equip();
                damageDone += Attack();
                Throw();
                Unequip();
            }
        }

        public void Throw()
        {
            Debug.Log($"Throwing a {name}");
       }

        public override float Attack()
        {
            if (hasEquiped)

            {
                Debug.Log("Attacking with a bomb");
                return damageDone;
            }
            return 0f;
        }
            

        public override void Equip()
        {
            Debug.Log($"Equipping{this.name}");
        }

        public override void Unequip()
        {
            Debug.Log($"Unequipping{this.name}");
        }


    }

}