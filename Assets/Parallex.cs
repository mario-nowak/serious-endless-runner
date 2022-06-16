using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{
    private float length,startpos;
    public GameObject cam;
    public float ParallexEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - ParallexEffect));
        float dist = cam.transform.position.x * ParallexEffect;
        transform.position = new Vector3(startpos +dist ,transform.position.y,transform.position.z );
        if (temp > startpos + length) startpos += length;
        else if(temp < startpos - length) startpos -= length;
    }
}
