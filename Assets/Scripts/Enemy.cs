using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter(Collider other){
    
        // Change the cube color to green.
        MeshRenderer meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = Color.green;
        Debug.Log(other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        // Revert the cube color to white.
        MeshRenderer meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = Color.white;
    }
	}
