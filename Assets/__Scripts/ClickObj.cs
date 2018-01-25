using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObj : MonoBehaviour {
    private Vector3 init;
	// Use this for initialization
	void Start () {
        init = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Respawn()
    {
        transform.position = init;
    }
}
