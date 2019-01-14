using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public int playerVelocity = 10;
	public float currentX = 0f;
	public bool flagLeft = false;
	public Player player;
	public bool updated = false;
	public Vector2 notUsing = new Vector2(-206,39);
	public Vector2 level6spawn = new Vector2(-80,73);
	public bool movement = false;
	private Vector2 stationary = new Vector2 (0,0);
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	
	
	void changeLevel(){
		if(player.level == 6){
				rb.position = level6spawn;
				movement = true;
				updated = true;
		}else if(player.level == 2 || player.level == 3){
				updated = true;
				movement = true;
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
			if (currentX >=-70){
				flagLeft = true;
			}
		}else{
			rb.velocity = new Vector2(0-playerVelocity, rb.velocity.y);
			if(currentX <=-85){
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