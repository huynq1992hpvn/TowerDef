using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ETower
{
    SingleTarget,
    MultiTarget

}

public class Tower : MonoBehaviour
{
    public TowerSO towerSO;
    public Transform ShotPos;
    public AttackComponemt attackComponent;
    private void Start()
    {
        attackComponent.Setup(towerSO.Dmg, towerSO.Cooldown, towerSO.RangeAttack, ShotPos);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(ShotPos.position, towerSO.RangeAttack);
    }
}
