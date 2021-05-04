using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color c = new Color(Random.Range(0.0f, 1f), Random.Range(0.0f, 1f), Random.Range(0.0f, 1f));
        this.GetComponent<Renderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
