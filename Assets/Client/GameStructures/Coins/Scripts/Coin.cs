using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour, IHavePrefab
{
    [SerializeField]
    private int _price = 1;
    [SerializeField]
    private GameObject _prefab;


    public int Price => _price;
    public int Weight => _price;

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public GameObject GetPrefab()
    {
        return _prefab;
    }
}
