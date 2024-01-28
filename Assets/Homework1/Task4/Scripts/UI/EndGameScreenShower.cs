using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScreenShower : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _loseScreen;

    private void OnEnable()
    {
        WinObserver.GameWon += ShowWinScreen;
        WinObserver.GameLost += ShowLoseScreen;
    }

    private void OnDisable()
    {
        WinObserver.GameWon -= ShowWinScreen;
        WinObserver.GameLost -= ShowLoseScreen;
    }

    private void ShowWinScreen() => _winScreen.SetActive(true);

    private void ShowLoseScreen() => _loseScreen.SetActive(true);
}
