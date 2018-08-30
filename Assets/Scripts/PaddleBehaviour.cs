using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PaddleBehaviour : MonoBehaviour {

    private bool positionSet = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(SetPaddle());
    }

    private IEnumerator SetPaddle()
    {
        yield return new WaitForSeconds(0.2f);
        if (!positionSet)
        {
            if (VuforiaBehaviour.Instance.enabled)
            {
                Camera cam = Camera.main;
                Vector3 pos = cam.WorldToViewportPoint(transform.position);
                pos.x = 0.5f;
                pos.y = 0.0f;
                transform.position = cam.ViewportToWorldPoint(pos);

                positionSet = true;
            }
        }
    }

        // Update is called once per frame
    void Update () {
    }
}
