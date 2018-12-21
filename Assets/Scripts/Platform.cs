using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Rigidbody2D rb;
	
	public float velocity = 10f;
	
	public float VerticalMove = 0f;
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		GetComponent<Renderer>().material.color = new Color(0, 255, 0); //C sharp
    }

    void Update()
    {
		VerticalMove = Input.GetAxisRaw("Vertical");
		
		//if (VerticalMove != 0){
		//	rb.velocity = new Vector2(0, velocity*VerticalMove);
		//
		rb.position = new Vector2(rb.position.x,rb.position.y + VerticalMove);
		Debug.Log(rb.position);
		//}
		
		VerticalMove = 0;
		
		//rb.velocity = new Vector2(rb.velocity.x, velocity*VerticalMove);
		//rb.position = (rb.position.x, rb.position.y + 2f);
    }
	
}