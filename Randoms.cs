using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Randoms : MonoBehaviour
{
    public int amountOfFruits =  Random.Range(1,4);
    public static string [] FoodTypes = {"Banana", "Cherry", "Olive"};
    public string food = FoodTypes[UnityEngine.Random.Range(0, FoodTypes.Length)];

    
}
