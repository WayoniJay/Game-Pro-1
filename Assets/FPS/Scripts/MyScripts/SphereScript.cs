using UnityEngine;

namespace AG2189
{
    public class SphereScript : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created

        private float amp = 0.3f;
        private float freq = 3;
        Vector3 initPos;

        private void Start()
        {
            initPos = transform.position;
        }

        // Update is called once per frame
        private void Update()
        {
            transform.position = new Vector3(initPos.x, initPos.y + Mathf.Sin(Time.time * freq) * amp * initPos.y, initPos.z);
        }
    } 
}
