using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviour : MonoBehaviour {

	public float thrust = 500;
    private Rigidbody rb;
    private Vector3 preVelocity;
    private Vector3 postVelocity;
    private bool started = false;
    private Vector3 orgPos;


    void Start()
    {
        orgPos = transform.position;
    }

    void FixedUpdate()
    {
        preVelocity = rb.velocity;
    }

    // Update is called once per frame
    void Update () {

        if (!started)
        {
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetButtonDown("Fire1"))
            {
                rb = gameObject.GetComponent<Rigidbody>();
                rb.AddForce(0, -thrust, 0, ForceMode.Force);
                started = true;
            }
        }
        else
        {
            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            if (pos.y < 0.0f)
            {
                // reactivate all blocks
                Transform[] blocks = GameObject.Find("_BrickController").GetComponentsInChildren<Transform>(true);
                foreach (Transform block in blocks)
                {
                    block.gameObject.SetActive(true);
                }

                // reset ball
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                transform.position = orgPos;

                // reset "started" flag
                started = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.Reflect(preVelocity, collision.contacts[0].normal);
        if (collision.gameObject.CompareTag("Brick")) {
            collision.gameObject.SetActive(false);
        }
        noCollision(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        noCollision(collision);    
    }

    private void OnCollisionStay(Collision collision)
    {
        noCollision(collision);
    }

    private void noCollision(Collision collision) {
        if (!started)
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }
}
