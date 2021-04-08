using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private Rigidbody rb;
    private float translation;
    private float rotation;
    private Vector3 moveDir;
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, -0.2f, -2);
    }
    // Update is called once per frame
    void Update()
    {
         translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
         rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
         moveDir = transform.forward * translation;
        if(Input.GetAxis("Vertical") < 0.01 && Input.GetAxis("Vertical") > -0.01)
        {
            rb.velocity *= 0.99f;
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            rb.freezeRotation = true;
        }
        else{
            rb.freezeRotation = false;
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(moveDir , ForceMode.Force);
        rb.AddTorque(new Vector3(0, rotation, 0),ForceMode.Force);
    }
}