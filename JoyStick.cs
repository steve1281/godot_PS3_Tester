using Godot;
using System;

public partial class JoyStick : Node2D
{
    [Export] public Label label { set; get; }

    protected Vector2 v;
    protected Vector2 origin = new Vector2(0,0); //(530, 310);
    protected Vector2 p = new Vector2();

    public Vector2 ConvertToCartDeg(double angleDeg, double distance)
    {
        double angleRad = Mathf.DegToRad(angleDeg);
        double x = distance * Mathf.Cos(angleRad);
        double y = distance * Mathf.Sin(angleRad);
        return new Vector2((float)x, (float)y);
    }
    public Vector2 ConvertToCartRad(double angleRad, double distance)
    {
        double x = distance * Mathf.Cos(angleRad);
        double y = distance * Mathf.Sin(angleRad);
        return new Vector2((float)x, (float)y);
    }

    public Vector2 ConvertToPolar(double x, double y)
    {
        double angle = Mathf.Atan2(y, x);
        double distance = Math.Sqrt(x * x + y * y);
        return new Vector2((float)distance, (float)angle);
    }

    public void FixDrawLine(Vector2 origin, Vector2 p, Color c, float w)
    {
        p.Y *= -1;
        p.Y += origin.Y;
        p.X += origin.X;
        DrawLine(origin, p, c, w);

    }

    public override void _Draw()
    {

        // draw a circle, in godot blue
        Color godotBlue = new Color("478cbf");
        DrawCircle(origin, 200, godotBlue);

        // draw an axis
        p = ConvertToCartDeg(0, 200);
        FixDrawLine(origin, p, Colors.Aquamarine, 1.0f);
        p = ConvertToCartDeg(90, 200);
        FixDrawLine(origin, p, Colors.Aquamarine, 1.0f);
        p = ConvertToCartDeg(180, 200);
        FixDrawLine(origin, p, Colors.Aquamarine, 1.0f);
        p = ConvertToCartDeg(270, 200);
        FixDrawLine(origin, p, Colors.Aquamarine, 1.0f);


        // interpret the velocity vector, and plot
        if (!(v.X == 0 && v.Y == 0))
        {
            Vector2 pol = ConvertToPolar(v.X, -v.Y);
            p = ConvertToCartRad(pol.Y, 200);
            FixDrawLine(origin, p, Colors.WebMaroon, 5.0f);
        }

    }


}
