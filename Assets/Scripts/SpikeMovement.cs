using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public int playerVelocity = 10;
	public float currentY = 0f;
	public bool flagUp = false;
	public Player player;
	public bool updated = false;
	public Vector2 notUsing = new Vector2(-206,39);
	public Vector2 level4spawn = new Vector2(-80,73);
	public Vector2 level5spawn = new Vector2(-60,55);
	public bool movement = false;
	private Vector2 stationary = new Vector2 (0,0);
	public bool top = true;
	private int topBorder = 90;
	private int bottomBorder = 60;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		if(top == false){
			topBorder = 63;
			bottomBorder = 47;
		}
	}
	
	// Update is called once per frame
	
	
	void changeLevel(){
		if(player.level == 4){
				rb.position = level4spawn;
				movement = true;
				updated = true;
		}else if(player.level == 5){
				rb.position = level5spawn;
				updated = true;
				movement = true;
		}else{
			rb.position = notUsing;
			updated = true;
			movement = false;
		}
	}
	
	void move() {
		
		currentY = rb.position.y;
		Debug.Log(currentY);
		if (flagUp == false){
			rb.velocity = new Vector2(rb.velocity.x, playerVelocity);
			if (currentY >=topBorder){
				flagUp = true;
			}
		}else{
			rb.velocity = new Vector2(rb.velocity.x, 0-playerVelocity);
			if(currentY <=bottomBorder){
				flagUp = false;
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