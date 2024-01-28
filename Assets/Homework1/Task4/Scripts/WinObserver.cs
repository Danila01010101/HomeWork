using System;
using System.Collections.Generic;
using UnityEngine;

public class WinObserver : MonoBehaviour
{
    public static Action GameWon;
    public static Action GameLost;

    [SerializeField] private List<Baloon> _baloons;

    private IWinIndentifier _indentifier;
    private bool _isGameOver = false;

    private void Initialize(IWinIndentifier indentifier)
    {
        _indentifier = indentifier;
    }

    private void OnEnable()
    {
        Baloon.BaloonBurst += CheckWin;
    }

    private void OnDisable()
    {
        Baloon.BaloonBurst -= CheckWin;
    }

    public void ChooseOneColourMode()
    {
        Initialize(new OneColourWin(_baloons));
    }

    public void ChooseNoBaloonsMode()
    {
        Initialize(new NoBaloonsWin(_baloons));
    }

    private void CheckWin(Baloon burstedBaloon)
    {
        if (_isGameOver) return;

        _baloons.Remove(burstedBaloon);

        switch (_indentifier.CheckWinningCondition(burstedBaloon))
        {
            case Enums.GameState.Lose:
                _isGameOver = true;
                GameLost?.Invoke();
                break;

            case Enums.GameState.Win:
                _isGameOver = true;
                GameWon?.Invoke();
                break;
        }
    }
}
