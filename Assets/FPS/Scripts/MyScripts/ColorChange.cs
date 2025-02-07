using UnityEngine;

public class ColorChange : MonoBehaviour
{

    Renderer ren;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       ren=GetComponent<Renderer>();
       ren.material.color = Color.blue;
    }

 
}
