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
	public Text countText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		countText.Text = "Score: " + score;
    }

    void Update()
    {	
		Debug.Log(rb.position.y);
		currentX = rb.position.x;
        rb.velocity = new Vector2(8, rb.velocity.y);
		if (currentX >= -52){
			rb.position = spawnPoint;
			score = score + 1;
			countText.Text = "Score: " + score;
		}
    }
}