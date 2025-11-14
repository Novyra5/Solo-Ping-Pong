using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer, scoreEnemy;
    public ScoreText score_RIGHT, score_LEFT;

    public void OneScoreZoneREached(int id)
    {
        if (id == 1)
            scoreEnemy++;

        if (id == 2)
            scorePlayer++;
        UpdateScores();
    }

    private void UpdateScores()
    {
        score_LEFT.SetScore(scorePlayer);
        score_RIGHT.SetScore(scoreEnemy);
    }
}
