using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelController: MonoBehaviour {
    [Tooltip("An Array of Hazards that can be spawned")]
    public GameObject[] hazards;

    public Vector3 spawnValues;

    public int hazardCount;
    [Tooltip("Time in Seconds between spawning 2 hazards")]
    public float spawnRate;
    [Tooltip("Time before 1st wave starts. And Time between Waves.")]
    public float startWait;

    public UnityEngine.UI.Text restartText;

    private bool gameOver;
    private bool restart;


	// Use this for initialization
	void Start () {
        GameObject playerShip = GameControl.instance.playerShip;
        playerShip.SetActive(true);
        playerShip.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
        Init();
	}
    void Init()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        StartCoroutine(spawnWaves());
    }
	
	// Update is called once per frame
	void Update () {
        if(restart && Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (!gameOver) {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                int random = Random.Range(0, hazards.Length);
                Instantiate(hazards[random], spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnRate);
            }
            yield return new WaitForSeconds(startWait);
            
        }
    }

    public void addToScore(int scoreValue)
    {
            GameControl.instance.score += scoreValue;
    }

    public void setGameOver()
    {
        gameOver = true;
        restartText.text = "GAME OVER \n Hit ESC to get back to the Menu.";
        restart = true;
    }
}
