using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Menu : MonoBehaviour {

    public bool show;
    public int buttonWidth;
    public int buttonHeight;

    public GameObject shipSelection;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnGUI()
    {
        if (show)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2 - buttonHeight, buttonWidth / 2, buttonHeight), "<<"))
            {
                shipSelection.GetComponent<ShipSelection>().previousShip();
            }
            if (GUI.Button(new Rect(Screen.width / 2 , Screen.height / 2 - buttonHeight / 2 - buttonHeight, buttonWidth / 2, buttonHeight), ">>"))
            {
                shipSelection.GetComponent<ShipSelection>().nextShip();
            }
            if (GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Start Game"))
            {
                GameControl.instance.loadScene("Game");
            }
            if(GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2 + buttonHeight, buttonWidth, buttonHeight), "Quit Game"))
            {
                GameControl.instance.quitGame();
            }
        }
        
    }

}
