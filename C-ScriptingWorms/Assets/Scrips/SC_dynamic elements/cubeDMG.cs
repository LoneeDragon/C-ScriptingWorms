using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDMG : MonoBehaviour
{
    [SerializeField] private float damage= 20f;


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
