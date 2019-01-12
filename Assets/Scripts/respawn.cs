using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

	[SerializeField] private Transform player;
	[SerializeField] private Transform respawnPoint;
	
	void OnCollisionEnter2D (Collision2D col){
		player.transform.position = respawnPoint.transform.position;
	}
}
