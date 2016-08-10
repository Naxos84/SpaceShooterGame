using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    
    public Texture2D barFull;
    public Texture2D barEmpty;
    public float healthValue;
    public Vector2 position;
    public Vector2 size;

    void OnGUI()
    {
        GUI.BeginGroup(new Rect(position.x, position.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), barEmpty);
        //filed part
        GUI.BeginGroup(new Rect(0, 0, size.x * healthValue, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), barFull);
        GUI.EndGroup();
        GUI.EndGroup();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void setHealth(float value)
    {
        healthValue = value;
    }
}
