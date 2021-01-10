using UnityEngine;
 using System.Collections;
using UnityEngine.SceneManagement;

 public class ControlsScript : MonoBehaviour {

      public void LoadScene()
      {
          SceneManager.LoadScene("Controls", LoadSceneMode.Single);
      }
 }
