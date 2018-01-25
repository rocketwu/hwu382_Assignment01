using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                try
                {
                    ClickObj obj = hit.transform.gameObject.GetComponent<ClickObj>();
                    obj.Respawn();
                }
                catch (System.Exception)
                {

                }
            }

        }
	}
}
