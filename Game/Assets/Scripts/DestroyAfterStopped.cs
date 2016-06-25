using UnityEngine;
using System.Collections;

public class DestroyAfterStopped : MonoBehaviour {

    private ParticleSystem myParticleSystem;

	// Use this for initialization
	void Start () {
        myParticleSystem = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        if(myParticleSystem.isStopped)
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
	}
}
