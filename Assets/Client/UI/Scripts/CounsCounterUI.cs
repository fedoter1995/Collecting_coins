using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class CounsCounterUI : MonoBehaviour
{
    [SerializeField]
    private CoinsCounter _counter;
    [SerializeField]
    private TextMeshProUGUI _count;

    private void Awake()
    {
        _counter.OnCounterChangeEvent += ChangeValue;
    }

    private void ChangeValue(int value)
    {
        _count.text = value.ToString();

    }
}
