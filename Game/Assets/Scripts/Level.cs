using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

    private static Texture2D background;

    private enum COLOR
    {
        BLACK,BLUE,DARKPURPLE,PURPLE,
    }


	// Use this for initialization
	void Start () {
        background = (Texture2D)Resources.Load("Sprites/Backgrounds/black");
        background.wrapMode = TextureWrapMode.Repeat;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void setPurpleBackground()
    {
        setBackground(COLOR.PURPLE);
    }

    public static void setBlackBackground()
    {
        setBackground(COLOR.BLACK);
    }

    public static void setDarkPurpleBackground()
    {
        setBackground(COLOR.DARKPURPLE);
    }

    public static void setBlueBackground()
    {
        setBackground(COLOR.BLUE);
    }

    private static void setBackground(COLOR color)
    {
        string path = "Sprites/Backgrounds/black";
        switch (color)
        {
            case COLOR.BLACK:
                path = "Sprites/Backgrounds/black";
                break;
            case COLOR.BLUE:
                path = "Sprites/Backgrounds/blue";
                break;
            case COLOR.DARKPURPLE:
                path = "Sprites/Backgrounds/darkpurple";
                break;
            case COLOR.PURPLE:
                path = "Sprites/Backgrounds/purple";
                break;
        }
        Object asset = Resources.Load(path);
        background = (Texture2D)asset;
        background.wrapMode = TextureWrapMode.Repeat;
    }

    public static Texture2D getBackgroundTexture2D()
    {
        return background;
    }
}
