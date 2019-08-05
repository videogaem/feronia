using Godot;
using System;

public class Player : Character
{
	
    public override void _Ready()
    {
		base._Ready();
    }

	public override void _Process(float delta){
		MouseHandler();
		KeyHandler();

		base._Process(delta);
	}
	
	private void MouseHandler(){
		direction = (GetGlobalMousePosition() - GlobalPosition).Angle();
		if(direction < 0){
			direction += 2*Mathf.Pi;
		}
	}
	
	private void KeyHandler(){
		velocity.x = 0;
		velocity.y = 0;
		
		if (Input.IsActionPressed("ui_right"))
	    {
	        velocity.x += 1;
	    }
	
	    if (Input.IsActionPressed("ui_left"))
	    {
	        velocity.x -= 1;
	    }
	
	    if (Input.IsActionPressed("ui_down"))
	    {
	        velocity.y += 1;
	    }
	
	    if (Input.IsActionPressed("ui_up"))
	    {
	        velocity.y -= 1;
	    }
	}
	
	
}
