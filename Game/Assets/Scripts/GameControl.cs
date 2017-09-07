using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameControl : MonoBehaviour
{

    public static GameControl instance;
    public static int WIDTH = 800;
    public static int HEIGHT = 600;
    public static bool FULLSCREEN = true;
    public static int REFRESHRATE = 60;


    public GameObject playerShip;

    public float health;
    public float experience;
    public float score;


    void Awake()
    {
        if (instance == null)
        {
            Screen.SetResolution(WIDTH, HEIGHT, FULLSCREEN, REFRESHRATE);
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
        GUI.Label(new Rect(10, 40, 100, 30), "XP: " + experience);
        GUI.Label(new Rect(10, 70, 100, 30), "Score: " + score);
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

    public void setShip(GameObject ship)
    {
        Destroy(playerShip);
        playerShip = Instantiate<GameObject>(ship);
        playerShip.SetActive(false);
    }
}

