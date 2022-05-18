using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 move;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + move.x,-3,3), Mathf.Clamp(transform.position.y + move.y, -3, 3), 0); 
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
}
