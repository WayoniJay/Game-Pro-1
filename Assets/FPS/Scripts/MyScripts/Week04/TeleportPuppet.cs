using UnityEngine;

namespace AG2189
{
    public class TeleportPuppet : MonoBehaviour
    {

        public int puppetId;
        public string puppetName;
        public Vector3 rotationAxis = Vector3.right;
        public float rotationSpeed = 30.0f;

        private void Update()
        {
            transform.RotateAround(transform.position,rotationAxis,rotationSpeed * Time.deltaTime);
        }
    } 
}
