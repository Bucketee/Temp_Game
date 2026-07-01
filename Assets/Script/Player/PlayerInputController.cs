using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private PlayerBehaviour _playerBehaviour;
    private PlayerData _playerData;
    
    private Vector2 _inputVector = Vector2.zero;

    [SerializeField] private bool isDashable = true;

    private void Awake()
    {
        _playerBehaviour = GetComponent<PlayerBehaviour>();
        _playerData = GetComponent<PlayerData>();
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

    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (isDashable)
            {
                StartCoroutine(DashCoroutine());
            }
        }
    }

    private IEnumerator DashCoroutine()
    {
        // 방향이 없으면 대쉬 취소
        if (_inputVector.magnitude == 0) yield break;
        
        isDashable = false;
        _playerBehaviour.Dash(_inputVector * _playerData.DashingSpeed);
        yield return new WaitForSeconds(_playerData.DashDuration);
        _playerBehaviour.Dash(Vector2.zero);
        yield return new WaitForSeconds(_playerData.DashCoolTime);
        isDashable = true;
    }

    private void Update()
    {
        _playerBehaviour.HandleInput(_inputVector.x, _inputVector.y);
    }
}