using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounterUI : MonoBehaviour
{
    [SerializeField]
    private CoinsCounter _counter;
    [SerializeField]
    private TextMeshProUGUI _count;

    private void Awake()
    {
        if (_counter == null)
            _counter = FindObjectOfType<CoinsCounter>();

        _counter.OnCounterChangeEvent += ChangeValue;
    }

    private void ChangeValue(int value)
    {
        _count.text = value.ToString();
    }
    
}
