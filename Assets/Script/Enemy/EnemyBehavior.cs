using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Transform player;
    
    private Rigidbody2D _rigidbody2D;
    private EnemyData _enemyData;
    private float _enemySpeed;
    private float _enemyDamage;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _enemyData = GetComponent<EnemyData>();
    }
    
    private void OnEnable()
    {
        _enemySpeed = _enemyData.enemySpeed;
        _enemyDamage = _enemyData.enemyDamage;
    }

    private void Start()
    {
        player = GameManager.Instance.player.transform;
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
