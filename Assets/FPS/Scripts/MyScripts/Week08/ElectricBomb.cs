using UnityEngine;

namespace AG2189
{
    public sealed class ElectricBomb : Bomb
    {
        [SerializeField] private readonly DamageType damageType = DamageType.Electric;
    } 
}
