using UnityEngine;

namespace AG2189
{
    public class SpeedController : MonoBehaviour
    {

        public MoveUpDown moveScript; // Reference to the movement script
        public float newSpeed = -6f; // New speed to apply

        void Start()
        {
            if (moveScript != null)
            {
                moveScript.SetSpeed(newSpeed); // Modify speed in AutoMoveUpDown script
            }
        }
    }
}