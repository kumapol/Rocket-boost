using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    int numberOfHits;
    [SerializeField] int numberOfLives=2;
private void OnCollisionEnter(Collision other) {
    
    switch(other.gameObject.tag)
        {
    case "Fuel":
        Debug.Log("Fuel added!");
        break;

      case "Finish":
        Debug.Log("You win this level");
        Invoke("LoadNextLvl",2f);
        break;

    case "Friendly":
        Debug.Log("Landing...");
        break;

    default:
        numberOfHits++;
        Debug.Log("Bump! + " + numberOfHits);

            if(numberOfHits>=numberOfLives)
            {
            StartCrashSequence();
            }
            break;
    }
}
void StartCrashSequence(){
   GetComponent<Movement>().enabled=false;
 GetComponent<AudioSource>().enabled=false;

    Invoke("ResetScene",2f);
}

void ResetScene(){
    int currentScene=SceneManager.GetActiveScene().buildIndex;
SceneManager.LoadScene(currentScene);
}
void LoadNextLvl()
{
    int currentScene=SceneManager.GetActiveScene().buildIndex;
    int maxScenes=SceneManager.sceneCount;
Debug.Log(maxScenes + "   "+currentScene);
    if(maxScenes<=currentScene)
    {
    SceneManager.LoadScene("LVL1");  
    Debug.Log("You won! Nongrats my dude =D");
    }
    else
    {
    SceneManager.LoadScene(currentScene+1);
    }
}

}
