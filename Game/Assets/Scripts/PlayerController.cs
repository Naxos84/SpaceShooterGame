using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController: MonoBehaviour {

    public float speed;
    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;

    public float fireRate;
    private float nextFire = 0.0f;

    public float health;
    public float energy;
    public float shield;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0);

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        if(rigidbody != null)
        {
            rigidbody.velocity = movement * speed;
            rigidbody.position = new Vector3(Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rigidbody.position.y, boundary.yMin, boundary.yMax), 0);
        }

        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            
            AudioSource shotAudio = GetComponent<AudioSource>();
            if (shotAudio != null)
            {
                shotAudio.Play();
            }
        }
    }
    /// <summary>
    /// increases the Health by value and returns the new health Value
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public float healthUp(float value)
    {
        return health += value;
    }
    public float healthDown(float value)
    {
        return health -= value;
    }
    public float energyUp(float value)
    {
        return energy += value;
    }
    public float energyDown(float value)
    {
        return energy -= value;
    }
    public float shieldUp(float value)
    {
        return shield += value;
    }
    public float shieldDown(float value)
    {
        return shield -= value;
    }
}
