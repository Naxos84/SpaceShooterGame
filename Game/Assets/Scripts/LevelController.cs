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

    private int scorePoints;

    public UnityEngine.UI.Text scoreText;

    public UnityEngine.UI.Text restartText;

    private bool gameOver;
    private bool restart;


	// Use this for initialization
	void Start () {
        GameObject playerShip = Instantiate<GameObject>(GameController.instance.getPlayerShip());
        playerShip.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
        Init();
	}
    void Init()
    {
        scorePoints = 0;
        gameOver = false;
        restart = false;
        restartText.text = "";
        updateScore();
        StartCoroutine(spawnWaves());
    }
	
	// Update is called once per frame
	void Update () {
        if(restart && Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Game");
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

    void updateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + scorePoints;
        }
        else
        {
            Debug.LogError("Cannot find 'GUIText' for updating Scoretext.");
        }
    }

    public void addToScore(int scoreValue)
    {
            scorePoints += scoreValue;
            updateScore();
    }

    public void setGameOver()
    {
        gameOver = true;
        restartText.text = "GAME OVER \n Hit ESC to restart.";
        restart = true;
    }
}
