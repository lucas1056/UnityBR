using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
    public float jumpSpeed = 100.0f;
    private bool onGround = false;
    Rigidbody rb;
    float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.001f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.001f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.001f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.001f, 0f, 0f);
        }

        float amountToMove = movementSpeed * Time.deltaTime;
        Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * amountToMove) + (Input.GetAxis("Vertical") * Vector3.forward * amountToMove);
        rb.AddForce(movement, ForceMode.Force);

        if (Input.GetKey(KeyCode.Space) & onGround == true)
        {
            onGround = false;
            rb.AddForce(Vector3.up * jumpSpeed);

        }
    }
        void OnCollisionStay()
        {
            onGround = true;
        }
}
