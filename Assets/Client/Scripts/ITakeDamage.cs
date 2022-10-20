using System;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamage
{
    int HealthPoints { get; }

    void TakeDamage(int value);

}
