using UnityEngine;
using System.Collections;

public class AdjustScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(110, 10, 100, 15), "Health up"))
        {
            GameControl.instance.health++;
        }
        if (GUI.Button(new Rect(110, 25, 100, 15), "Health down"))
        {
            GameControl.instance.health--;
        }
        if (GUI.Button(new Rect(110, 40, 100, 15), "XP up"))
        {
            GameControl.instance.experience++;
        }
        if (GUI.Button(new Rect(110, 55, 100, 15), "XP down"))
        {
            GameControl.instance.experience--;
        }
        if (GUI.Button(new Rect(110, 70, 100, 15), "Score up"))
        {
            GameControl.instance.score++;
        }
        if (GUI.Button(new Rect(110, 85, 100, 15), "Score down"))
        {
            GameControl.instance.score--;
        }
    }
}
