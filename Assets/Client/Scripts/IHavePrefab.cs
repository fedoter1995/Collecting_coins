using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHavePrefab : IHaveWeight
{
    GameObject GetPrefab();
}
