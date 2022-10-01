using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    private bool isActive;

    public void Initialize()
    {
        isActive = true;
        
        projectileBody.AddForce(transform.forward * 700f + transform.up * 300f);

    }

    void Update()
    {
        if (isActive)
        {
            //transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject);

    }


}
