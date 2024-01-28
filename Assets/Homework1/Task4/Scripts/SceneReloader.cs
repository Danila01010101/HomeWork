using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    [SerializeField] private float _reloadDelay = 5f;

    private void OnEnable()
    {
        WinObserver.GameLost += ReloadAfterGameOver;
        WinObserver.GameWon += ReloadAfterGameOver;
    }

    private void OnDisable()
    {
        WinObserver.GameLost -= ReloadAfterGameOver;
        WinObserver.GameWon -= ReloadAfterGameOver;
    }

    private void ReloadAfterGameOver()
    {
        StartCoroutine(ReloadWithDelay());
    }

    private IEnumerator ReloadWithDelay()
    {
        yield return new WaitForSeconds(_reloadDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}