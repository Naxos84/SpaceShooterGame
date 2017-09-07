using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ShipSelection : MonoBehaviour {

    private int selectionIndex = 0;

    public List<GameObject> availableShips;
    

	// Use this for initialization
	void Start () {
        availableShips = new List<GameObject>();
        foreach(Transform t in transform)
        {
            availableShips.Add(t.gameObject);
        }

        foreach(GameObject ship in availableShips)
        {
            ship.SetActive(false);
        }
        nextShip();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
    }

    

    public void nextShip()
    {
        availableShips[selectionIndex].SetActive(false);
        selectionIndex++;

        if(selectionIndex >= availableShips.Count)
        {
            selectionIndex = 0;
        }
        availableShips[selectionIndex].SetActive(true);

        GameControl.instance.setShip(availableShips[selectionIndex]);
    }

    public void previousShip()
    {
        availableShips[selectionIndex].SetActive(false);
        selectionIndex--;
        if(selectionIndex < 0)
        {
            selectionIndex = availableShips.Count - 1;
        }

        availableShips[selectionIndex].SetActive(true);

        GameControl.instance.setShip(availableShips[selectionIndex]);
    }
}
