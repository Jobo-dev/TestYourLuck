using UnityEngine;
using Managers;


public class ManagerVault : MonoBehaviour
{
    public static ManagerVault instance;
    
    internal GameStatusManager gameStatusManager;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        gameStatusManager = GameStatusManager.instance;
    }

}
