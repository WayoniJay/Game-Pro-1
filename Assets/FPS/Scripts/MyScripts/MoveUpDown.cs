using UnityEngine;

namespace AG2189
{
    public class MoveUpDown : MonoBehaviour
    {
        private float speed = 3f; // Speed of movement
        private float maxHeight = 3f; // Maximum height
        private float minHeight = 0f; // Minimum height

        private int direction = 1; // 1 for up, -1 for down

        private void Update()
        {
            // Move the object up or down
            transform.Translate(Vector3.up * speed * direction * Time.deltaTime);

            // Change direction if reaching limits
            if (transform.position.y >= maxHeight)
            {
                direction = -1; // Move down
            }
            else if (transform.position.y <= minHeight)
            {
                direction = 1; // Move up
            }
        }

        public void SetSpeed(float newSpeed)
        {
            if (newSpeed > maxHeight)
            {
                speed = maxHeight;
                return;
            }
            else if (newSpeed < minHeight)
            {
                speed = minHeight;
                return;
            }
            speed = newSpeed;
        }
    }
}
