using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;
    
    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(this.gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
}
