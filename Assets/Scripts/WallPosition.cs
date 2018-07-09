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
                pos.x = Mathf.Round(Mathf.Clamp01(pos.x));
                pos.y = Mathf.Round(Mathf.Clamp01(pos.y));
                transform.position = cam.ViewportToWorldPoint(pos);
                

                positionSet = true;
            }
        }
    }
}
