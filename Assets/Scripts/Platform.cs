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
		if((rb.position.y < 90 && rb.position.y >48)||(rb.position.y >= 90 && VerticalMove < 0)||(rb.position.y <= 48 && VerticalMove >0)){
			rb.position = new Vector2(rb.position.x,rb.position.y + VerticalMove);
		}else if(rb.position.y > 45 ){
			
		}
		//Debug.Log(rb.position);
		//}
		
		VerticalMove = 0;
		
		//rb.velocity = new Vector2(rb.velocity.x, velocity*VerticalMove);
		//rb.position = (rb.position.x, rb.position.y + 2f);
    }
	
}