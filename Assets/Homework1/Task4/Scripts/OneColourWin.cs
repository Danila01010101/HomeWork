using System.Linq;
using System.Collections.Generic;

public class OneColourWin : IWinIndentifier
{
    private List<Baloon> _baloons;
    private Enums.BaloonType _winType;
    private bool _isTypeSelected = false;

    public Enums.GameState CheckWinningCondition(Baloon burstedBaloon)
    {
        _baloons.Remove(burstedBaloon);

        if (_baloons.Count == 0)
        {
            return Enums.GameState.Win;
        }

        if (_isTypeSelected == false)
        {
            _winType = burstedBaloon.Type;
            _isTypeSelected = true;
            return Enums.GameState.Continue;
        }

        if (burstedBaloon.Type != _winType)
        {
            return Enums.GameState.Lose;
        }

        int baloonsToBurstAmount = _baloons.Where(baloon => baloon.Type == _winType).Count();

        if (baloonsToBurstAmount == 0)
        {
            return Enums.GameState.Win;
        }

        return Enums.GameState.Continue;
    }

    public OneColourWin(List<Baloon> existingBaloons)
    {
        _baloons = new List<Baloon>(existingBaloons);
    }
}
