using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] private Transform weapon;
    
    private Transform target;
    
    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }
    
    void Update()
    {
        AimWeapon();
    }

    private void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
