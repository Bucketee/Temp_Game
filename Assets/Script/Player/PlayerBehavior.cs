using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private PlayerData player;

    private void Awake()
    {
        player = new PlayerData(20, 100); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.HealthPoint = player.HealthPoint - other.GetComponent<EnemyBehavior>().GetEnemyDamage();
        Debug.Log(player.HealthPoint);
        if (player.HealthPoint <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HandleInput(float hValue, float vValue)
    {
        var position = transform.position;
        var posX = position.x + player.Speed * hValue * Time.deltaTime;
        var posY = position.y + player.Speed * vValue * Time.deltaTime;
        
        transform.position = new Vector3(posX, posY, 0);
    }
}