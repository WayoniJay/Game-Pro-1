using AG2189;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject BombPrefab;
    public GameObject RockPrefab;

    void Start()
    {
        // Instantiate a Bomb
        GameObject bombInstance = Instantiate(BombPrefab, new Vector3(0, 1, 0), Quaternion.identity);
        bombInstance.GetComponent<Weapon>().Equip();

        // Instantiate a RockInstance
        GameObject RockInstance = Instantiate(RockPrefab, new Vector3(2, 1, 0), Quaternion.identity);
        RockInstance.GetComponent<Rock>().Throw();
    }
}


