namespace Bios;

using Godot;

public static class GodotExtensions
{
  public static void ToConsole(this string s) => GD.Print(s);
}
