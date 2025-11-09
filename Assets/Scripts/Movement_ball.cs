using UnityEngine;

public class Movement_ball : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed;
    public float maxInitialAngel = 0.67f;
    public float startX = 0f;
    public float maxStartY = 4f;

    private void Start()
    {
        InitialPush();
    }

    private void InitialPush()
    {
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;

        dir.y = Random.Range(-maxInitialAngel, maxInitialAngel);
        rb2d.velocity = dir * speed;

    }
    private void ResetBall()
    {
        float posY = Random.Range(-maxStartY, maxStartY);
        Vector2 position = new Vector2(startX, posY);
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ZoneScore zoneScore = collision.GetComponent<ZoneScore>();
        if (zoneScore)
        {
            ResetBall();
            InitialPush();
        }
    }

}
