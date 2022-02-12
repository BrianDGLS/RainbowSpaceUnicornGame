using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float jumpHeight = 5;
    public float gravity = -9.8f;

    private void Update()
    {
        if (ShouldJump())
        {
            direction = Vector3.up * jumpHeight;
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private bool ShouldJump()
    {
        bool leftMouseClicked = Input.GetMouseButtonDown(0);
        bool spaceBarPressed = Input.GetKeyDown(KeyCode.Space);
        bool touchTriggered = Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
        return leftMouseClicked || spaceBarPressed || touchTriggered;
    }
}
