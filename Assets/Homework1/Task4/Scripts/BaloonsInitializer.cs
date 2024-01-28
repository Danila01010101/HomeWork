using UnityEngine;

public class BaloonsInitializer : MonoBehaviour
{
    [SerializeField] private BaloonParameters _firstTeamParameters;
    [SerializeField] private BaloonParameters _secondTeamParameters;
    [SerializeField] private Baloon[] _baloons;

    private void Awake()
    {
        SetUpBaalls();
    }

    private void SetUpBaalls()
    {
        foreach (Baloon ball in _baloons)
        {
            int randomTeamNumber = Random.Range(1, 3);

            if (randomTeamNumber == 1)
                ball.Initialize(_firstTeamParameters);
            else
                ball.Initialize(_secondTeamParameters);
        }
    }
}