using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAttackEnemy : MonoBehaviour
{
    public Enemy enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow"))
        {
            enemy.EnemyGotAttacked();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            attackComponent.SetTarget(collision.transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            attackComponent.SetTarget(null);
        }
    }
}
