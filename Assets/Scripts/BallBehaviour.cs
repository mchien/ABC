using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	public float thrust = 500;
    private Rigidbody rb;
    private Vector3 preVelocity;
    private Vector3 postVelocity;
    private bool started = false;


    void Start()
    {
    }

    void FixedUpdate()
    {
        preVelocity = rb.velocity;
    }

    // Update is called once per frame
    void Update () {
        
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetButtonDown("Fire1"))
        {
            if (!started)
            {
                rb = gameObject.GetComponent<Rigidbody>();
                rb.AddForce(0, -thrust, 0, ForceMode.Force);
            }
            started = true;
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.Reflect(preVelocity, collision.contacts[0].normal);
        if (collision.gameObject.CompareTag("Brick")) {
            Destroy(collision.gameObject);
        }
    }    
}
