using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
public void loadlevel()
{
Debug.Log ("start game!");
SceneManager.LoadScene("lvl");
}
public void ExitGame()
{
Debug.Log("Exit Game");
Application.Quit();   
}
}

