using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCaravan : MonoBehaviour
{
    public GameObject caravan;
    public MeshCollider place;
    public float x;
    Vector3 spawnPos;
    Vector3 sizeCol = new Vector3(1,1,1);
    Vector3 center = new Vector3(0f,0.5f,0f);
    public Collider[] colliders;
    bool check;
    void Start()
    {
        
    }


    void Update()
    {
    StartPos();
    }
    void StartPos()
    {
        x = Random.Range(place.transform.position.x - Random.Range(0,place.bounds.extents.x), place.transform.position.x + Random.Range(0,place.bounds.extents.x));
        spawnPos = new Vector3(x,6.3f,0);
        check = CheckSpawnPoint(spawnPos);
        if(check)
        {
        GameObject cart = Instantiate(caravan,spawnPos,Quaternion.identity);
        cart.name = "Сaravans";
        }
        else
        {
            StartPos();
            print("Fuck you");
        }
    }
    bool CheckSpawnPoint(Vector3 spawnpos)
    {
    colliders = Physics.OverlapBox(spawnPos, sizeCol);
    if(colliders.Length > 0)
    {
        return false;
    }
    else
    {
        return true;
    }
    }

}
