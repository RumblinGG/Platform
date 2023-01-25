using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
private Transform player;
void Start()
{
     player = GameObject.FindWithTag("Player").transform;
}
void Update()
{
Vector3 temp = transform.position;
temp.y = player.position.y+2f;
temp.z = player.position.z-5f;
temp.x = player.position.x+0.5f;

transform.position = temp;
}
}
