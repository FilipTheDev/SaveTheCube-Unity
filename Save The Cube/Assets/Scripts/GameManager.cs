using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

  public float restartDelay = 1f;
  bool gameEnded = false;
  public GameObject completeLevelUI;

  public void CompleteLevel() {
    completeLevelUI.SetActive(true);
  }

  public void EndGame () {
    if (gameEnded == false) {

          gameEnded = true;
          Debug.Log("Game over");
          Invoke("Restart", restartDelay);
    }

  }

  void Restart () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

  }

}
