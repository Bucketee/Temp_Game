using UnityEngine;

[System.Serializable]
public class PlayerData {
    private float _speed;
    private float _healthPoint;
    
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

    public PlayerData(float Speed, float HealthPoint){
        _speed = Speed; 
        _healthPoint = HealthPoint; 
    }

}

