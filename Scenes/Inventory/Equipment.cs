using Godot;
using System;

public class Equipment : Node2D
{
    public Weapon weapon;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

	public Weapon getWeapon(){
		return weapon;
	}
}
