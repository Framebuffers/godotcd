namespace Bios.Logos;
using Godot;

public static partial class LogoExtensions
{
  // 20241105-2048 => gonna try if it works better if I do it directly on the sprite?
  public static void TranslationCurve(
      this Sprite3D sprite,
      float duration,
      float radius,
      int points = 100)
  {
    var r = sprite.GlobalPosition;


    //r.Lerp()
  }
}
