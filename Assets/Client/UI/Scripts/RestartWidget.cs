using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartWidget : UiWidget
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private TextMeshProUGUI _inscription;
    [SerializeField]
    private Player _player;



    private void Awake()
    {
        if (_player == null)
            _player = FindObjectOfType<Player>();

        _player.OnLoseEvent += OnLose;
        _player.OnWinEvent += OnWin;
        _button.onClick.AddListener(RestartGame);

        Hide();
    }

    private void OnWin()
    {
        _inscription.text = "Победа";
        Show();
    }
    private void OnLose()
    {
        _inscription.text = "Поражение";
        Show();
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
