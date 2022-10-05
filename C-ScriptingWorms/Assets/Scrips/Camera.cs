using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private bool turn;
    private GameObject turnManager;
    private GameObject player1;
    private GameObject player2;
 

    // Update is called once per frame
    void Update()
    {
        player1 = GameObject.Find("Player One");
        player2 = GameObject.Find("Player Two");

        turnManager = GameObject.Find("TurnManager");
        TurnManager currentTurn = turnManager.GetComponent<TurnManager>();
        if (currentTurn.currentPlayerIndex == 1)
        {
            turn = true;

        }
        else if (currentTurn.currentPlayerIndex == 2)
        {
            turn = false;

        }


        if (turn == true)
        {
            transform.position = new Vector3(player1.transform.position.x, player1.transform.position.y + 5, player1.transform.position.z - 6);
            transform.LookAt(player1.transform.position);
        }
        else if (turn == false)
        {

            transform.position = new Vector3(player2.transform.position.x, player2.transform.position.y + 5, player2.transform.position.z - 6);
            transform.LookAt(player2.transform.position);
        }
    }
}