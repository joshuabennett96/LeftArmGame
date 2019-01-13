using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public int playerVelocity = 10;
	public float currentY = 0f;
	public bool flagUp = false;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		currentY = rb.position.y;
		Debug.Log(currentY);
		if (flagUp == false){
			rb.velocity = new Vector2(rb.velocity.x, playerVelocity);
			if (currentY >=90){
				flagUp = true;
			}
		}else{
			rb.velocity = new Vector2(rb.velocity.x, 0-playerVelocity);
			if(currentY <=60){
				flagUp = false;
			}
		}
	}
}