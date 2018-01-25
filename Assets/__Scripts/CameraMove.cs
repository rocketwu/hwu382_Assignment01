using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject target;
    private Vector3 init;

    // Use this for initialization
    void Start () {
        init=transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (target)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            //Vector3 move = Vector3.right * x * 0.1f + Vector3.forward * y * 0.1f;
            //transform.position += move;
            if (x!=0||y!=0)
            {
                transform.RotateAround(target.transform.position, Vector3.up, x);
                transform.RotateAround(target.transform.position, Vector3.right, y);
                
            }
            
            
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log(transform.position);
            transform.position = init;
            Debug.Log(init);
            
        }
        transform.LookAt(target.transform);

    }



}
