using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // Controls player movement with WASD 
	}
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed); // Go forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed); // Go backwards
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed); // Strafe right
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed); // Strafe left
        }
    }
}
