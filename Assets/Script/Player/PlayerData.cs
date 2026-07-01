using UnityEngine;

[System.Serializable]
public class PlayerData : MonoBehaviour 
{
    [SerializeField] private float _speed;
    [SerializeField] private float _healthPoint;
    [SerializeField] private float _dashingSpeed;
    [SerializeField] private float _dashDuration;
    [SerializeField] private float _dashCoolTime;
    
    public float HealthPoint
    {
        get => _healthPoint;
        set => _healthPoint = value;
    }

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public float DashingSpeed
    {
        get => _dashingSpeed;
        set => _dashingSpeed = value;
    }

    public float DashDuration
    {
        get => _dashDuration;
        set => _dashDuration = value;
    }

    public float DashCoolTime
    {
        get => _dashCoolTime;
        set => _dashCoolTime = value;
    }

    public PlayerData(float Speed, float HealthPoint, float DashingSpeed){
        _speed = Speed; 
        _healthPoint = HealthPoint;
        _dashingSpeed = Speed;
    }

}

