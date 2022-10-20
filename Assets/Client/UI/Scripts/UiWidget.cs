using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UiWidget : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        Hide();
    }
    public void Hide()
    {
        _canvasGroup.alpha = 0;
        _canvasGroup.interactable = false;
    }
    public void Show()
    {
        _canvasGroup.alpha = 1;
        _canvasGroup.interactable = true;
    }
}
