using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    public bool isRightWall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.CompareTag("Ball") )
        {
            if(isRightWall)
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            else
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}
