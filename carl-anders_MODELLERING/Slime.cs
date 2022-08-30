public class Slime
{

    public int hp = 100;
    public string name = "Slime";
    public double x = 0;
    public double y = 0;
    public double z = 0;


    private double targetX;
    private double targetY;

    private double burrowX = 700;
    private double burrowY = 120;

    public void Update()
    {
        if (x > targetX) x--;
        if (x < targetX) x++;

        if (y > targetY) y--;
        if (y < targetY) y++;

        if (hp < 50)
        {
            targetX = burrowX;
            targetY = burrowY;
        }

        if (hp > 50)
        {
            targetX = 40;
            targetY = 40;
        }

        if (Math.Abs(x - targetX) < 4 && Math.Abs(y - targetY) < 4)
        {
            hp++;
        }
    }

}
