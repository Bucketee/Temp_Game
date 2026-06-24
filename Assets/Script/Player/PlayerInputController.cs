using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private PlayerBehaviour _playerBehaviour;
    
    private Vector2 _inputVector = Vector2.zero;

    private void Awake()
    {
        _playerBehaviour = GetComponent<PlayerBehaviour>();
    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            _inputVector = context.ReadValue<Vector2>();
        }
        else if(context.phase == InputActionPhase.Canceled)
        {
            _inputVector = Vector2.zero;
        }
    }

    private void Update()
    {
        _playerBehaviour.HandleInput(_inputVector.x, _inputVector.y);
    }
}