public class ArmourSeller : ISeller
{
    public void Sell(Player player)
    {
        player.Trade("Cool armour");
    }
}