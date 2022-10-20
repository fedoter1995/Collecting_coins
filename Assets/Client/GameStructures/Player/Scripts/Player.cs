using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,ITrajectoryPoint, ITakeDamage
{

    [SerializeField]
    private int _health = 1;
    [SerializeField]
    private PlayerController _controller;
    [SerializeField]
    private CoinsCounter _counter;
    public GameObject Obj => gameObject;

    public event Action OnLoseEvent;
    public event Action OnWinEvent;
    public int HealthPoints => _health;

    private void Awake()
    {
        _counter.LackOfCoinsEvent += OnWin;
    }
    public void TakeDamage(int value)
    {
        _health -= value;
        if (_health <= 0)
        {
            _controller.isActive = false;
            OnLoseEvent?.Invoke();
        }
    }
    private void OnWin()
    {
        _controller.isActive = false;
        OnWinEvent?.Invoke();
    }
}
