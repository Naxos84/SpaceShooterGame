using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TraverseScreenScript : MonoBehaviour {

    public int sceneToLoad;
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 80, 100, 30), "Current Scene: " + SceneManager.GetActiveScene().buildIndex);
        if(GUI.Button(new Rect(Screen.width/2 - 50, Screen.height - 50, 100, 40), "LoadScene " + (SceneManager.GetActiveScene().buildIndex + 1)))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
