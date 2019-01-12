using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
	public Vector2 spawnPoint = new Vector2 (-154, 73);
	public float currentX = 0f;
	public int score;
	public int playerVelocity;
	public Transform destination;
	
	//public Text countText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		playerVelocity = 8;
		//countText.Text = "Score: " + score;
    }

    void Update()
    {	
		//Debug.Log(rb.position.y);
		currentX = rb.position.x;
        rb.velocity = new Vector2(playerVelocity, rb.velocity.y);
		if (currentX >= -52){
			rb.position = spawnPoint;
		//	FindObjectOfType<Score>
			//score = score + 1;
			//countText.Text = "Score: " + score;
		}
    }
	
	void OnCollisionEnter(Collision col)
     {
         if(col.gameObject.tag == "Destroyable Object")
         {
             Destroy(col.gameObject);
         }
     }
}

