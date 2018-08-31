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
                
                Camera cam = Camera.main;
                Vector3 pos = cam.WorldToViewportPoint(transform.position);

                if (gameObject.tag == "LeftWall") {
                    pos.x = 0.0f;
                    pos.y = 0.0f;
                }
                if (gameObject.tag == "RightWall") {
                    pos.x = 1.0f;
                    pos.y = 0.0f;
                }
                if (gameObject.tag == "TopWall") {
                    pos.x = 0.5f;
                    pos.y = 1.0f;
                }

                transform.position = cam.ViewportToWorldPoint(pos);
                
                positionSet = true;
            }
        }
    }
}
