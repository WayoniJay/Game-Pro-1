using UnityEngine;

namespace AG2189
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] private float speed = 5f;
        [SerializeField] private float health = 100f;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(x, 0, z).normalized;
            transform.position += direction * (speed * Time.deltaTime);
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.transform.GetComponent<EnemyController>().health -= 30f;
            }
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.Log($"Current health: {health}");
        }
    } 
}

