namespace Main.Question3_2;

public class Ball
{
    public int Size { get; set; }
    public Color BallColor { get; set; }
    
    public int ThrowCnt { get; set; }

    private int State = 1; // 1 -> never poped, 0 -> poped
    
    public Ball(int size, Color ballColor)
    {
        Size = size;
        BallColor = ballColor;
        ThrowCnt = 0;
    }

    public void Pop()
    {
        Size = 0;
        State = 0;
    }
    
    public void Throw()
    {
        if (State == 1)
        {
            ThrowCnt++;
        }
    }

    public int Count()
    {
        return ThrowCnt;
    }
}