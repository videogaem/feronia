using Godot;
using System;

public class Character : Node2D
{	
	[Export]
	public int movementSpeed = 400;
	
	public float direction;
    public Vector2 velocity = new Vector2();
	private Vector2 _screenSize;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
		_screenSize = GetViewport().GetSize();
    }

	public override void _Process(float delta){
		turnCharacter();
		moveCharacter(delta);
	}
	
	private void turnCharacter(){
		var Sprite = GetNode<AnimatedSprite>("Sprite");
		
		if(direction < Mathf.Pi/8 || direction >= 15*Mathf.Pi/8){
			Sprite.Animation = "right";
			Sprite.FlipH = false;
		} else if(direction < 3*Mathf.Pi/8){
			Sprite.Animation = "right_down";
			Sprite.FlipH = false;
		}else if(direction < 5*Mathf.Pi/8){
			Sprite.Animation = "down";
			Sprite.FlipH = false;
		}else if(direction < 7*Mathf.Pi/8){
			Sprite.Animation = "right_down";
			Sprite.FlipH = true;
		}else if(direction < 9*Mathf.Pi/8){
			Sprite.Animation = "right";
			Sprite.FlipH = true;
		}else if(direction < 11*Mathf.Pi/8){
			Sprite.Animation = "right_up";
			Sprite.FlipH = true;
		}else if(direction < 13*Mathf.Pi/8){
			Sprite.Animation = "up";
		}else if(direction < 15*Mathf.Pi/8){
			Sprite.Animation = "right_up";
			Sprite.FlipH = false;
		}
	}
	
	private void moveCharacter(float delta){
		var Sprite = GetNode<AnimatedSprite>("Sprite");
		if(velocity.Length() > 0){
			velocity = velocity.Normalized() * movementSpeed;
			Sprite.Play();
		} else {
			Sprite.Stop();
			Sprite.SetFrame(0);
		}
		
		Position += velocity * delta;
		Position = new Vector2(
		    x: Mathf.Clamp(Position.x, 0, _screenSize.x),
		    y: Mathf.Clamp(Position.y, 0, _screenSize.y)
		);
		
	}
	
}
