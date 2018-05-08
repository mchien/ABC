using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
    public float speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var now = System.DateTime.Now;
        var s = now.Second;
        var ms = now.Millisecond;

        var sFactor = 360f / 60f;
        var mFactor = 6f / 1000f;

        var degrees = s * sFactor + ms * mFactor;

        transform.rotation = Quaternion.Euler(degrees * speed * -1, transform.rotation.y, transform.rotation.z);
    }
}
