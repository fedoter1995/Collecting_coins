using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryController : MonoBehaviour
{
    [SerializeField] 
    private LineRenderer _lrenderer;

    private List<ITrajectoryPoint> points = new List<ITrajectoryPoint>();


    private void Update()
    {
        DrawLine();
    }

    public void SetupLines(List<ITrajectoryPoint> points)
    {
        this.points = new List<ITrajectoryPoint>(points);
        _lrenderer.positionCount = this.points.Count;
    }

    private void DrawLine()
    {
        for(int i = 0; i < points.Count; i++)
        {
            _lrenderer.SetPosition(i, points[i].Obj.transform.position);
        }
    }
}
