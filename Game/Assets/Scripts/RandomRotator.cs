using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    [Tooltip("Maximale Grad/s")]
    public float maxAngularVelocity;

	// Use this for initialization
	void Start () {
        Rigidbody2D rigidBody2D = GetComponent<Rigidbody2D>();
        if(rigidBody2D != null)
        {
            rigidBody2D.angularDrag = 0;
            rigidBody2D.angularVelocity = Random.Range(1, maxAngularVelocity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
