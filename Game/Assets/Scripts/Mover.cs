using UnityEngine;
using System.Collections;

public enum DIRECTION
{
    LEFT,RIGHT
}

public class Mover : MonoBehaviour {
    [Range(1,10)]
    public float speed;
    public DIRECTION direction;

	// Use this for initialization
	void Start () {
        Rigidbody2D rigidBody2D = GetComponent<Rigidbody2D>();
        if (rigidBody2D != null)
        {
            switch (direction)
            {
                case DIRECTION.LEFT:
                    rigidBody2D.velocity = transform.right * -speed;
                    break;
                case DIRECTION.RIGHT:
                    rigidBody2D.velocity = transform.right * speed;
                    break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
