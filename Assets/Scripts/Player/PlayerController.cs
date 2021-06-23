using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float limitLeft = -4.5f;
    public float limitRight = 4.5f;

    public float movementSpeed = 5.0f;

    private void Update()
    {
        float currentXPosition = Mathf.Clamp((
            transform.position.x + Input.GetAxis("Horizontal")
        ), limitLeft, limitRight);

        transform.position = Vector3.Lerp(transform.position,
        new Vector3(
            currentXPosition,
            transform.position.y,
            transform.position.z
            ),
        movementSpeed * Time.deltaTime
        );

        if (Input.GetKeyDown(KeyCode.W))
        {
            Time.timeScale = 1.5f;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Time.timeScale = 1.0f;
        }
    }
}
