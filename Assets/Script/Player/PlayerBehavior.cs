using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private PlayerData playerData;
    public PlayerData PlayerData => playerData;
    private Rigidbody2D rigid;

    private void Awake()
    {
        playerData = GetComponent<PlayerData>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerData.HealthPoint = playerData.HealthPoint - other.GetComponent<EnemyBehavior>().GetEnemyDamage();
        Debug.Log(playerData.HealthPoint);
        if (playerData.HealthPoint <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HandleInput(float hValue, float vValue)
    {
        var position = transform.position;
        var posX = position.x + playerData.Speed * hValue * Time.deltaTime;
        var posY = position.y + playerData.Speed * vValue * Time.deltaTime;
        
        transform.position = new Vector3(posX, posY, 0);
    }

    public void Dash(Vector2 direction)
    {
        rigid.linearVelocity = direction.normalized * playerData.DashingSpeed;
    }
}