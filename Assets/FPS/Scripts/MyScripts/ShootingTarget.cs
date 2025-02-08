using UnityEngine;

namespace AG2189
{
   
    public class ShootingTarget : MonoBehaviour
    {
        [SerializeField] private Transform[] targetEndPoints;
        private Transform target;
        private int currentEndPointIndex = 0;
        public float speed = 1.0f;

        private void Start()
        {
            target = targetEndPoints[0];
        }

        private void Update()
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                SwapEndPointTarget();
            }
        }

        public void SwapEndPointTarget()
        {
            currentEndPointIndex++;
            currentEndPointIndex %= targetEndPoints.Length;
            target = targetEndPoints[currentEndPointIndex];
        }
    }
}

