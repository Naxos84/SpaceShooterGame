using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    public GameObject asteroidExplosion;
    public GameObject laserExplosion;
    public GameObject playerExplosion;
    public int scoreValue;
    public int health;
    private LevelController levelController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            levelController = gameControllerObject.GetComponent<LevelController>();
        }
        if (levelController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Debug.Log("Collision with " + other.gameObject.name);

        
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            levelController.setGameOver();
        }
        if (other.tag == "Shot")
        {
            Instantiate(laserExplosion, transform.position, transform.rotation);
            Laser laser = other.GetComponent<Laser>();
            health -= laser.damage;
            Debug.Log("Remaining Health = " + health);
        }
        if (health <= 0)
        {
            Instantiate(asteroidExplosion, transform.position, transform.rotation);
            levelController.addToScore(scoreValue);
            Destroy(gameObject);
        }
        Destroy(other.gameObject);
    }
}
