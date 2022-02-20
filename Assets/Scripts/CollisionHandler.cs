using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    int numberOfHits;
private void OnCollisionEnter(Collision other) {
    
    switch(other.gameObject.tag)
        {
    case "Fuel":
        Debug.Log("Fuel added!");
        break;
      case "Finish":
        Debug.Log("You win!");
        break;
    case "Friendly":
        Debug.Log("Landing...");
        break;
    default:
        numberOfHits++;
        Debug.Log("Bump! + " + numberOfHits);
        if(numberOfHits>=2)
        {
        ResetScene();
        }
        break;
    }
}
void ResetScene(){
    int currentScene=SceneManager.GetActiveScene().buildIndex;
SceneManager.LoadScene(currentScene);
}

}
