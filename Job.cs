using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
[System.Serializable]

public class Job : MonoBehaviour
{
    private Transform player;
    public  Text scoreText;
    private int _score = 0;
    int amountOfFruits;
    string food;
    public GameObject FinishMenu;
    public bool finish; 
    private Animator anim;
    public GameObject[] fruits;
    public List<Transform>spawnPoint;
    public Text textGame;
    private string text;
    IEnumerator TextCoroutine()
    {
        foreach(char abc in text)
        {
            textGame.text+=abc;
            yield return new WaitForSeconds(0.09f);
        }
    }
    void Awake()
    {
    player = GameObject.FindWithTag("Player").transform;
    anim = GetComponent<Animator>();
    }
    public void Start()
    {text = textGame.text;
    textGame.text ="";
    StartCoroutine(TextCoroutine());
    amountOfFruits =  Random.Range(1,4);
    string [] FoodTypes = {"Banana", "Cherry", "Olive"};
    food = FoodTypes[UnityEngine.Random.Range(0, FoodTypes.Length)];
    scoreText.text = "Need "+ amountOfFruits +" - " + food + ": " + _score;
    } 
    void Update()
    {
        if ((Input.GetMouseButtonUp(0))|| (Input.GetKeyUp(KeyCode.S)))
            {    
            anim.Play("PickUp");
            anim.Play("PickDown",1);
            }
        else 
            {
            anim.SetBool("Pick",false);  
            }
        // if (_score == amountOfFruits)
        // {
        //     anim.Play("Dance");
        // }
    }
public void  OnTriggerStay(Collider other)
{
    do
    {
        if(Input.GetKeyUp(KeyCode.S) && other.gameObject.tag == food)
    {
        SpawnF();
        Destroy(other.gameObject);
        _score++;
    }
    else
    {
        scoreText.text = " Congratulations! ";
    }
    
        if   (_score < amountOfFruits) 
        {
            scoreText.text = "Need "+ amountOfFruits +" - " + food + ": " + _score;
        }
        if(_score == amountOfFruits )
        {  
        
        scoreText.text = "Congratulations! ";
        }
    } while (_score == amountOfFruits);
    if(scoreText.text == "Congratulations! ")
        {
        anim.Play("Dance");
        Finish();
        }
}

    public void Finish()
    {   anim.SetBool("Dance",true);
        Vector3 temp = transform.localScale;
        temp.y = player.localScale.y+1.8f;
        temp.z = player.localScale.z+1.6f;
        temp.x = player.localScale.x+1.6f;
        transform.localScale = temp;
        FinishMenu.SetActive(true);
        finish = true;
    } 
public void load()
{
Debug.Log ("start game!");
SceneManager.LoadScene("Lvl"); 
}
void SpawnF()
{
for(int food = 0; food < fruits.Length; food++) 
{
    
var spawn = Random.Range(0,spawnPoint.Count);
Instantiate(fruits[food],spawnPoint[spawn].transform.position,Quaternion.identity);
spawnPoint.RemoveAt(spawn);
}
}
}

