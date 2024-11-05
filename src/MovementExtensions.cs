namespace Bios;
using Godot;

public static partial class MovementExtensions
{
  public static void CurvedPathTranslate(
      this Sprite3D sprite,
      float duration,
      float radius,
      int points = 100)
  {

    Curve3D curve = new();
    for (int i = 0; i < points; i++)
    {
      $"Point added".ToConsole();
      // angle in radians
      float angle = 2 * Mathf.Pi * (i / (float)points);
      $"Angle: {angle}".ToConsole();
      Vector3 point = new Vector3(radius * Mathf.Cos(angle), 0, radius * Mathf.Sin(angle));
      $"Point: {point.X}, {point.Y}, {point.Z}".ToConsole();
      curve.AddPoint(point);
      sprite.Position.Lerp(point, duration);
    }

    foreach (var point in curve.GetBakedPoints())
    {
      $"Inside loop: {point}".ToConsole();
    }
  }
}
