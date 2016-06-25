using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[System.Serializable]
public class Player
{
    public float minHealth;
    public float maxHealth;
    public float minEnergy;
    public float maxEnergy;
    public float minShield;
    public float maxShield;
}

public class GameVariables : MonoBehaviour {

    public Player player;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Keypad0))
        {
            SceneManager.LoadScene("Game");
        }
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            SceneManager.LoadScene("Scene2");
        }
    }

}
