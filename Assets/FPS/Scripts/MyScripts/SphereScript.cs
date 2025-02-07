using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float amp;
    public float freq;
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
