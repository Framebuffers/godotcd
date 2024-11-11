namespace Bios;
using Godot;

public static partial class MovementExtensions
{
  public static void CurvedPathTranslate(
      this Sprite3D sprite,
      float duration,
      float radius,
      //float delta,
      int points = 100)
  {
    Tween t = sprite.GetTree().CreateTween();
    t.BindNode(sprite);
    var startPoint = sprite.Position;
    Curve3D curve = new();
    for (int i = 0; i < points; i++)
    {
      $"Point added".ToConsole();
      // angle in radians
      float angle = 2 * Mathf.Pi * (i / (float)points);
      $"Angle: {angle}".ToConsole();

      Vector3 point = new Vector3(radius * Mathf.Cos(angle), 0, radius * Mathf.Sin(angle));
      $"Point: {point.X}, {point.Y}, {point.Z}".ToConsole();
      //      sprite.Translate(point);
      //curve.AddPoint(point);
    }

    foreach (var point in curve.GetBakedPoints())
    {
      t.TweenProperty(sprite, "position", point, duration);
    }
  }
}
