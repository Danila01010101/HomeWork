public class FruitSeller : ISeller
{
    public void Sell(Player player)
    {
        player.Trade("Awesome fruit");
    }
}