using Godot;
using System;

public class Character : Node2D
{	
	[Export]
	public int movementSpeed = 400;
	
	private float direction = 0;
    private Vector2 velocity = new Vector2();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

	public override void _Process(float delta){
		
	}
	
	
}
