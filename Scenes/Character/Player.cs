using Godot;
using System;

public class Player : Character
{
    private float direction = 0;
	
    public override void _Ready()
    {
        GetNode<AnimatedSprite>("Sprite").Play();
    }

	public override void _Process(float delta){
		direction += 0.02f;
		if(direction > 2*Mathf.Pi){
			direction = 0;
		}
		turn_character();
	
	}
	
	
	
	private void turn_character(){
		var Sprite = GetNode<AnimatedSprite>("Sprite");
		
		if(direction < Mathf.Pi/4){
			Sprite.Animation = "right";
		} else if(direction < Mathf.Pi/2){
			Sprite.Animation = "right_down";
		}else if(direction < 3*Mathf.Pi/4){
			Sprite.Animation = "down";
		}else if(direction < Mathf.Pi){
			Sprite.Animation = "right_down";
			Sprite.FlipH = true;
		}else if(direction < 5*Mathf.Pi/4){
			Sprite.Animation = "right";
			Sprite.FlipH = true;
		}else if(direction < 3*Mathf.Pi/2){
			Sprite.Animation = "right_up";
			Sprite.FlipH = true;
		}else if(direction < 7*Mathf.Pi/4){
			Sprite.Animation = "up";
		}else if(direction < 2*Mathf.Pi){
			Sprite.Animation = "right_up";
		}
	}
}
