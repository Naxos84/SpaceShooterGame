using UnityEngine;
using System.Collections;

public class ScrollableBackground : MonoBehaviour {

    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        Renderer renderer = GetComponent<Renderer>();
        Vector2 offset = new Vector2(Time.time * speed, 0);
        if (renderer != null)
        {
            Texture2D backgroundTexture2D = Level.getBackgroundTexture2D();
            if (backgroundTexture2D != null)
            {
                renderer.material.mainTexture = backgroundTexture2D;
            }
            else
            {
                Debug.Log("BackgroundTexture2D = null");
            }
            renderer.material.mainTextureOffset = offset;
        }
        else
        {
            Debug.Log("Renderer = null");
        }
	}
}
