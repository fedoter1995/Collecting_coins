using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D),typeof(Rigidbody2D))]
public class CoinsCounter : MonoBehaviour
{
    private int coins = 0;

    public event Action<int> OnCounterChangeEvent;
    public event Action LackOfCoinsEvent;
    private void Start()
    {
        OnCounterChangeEvent?.Invoke(coins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var coin = collision.GetComponent<Coin>();

        if (coin != null)
        {
            coins += coin.Price;
            coin.Destroy();
            OnCounterChangeEvent?.Invoke(coins);
            CheckCoins();
        }
    }
    private void CheckCoins()
    {
        var coins = FindObjectsOfType<Coin>();
        
        if (coins.Length < 2)
        {
            LackOfCoinsEvent?.Invoke();
        }

    }

}
