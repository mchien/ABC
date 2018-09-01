using System.Collections;
using UnityEngine;
using Vuforia;

public class PaddleBehaviour : MonoBehaviour {

    private bool positionSet = false;
    private ImageTargetBehaviour itb;
    private bool started = false;


    // Use this for initialization
    void Start () {
        //StartCoroutine(SetPaddle());
        itb = GameObject.Find("ImageTarget_main").GetComponent<ImageTargetBehaviour>();
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
        if (itb != null) {
            Vector3 pos = new Vector3(itb.transform.position.x, itb.transform.position.y, 20);
            transform.position = pos;

            Quaternion rot = itb.transform.rotation;
            rot.x = 0.0f;
            rot.y = 0.0f;
            transform.rotation = rot;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LeftWall") || collision.gameObject.CompareTag("RightWall"))
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }
}
