using System.Collections.Generic;
using UnityEngine;

public class CoinsContainer : RandomSpawner
{

    [SerializeField]
    private int _countRandomCoins = 10;

    [SerializeField]
    private List<Coin> _coins = new List<Coin>();

    public int CoinsCount => _countRandomCoins;

    private void Awake()
    {

        CreateCoins();
    }

    public void CreateCoins()
    {
        var prefabsList = new List<IHavePrefab>(_coins);
        SpawnObject(prefabsList, _countRandomCoins);
    }

}
