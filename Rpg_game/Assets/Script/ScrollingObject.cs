using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 5f; // 이동속도
    
    void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
    }
}
