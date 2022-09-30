using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody characterBody;
    public float speed;
    public float rotationSpeed;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
        {
            Jump();
        }
    }
    private void Jump()
    {
        
        characterBody.AddForce(Vector3.up * 200f);
    }

    private bool IsTouchingFloor()
    {
        RaycastHit hit;
        
        bool result = Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
        return result;
    }
}