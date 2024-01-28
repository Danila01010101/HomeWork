using System.Collections.Generic;

public class NoBaloonsWin : IWinIndentifier
{
    private List<Baloon> _baloons;

    public Enums.GameState CheckWinningCondition(Baloon burstedBaloon)
    {
        _baloons.Remove(burstedBaloon);

        if (_baloons.Count == 0) return Enums.GameState.Win;

        return Enums.GameState.Continue;
    }

    public NoBaloonsWin(List<Baloon> existingBaloons)
    {
        _baloons = new List<Baloon>(existingBaloons);
    }
}
