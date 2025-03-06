using UnityEngine;

namespace AG2189
{
    public class PuppetController : MonoBehaviour
    {

        public float controlSpeed = 50.0f;
        public Vector3 controlVector = Vector3.zero;
        public TeleportPuppet ourPuppet;
        public TeleportPuppet[] ourPuppets;

        private void Start()
        {
            ourPuppet = FindFirstObjectByType<TeleportPuppet>();
            ourPuppets = FindObjectsByType<TeleportPuppet>(FindObjectsSortMode.None);
        }

    
    } 
}
