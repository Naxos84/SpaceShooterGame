using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Menu : MonoBehaviour {
    [SerializeField] Dropdown cockpitDropDown;



	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private class CockpitItem{

        string text;

        public CockpitItem(string text)
        {
            this.text = text;
        }

        public string getText()
        {
            return text;
        }
    }
}
