using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
