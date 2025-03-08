using UnityEngine;
using UnityEngine.AI;

namespace AG2189
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        public float health = 100f;
        [SerializeField] private float damage = 10f;
        [SerializeField] private NavMeshAgent agent;

        private PlayerController player;

        private void Start()
        {
            player = FindFirstObjectByType<PlayerController>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            agent.destination = player.transform.position;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                player.TakeDamage(damage);
                //collision.transform.localScale *= 2f;
            }
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.Log($"Current health: {health}");
        }
    } 
}
