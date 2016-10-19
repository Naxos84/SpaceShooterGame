using UnityEngine;
using System.Collections;


public class Ship : MonoBehaviour {


    public GameObject cockpit;
    public Sprite sprite;
    public float cockpitOffsetX;
    public float cockpitOffsetY;
    public float cockpitOffsetZ;


    void OnRenderObject()
    {
        this.transform.position = new Vector3(cockpitOffsetX, cockpitOffsetY);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
