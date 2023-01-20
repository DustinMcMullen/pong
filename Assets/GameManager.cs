using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 1")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public Text player1Text;
    public Text player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        player1Text.text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        player2Text.text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<BallBehavior>().Reset();
        player1Paddle.GetComponent<PaddleBehavior>().Reset();
        player2Paddle.GetComponent<PaddleBehavior>().Reset();
    }
}
