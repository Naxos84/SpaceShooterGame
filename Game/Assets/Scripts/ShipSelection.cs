using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ShipSelection : MonoBehaviour {

    public Button previous;
    public Button next;
    private int selectionIndex;

    public List<GameObject> availableShips;

    private GameObject selectedShip;

	// Use this for initialization
	void Start () {
        selectionIndex = -1;
        nextShip();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    public void nextShip()
    {
        selectionIndex++;

        if(selectionIndex >= availableShips.Count)
        {
            selectionIndex = 0;
        }

        selectedShip = createNewShip(availableShips[selectionIndex]);
        GameController.instance.setPlayerShip(availableShips[selectionIndex]);
    }

    public void previousShip()
    {
        selectionIndex--;
        if(selectionIndex < 0)
        {
            selectionIndex = availableShips.Count - 1;
        }
        selectedShip = createNewShip(availableShips[selectionIndex]);
        GameController.instance.setPlayerShip(availableShips[selectionIndex]);
    }

    private void centerGameObject(GameObject gameObject)
    {
        Vector3 p = transform.position;
        Debug.Log("ShipSelection Position: X|Y --> " + p.x + "|" + p.y);
        gameObject.transform.position = new Vector2(p.x, p.y);
    }

    private GameObject createNewShip(GameObject newShip)
    {
        Destroy(selectedShip);
        GameObject ship = Instantiate<GameObject>(newShip);
        centerGameObject(ship);
        return ship;
    }
}
