using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> ListPosition;
    public List<Vector3> GetListPosition()
    {
        List<Vector3> position = new List<Vector3>();
        for (int i = 0; i < ListPosition.Count; i++)
        {
            position.Add(ListPosition[i].position);
        }
        return position;
    }
    public void OnDrawGizmos()
    {
        for (int i = 0; i < ListPosition.Count - 1; i++)
        {
            Gizmos.DrawLine(ListPosition[i].position, ListPosition[i+1].position);
        }
    }
}
