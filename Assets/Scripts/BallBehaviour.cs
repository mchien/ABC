using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

	public float thrust = 500;
    private Rigidbody rb;
    private Vector3 preVelocity;
    private Vector3 postVelocity;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(0, -thrust, 0, ForceMode.Force);
    }

    void FixedUpdate()
    {
        preVelocity = rb.velocity;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.Reflect(preVelocity, collision.contacts[0].normal);
        if (collision.gameObject.CompareTag("Brick")) {
            Destroy(collision.gameObject);
        }
    }    
}
