using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour {

	float VerticalMove = 0f;
	private float yPosition;
	float moveSpeed = 40f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		VerticalMove = Input.GetAxisRaw("Vertical") * moveSpeed;
	}
	
	void FixedUpdate(){
			Vector3 temp = transform.position;
            temp.y += VerticalMove;
            
			transform.position = temp;
		
	}
	
}
