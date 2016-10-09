using UnityEngine;
using System.Collections;

public class Ship_Preview : MonoBehaviour {

    public static Sprite hull;
    public static Sprite left_Wing;
    public static Sprite right_Wing;
    public static Sprite engine;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void setHull(Sprite sprite)
    {
        hull = sprite;
    }
    public static void setWing(Sprite sprite)
    {

    }
}
