using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public int playerVelocity = 10;
	public float currentX = 0f;
	public float leftBarrier = 0f;
	public float rightBarrier = 0f;
	public bool flagLeft = false;
	public Player player;
	public bool updated = false;
	public Vector2 notUsing = new Vector2(-206,39);
	public Vector2 spawn = new Vector2(-72,84);
	public Vector2 level3spawn = new Vector2(-72,84);
	public Vector2 level6spawn = new Vector2(-80,73);
	public Vector2 level8spawn = new Vector2();
	public bool movement = false;
	private Vector2 stationary = new Vector2 (0,0);
	
	// Use this for initialization
	void Start () {
		if(player.level == 1){
			rb.position = spawn;
		}else{
			rb.position = notUsing;
		}
	}
	
	// Update is called once per frame
	
	
	void changeLevel(){
		if(player.level == 6){
				rb.position = level6spawn;
				movement = true;
				updated = true;
		}else if(player.level == 2){
				updated = true;
				movement = true;
				leftBarrier = -85;
				rightBarrier = -70;
		}else if(player.level == 3){
			rb.position = level3spawn;
			updated = true;
			movement = true;
			leftBarrier = -100;
			rightBarrier = -85;
			
		}else if(player.level == 4){
				rb.position = spawn;
				updated = true;
				movement = false;
		}else if(player.level == 8){
			rb.position = level8spawn;
			movement = true;
			updated = true;
		
		}else{
			rb.position = notUsing;
			updated = true;
			movement = false;
		}
	}
	
	void move() {
		
		currentX = rb.position.x;
		if (flagLeft == false){
			rb.velocity = new Vector2(playerVelocity, rb.velocity.y);
			if (currentX >=rightBarrier){
				flagLeft = true;
			}
		}else{
			rb.velocity = new Vector2(0-playerVelocity, rb.velocity.y);
			if(currentX <=leftBarrier){
				flagLeft = false;
			}
		}
	}
	
	void Update () {
		
		if (player.changeLevel == true){
			changeLevel();
		}
		
		if(movement == true){
			move();
		}else{
			rb.velocity = stationary;
		}
	}
}