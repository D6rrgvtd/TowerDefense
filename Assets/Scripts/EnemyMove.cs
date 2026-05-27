using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform[] points;
    public float speed = 2f;

    int index = 0;

    void Update()
    {
        if (index >= points.Length) return;

        Transform target = points[index];

        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            index++;
        }
    }
}