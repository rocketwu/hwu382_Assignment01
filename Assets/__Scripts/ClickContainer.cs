using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickContainer : MonoBehaviour {
    public GameObject container;
    public float rotateSpeed=10f;
    private bool r = false;
    private Vector3 startAng;
    private Vector3 endAng;
    private float range = 20f;
    //private bool firstTime=true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (r)
        {
            startAng.x = Mathf.MoveTowardsAngle(startAng.x, endAng.x, rotateSpeed);
            startAng.y = Mathf.MoveTowardsAngle(startAng.y, endAng.y, rotateSpeed);
            startAng.z = Mathf.MoveTowardsAngle(startAng.z, endAng.z, rotateSpeed);
            if (startAng == endAng) r = false;
            Debug.Log(r);
            container.transform.eulerAngles = startAng;
           // rotating(0,0,0);
        }
        
    }



    void OnMouseDown()
    {
        r = true;
        startAng = container.transform.eulerAngles;
        endAng = new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
        range += 5f;
        Debug.Log(endAng);
    }
}
