using UnityEngine;
using System.Collections;

public class PlayerShip
{

    private Cockpit cockpit;
    private Wing wing;
    private Engine engine;
    private Gun gun;

   public PlayerShip()
    {
        init();
    }

    void init()
    {
        cockpit = Cockpit.getDefault();
        wing = Wing.getDefault();
        gun = Gun.getDefault();
        engine = Engine.getDefault();
    }

    public Cockpit getCockpit()
    {
        if (cockpit == null)
        {
            cockpit = Cockpit.getDefault();
        }
        return cockpit;
    }

    public Wing getWing()
    {
        if (wing == null)
        {
            wing = Wing.getDefault();
        }
        return wing;
    }

    public Gun getGun()
    {
        if (gun == null)
        {
            gun = Gun.getDefault();
        }
        return gun;
    }

    public Engine getEngine()
    {
        if(engine == null)
        {
            engine = Engine.getDefault();
        }
        return engine;
    }
}

public class Part
{
    public Sprite spr;
    public int weight;

    public Part(Sprite sprite, int weight)
    {
        spr = sprite;
        this.weight = weight;
    }

    public void setWeight(int weight)
    {
        this.weight = weight;
    }

    public int getWeight()
    {
        return this.weight;
    }
}
public class Hull : Part
{
    public Hull(Sprite sprite, int weight, int hullStrength, int shield) : base(sprite, weight)
    {
        this.hullStrength = hullStrength;
        this.shield = shield;
    }
    public int hullStrength { get; set; }
    public int shield { get; set; }
}

public class Cockpit : Hull
{
    public Cockpit(Sprite sprite, int weight, int hullStrength, int shield) : base(sprite, weight, hullStrength, shield)
    {

    }

    /// <summary>
    /// Gibt ein Standard blaues Cockpit zurück mit 100 weight 1000 HullStrength und 300 Shield
    /// </summary>
    /// <returns>a Default Cockpit</returns>
    public static Cockpit getDefault()
    {
        return new Cockpit(Resources.Load<Sprite>("Sprites/Parts/Cockpits/cockpitBlue_0"), 100, 1000, 300);
    }
}

public class Wing : Hull
{
    public Wing(Sprite sprite, int weight, int hullStrength, int shield) : base(sprite, weight, hullStrength, shield)
    {

    }

    public static Wing getDefault()
    {
        return new Wing(Resources.Load<Sprite>("Sprites/Parts/Wings/wingBlue_0"), 100, 300, 100);
    }
}

public class Gun : Part
{
    public int damage;
    public int speed;
    public Gun(Sprite sprite, int weight, int damage, int speed) : base(sprite, weight)
    {
        this.damage = damage;
        this.speed = speed;
    }

    public static Gun getDefault()
    {
        return new Gun(Resources.Load<Sprite>("Sprites/Parts/Guns/gun00"), 100, 10, 1);
    }
}

public class Engine : Part
{
    public int power;
    public Engine(Sprite sprite, int weight, int power) : base(sprite, weight)
    {
        this.power = power;
    }

    public static Engine getDefault()
    {
        return new Engine(Resources.Load<Sprite>("Sprites/Parts/Engines/engine1"), 100, 100);
    }
}

