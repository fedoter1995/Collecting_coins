using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RandomSpawner : MonoBehaviour
{
    private Camera mainCamera;
    protected void SpawnObject(List<IHavePrefab> items, int count)
    {
        int maxPrice = GetMaxWeight(items);
        for (int i = 0; i < count; i++)
        {
            var items_b = new List<IHavePrefab>();
            var randomValue = Random.Range(1, maxPrice + 1);

            foreach (Coin coin in items)
            {
                if (randomValue >= coin.Price)
                    items_b.Add(coin);
            }

            var maxWeightItems = ItemsWidthMaxWeight(items_b);
            randomValue = Random.Range(0, maxWeightItems.Count);

            for (int j = 0; j < maxWeightItems.Count; j++)
            {
                if (j == randomValue)
                {
                    var obj = Instantiate(maxWeightItems[j].GetPrefab(), transform);
                    obj.transform.position = GetRandomPosition();
                }

            }

        }
    }
    private int GetMaxWeight(List<IHavePrefab> items)
    {
        int maxWeight = 0;
        foreach (IHavePrefab item in items)
        {
            if (item.Weight > maxWeight)
                maxWeight = item.Weight;
        }

        return maxWeight;
    }

    private List<IHavePrefab> ItemsWidthMaxWeight(List<IHavePrefab> items)
    {
        int maxWeight = GetMaxWeight(items);
        var items_b = new List<IHavePrefab>();
        foreach (IHavePrefab item in items)
        {
            if (item.Weight == maxWeight)
                items_b.Add(item);
        }
        return items_b;
    }

    private Vector3 GetRandomPosition()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;


        int x = Random.Range(0, Screen.width);
        int y = Random.Range(0, Screen.height);
        int z = 0;

        var pos = new Vector3(x, y, z);

        pos = mainCamera.ScreenToWorldPoint(pos);

        return new Vector3(pos.x, pos.y, 0);
    }
}
