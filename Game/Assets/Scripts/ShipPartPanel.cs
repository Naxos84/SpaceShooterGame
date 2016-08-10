using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShipPartPanel : MonoBehaviour {

    public List<Sprite> sprites;
    public Image content;
    private int current = 0;
    [Tooltip("Enter the name of the Resources/Sprites/Parts/# folder wich parts you want to load.")]
    [SerializeField] string partName = "Cockpits";
    [SerializeField]
    Text displayText;

    void Awake()
    {
        setImagesByResources(this.partName);
    }

	// Use this for initialization
	void Start () {
	    if(sprites.Count > current)
        {
            content.sprite = sprites[current];
        }
        displayText.text = (current+1) + "/" + sprites.Count;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void nextImage()
    {
        if(sprites.Count > current + 1)
        {
            current++;
        }else
        {
            current = 0;
        }
        Debug.Log("SetNext. --> Current = " + current);
        Debug.Log("Sprites Size = " + sprites.Count);
        content.sprite = sprites[current];
        displayText.text = (current + 1) + "/" + sprites.Count;
    }

    public void previousImage()
    {
        if(current == 0)
        {
            current = sprites.Count - 1;
        }else
        {
            current--;
        }
        Debug.Log("SetPrev. --> Current = " + current);
        Debug.Log("Sprites Size = " + sprites.Count);
        content.sprite = sprites[current];
        displayText.text = (current + 1) + "/" + sprites.Count;
    }

    public void setImagesByResources(string partName)
    {
        Sprite[] parts = Resources.LoadAll<Sprite>("Sprites/Parts/" + partName);
        foreach(Sprite part in parts)
        {
            sprites.Add(part);
        }
    }
}
