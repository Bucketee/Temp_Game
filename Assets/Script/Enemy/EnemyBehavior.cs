using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private Transform player; 
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _enemySpeed;
    [SerializeField] private float _enemyDamage; 

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        var fromPosition = transform.position;
        var toPosition = player.position;
        var velocity = _enemySpeed * (toPosition - fromPosition).normalized;
        _rigidbody2D.linearVelocity = velocity;
    }

    public float GetEnemyDamage()
    {
        return _enemyDamage; 
    }
}
