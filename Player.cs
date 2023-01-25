using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player: MonoBehaviour 
{
public int Level = 1;
public int HP = 3;
public void SavePlayer () 
{
    SaveSystem.SavePlayer (this);    
}

public void LoadPlayer () 
{
    PlayerData data = SaveSystem.LoadPlayer();
    Level = data.Level; 
    HP = data.HP;

    Vector3 position;
    position.x = data.position[0];  
    position.y = data.position[1];
    position.z = data.position[2];
    transform.position = position;
}

}
