using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    public float Spe;
    public float tp;
    void Start()
    {
        tp  = 1000;
        Spe = 1;
    }
    void Update()
    {
        transform.Translate(Vector3.forward*Spe*Time.deltaTime);
        if(transform.position.x > 806f)
        {
        Destroy(gameObject);
        }
    }


}