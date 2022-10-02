using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  [SerializeField] private float maxHealth;
  private float currentHealth;

  void Start()
  {
	  currentHealth = maxHealth;
  }

  public void TakenDamage(float damage)
  {
	  currentHealth -= damage;

	  if (currentHealth <= 0)
	  {
		  gameObject.SetActive(false);
	  }
	  
  }


}
