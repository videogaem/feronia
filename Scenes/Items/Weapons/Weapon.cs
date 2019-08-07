using Godot;
using System;

public class Weapon : Item
{
    private bool attacking = false;
	private float animationTimer = 0;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

	public override void _Process(float delta){
		if(attacking){
			var attack = GetNode<Area2D>("Attack");
			attack.Rotation += (int) 40*delta;
			animationTimer += delta;
			if(animationTimer > 1){
				attacking = false;
				attack.Visible = false;
			}
		}
	}
	
	public void Attack(){
		var attack = GetNode<Area2D>("Attack");
		attack.Rotation = 0;
		attack.Visible = true;
		animationTimer = 0;
		attacking = true;
		
	}
}
