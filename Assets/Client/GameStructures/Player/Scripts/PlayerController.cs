using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float _speed = 2.0f;
    [SerializeField]
    private TrajectoryController _tController;

    private Camera cam;
    private List<ITrajectoryPoint> marks = new List<ITrajectoryPoint>();

    public bool isActive { get; set; } = true;
    public List<ITrajectoryPoint> Marks => marks;
    public GameObject Obj => gameObject;

    private void Awake()
    {
        var player = GetComponent<Player>();
        marks.Add(player);
        cam = Camera.main;

    }
    private void Update()
    {
        PlayerInputCheck();

        if (marks.Count > 1)
            PlayerMoveTo(marks[1].Obj.transform.position, _speed);
    }

    private void PlayerMoveTo(Vector3 target,float speed)
    {   
        if(isActive)       
            transform.position = Vector3.MoveTowards(transform.position,target, speed * 0.01f);

        if(transform.position == target)
        {
            var mark = marks[1];
            marks.Remove(mark);
            _tController.SetupLines(marks);
            Destroy(mark.Obj);
        }
    }
    private void PlayerInputCheck()
    {
        
        var res = Screen.currentResolution;
        if (Input.GetButtonDown("Fire1") && isActive)
        {
            var click = cam.ScreenToViewportPoint(Input.mousePosition);

            if (click.x >= 0 && click.x <= 1 && click.y >= 0 && click.y <= 1)
            {

                var position = cam.ScreenToWorldPoint(Input.mousePosition);
                    position = new Vector3(position.x, position.y, 0);

                var point = new GameObject("Click_Point").AddComponent<ClickPoint>();
                    point.transform.SetParent(FindObjectOfType<PointsContainer>().transform);
                    point.transform.position = position;
                    marks.Add(point);
                    _tController.SetupLines(marks);
            }
        }
    }
}
