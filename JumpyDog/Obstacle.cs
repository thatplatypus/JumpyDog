using SkiaSharp;

namespace JumpyDog;

public class Obstacle
{
    public SKRect Top { get; set; }
    public SKRect Bottom { get; set; }
    public bool Scored { get; set; } = false; // Default to not scored

    public Obstacle(SKRect top, SKRect bottom)
    {
        Top = top;
        Bottom = bottom;
    }

    public void Move(float deltaX)
    {
        Top = Top with { Right = Top.Right + deltaX, Left = Top.Left + deltaX };

        Bottom = Bottom with { Right = Bottom.Right + deltaX, Left = Bottom.Left + deltaX };
    }

    public bool IsOffScreen()
    {
        return Top.Right < 0;
    }
}