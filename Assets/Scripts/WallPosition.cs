using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Vuforia;

public class WallPosition : MonoBehaviour {
    private bool positionSet = false;

    // Use this for initialization
    void Start () {

        StartCoroutine(SetWalls());        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator SetWalls() {
        yield return new WaitForSeconds(0.2f);
        if (!positionSet) {
            if (VuforiaBehaviour.Instance.enabled) {
                Transform cam = Camera.main.transform;

                transform.position = new Vector3(
                    cam.right.x * transform.position.x, 
                    cam.up.y * transform.position.y, 
                    cam.forward.z * transform.position.z
                    );


                positionSet = true;
            }
        }
    }
}
