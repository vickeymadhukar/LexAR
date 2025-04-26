using UnityEngine;

public class StateManger : MonoBehaviour
{
    public static StateManger Instance;

    public bool LastCanvasActive = true;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
}
