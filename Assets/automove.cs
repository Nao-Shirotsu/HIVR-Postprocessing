using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automove : MonoBehaviour
{
    public float offset = 0.0f;
    public float speed = 0.0f;
    public float range = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(offset + Mathf.Sin(Time.time * speed) * range,transform.position.y,transform.position.y);
    }
}
