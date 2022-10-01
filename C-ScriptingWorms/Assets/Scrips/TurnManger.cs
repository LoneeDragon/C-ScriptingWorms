using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManger : MonoBehaviour
{
   private static TurnManger instance;

   private int currentPlayerIndex;

   private void Awake()
   {
	   if (instance == null)
	   {
		   instance = this;
	   }
   }

   public bool IsItPlayerTurn(int index)
   {
	   return index == currentPlayerIndex;
   }

}
