using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public enum EEnemy
{
    Normal,
    Boss,
}
public class Enemy : MonoBehaviour
{
    public EnemySO enemySO;
    public MoveComponent movement;
    private void Start()
    {
        StartMove();
    }
   
    private void StartMove()
    {
        movement.Set(enemySO.Speed);
    }
    private void EnemyGotAttacked()
    {
        enemySO.HP -= 1;
    }

}
