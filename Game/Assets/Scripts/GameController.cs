using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    //public PlayerShip playerShip;

    public GameObject playerShip;


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
        //if(playerShip == null)
        //{
        //    playerShip = new PlayerShip();
        //}
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
        this.playerShip = playerShip;
    }
}
