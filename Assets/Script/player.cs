using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rigidBody;
    public float force_axis, force_jump;
    bool jump;
    float ground_y;

    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        jump = true;
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(Vector3.forward * Input.GetAxis("Vertical") * force_axis * Time.deltaTime);
        rigidBody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * force_axis * Time.deltaTime);

        // jump
        if (rigidBody.position.y == ground_y)
            jump = true;
        if (Input.GetKey(KeyCode.Space) && jump == true)
        {
            rigidBody.AddForce(Vector2.up * force_jump);
            jump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // jump
        if (collision.gameObject.name == "ground")
            ground_y = rigidBody.position.y;

        // deadline
        if (collision.gameObject.name == "out")
            Application.LoadLevel(0);
    }
}