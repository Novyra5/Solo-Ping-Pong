using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreText score_RIGHT, score_LEFT;
    public PlayerMove player;
    public EnemyAI enemy;
    public Movement_ball ball;

    public int scorePlayer, scoreEnemy;
    
    public float speedUP = 1.1f;

    public void OneScoreZoneREached(int id)
    {
        switch (id)
        {
            case 1:
                scoreEnemy++;
                break;
            case 2:
                scorePlayer++;
                break;

        }
        UpdateScores();
        SpeedUp();
    }

    private void UpdateScores()
    {
        score_LEFT.SetScore(scorePlayer);
        score_RIGHT.SetScore(scoreEnemy);
    }

    private void SpeedUp()
    {
        if (scoreEnemy + scorePlayer < 10)
        {
            player.speed ++;
            enemy.speed ++;
            ball.speed ++;
        }
    }
}
