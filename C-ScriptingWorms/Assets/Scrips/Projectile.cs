using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private float weaponDamage;
    
    private bool isActive;

    public void Initialize(Vector3 direction)
    {
        isActive = true;
        
        projectileBody.AddForce(direction);

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
//PlayerHealth playerHealth = result.collider.GetComponent<PlayerHealth>();
       //(playerHealth != null)
       {
       //    playerHealth.TakenDamage(weaponDamage);
       }
        Destroy(gameObject);
    }

}
