using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SpawnText : MonoBehaviour
{
    internal static void SpawnNeedObj()
    {
        throw new NotImplementedException();
    }

    public void SpawnNeedObj(GameObject objfreefab)
{
Instantiate(objfreefab);
}

}