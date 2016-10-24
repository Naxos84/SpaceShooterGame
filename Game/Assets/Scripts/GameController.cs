using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    private GameObject playerShip;


    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void setPlayerShip(GameObject playerShip)
    {
        this.playerShip = playerShip;// Instantiate<GameObject>(playerShip);
        Debug.Log("Set Player Ship to " + playerShip.name);
    }

    public GameObject getPlayerShip()
    {
        Debug.Log("Returned PlayerShip " + playerShip.name);
        return this.playerShip;
    }
}
