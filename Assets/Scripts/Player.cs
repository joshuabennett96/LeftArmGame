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
	public int level = 1;
	public bool changeLevel = false;
	public SpikeMovement spike1;
	public LavaMovement lava1;
	
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
		if (currentX >= -52 && changeLevel == false){
			level = level + 1;
			changeLevel = true;
		}else if (currentX >= -52 && changeLevel == true){
			if(spike1.updated == true && lava1.updated == true){
				rb.position = spawnPoint;
				changeLevel = false;
				spike1.updated = false;
				lava1.updated = false;
			}
		}
			
			
		//	FindObjectOfType<Score>
			//score = score + 1;
			//countText.Text = "Score: " + score;
		
    }
	
	void OnCollisionEnter(Collision col)
     {
         if(col.gameObject.tag == "Destroyable Object")
         {
             Destroy(col.gameObject);
         }
     }
}

