using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
  public  Text scoreText;
  private int _score = 0;
  private void OnTriggerEnter(Collider other)
  {
  if(other.gameObject.tag == "Point") 
  {
      _score++;
      Destroy(other.gameObject);
    if   (_score != 5) 
    {
      scoreText.text = "Score: " + _score;
    }
    else 
    {
      scoreText.text = "Congratulations! ";
      SceneManager.LoadScene("Example"); 
    }

}
}        
}

