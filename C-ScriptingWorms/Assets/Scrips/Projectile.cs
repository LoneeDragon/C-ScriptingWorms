using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private float weaponDamage;
    [SerializeField] private float damage= 20f;
    
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
    

    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerHealth PlayerH=other.transform.GetComponent<PlayerHealth>();

            if(PlayerH == null)
            {
                Debug.Log("PlayerHealth SCRIPT IS MISSING FROM THE PLAYER");

                return;
            }

            PlayerH.TakeDamage(damage);
            Destroy(gameObject);

        }
    }

}
