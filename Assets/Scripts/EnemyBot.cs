using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyAI : MonoBehaviour
{
   public Transform ball;
   public Rigidbody2D enemyPaddle;
   public float speed = 2;

    private void Update()
    {
        float posBall = PositionTracked();
        MoveBot(posBall);
        
    }
    private float PositionTracked()
    {
        return ball.position.y;
    }

    private void MoveBot(float posBall)
    {
        Vector2 curentPos = enemyPaddle.position;
        Vector2 targetPos = new Vector2 (curentPos.x, posBall);

        Vector2 newPos = Vector2.MoveTowards(curentPos, targetPos, speed * Time.deltaTime);

        enemyPaddle.MovePosition(newPos);
        
    }


}
