using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Scaler : MonoBehaviour {

    private bool scaleSet = false;
    public float scaleFactor = 1.0f;
    public bool scaleX = false;
    public bool scaleY = false;
    private float xScale;
    private float yScale;

    void Start () {
        StartCoroutine(ScaleToScreen());
	}

    private IEnumerator ScaleToScreen() {
        yield return new WaitForSeconds(0.2f);
        if (!scaleSet) {
            if (VuforiaBehaviour.Instance.enabled) {
                
                float height = Camera.main.orthographicSize * 2.0f;
                float width = height * Screen.width / Screen.height;

                xScale = transform.localScale.x;
                yScale = transform.localScale.y;

                if (scaleX) { xScale = width * scaleFactor; }
                if (scaleY) { yScale = height * scaleFactor; }


                transform.localScale = new Vector3(xScale, yScale, transform.localScale.z);

            }
            scaleSet = true;
        }
    }

	void Update () {
    }
}
