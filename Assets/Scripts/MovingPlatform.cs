 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 
 public class MovingPlatform : MonoBehaviour
 {
	public CharacterController2D controller;
	
	float runSpeed = 40f;
	
	float horizontalMove = 0f;
	
	void Update () {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
	}
	
	void FixedUpdate () {
		
		controller.Move(horizontalMove , false, false);
	}
 }