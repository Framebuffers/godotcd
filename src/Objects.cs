using Godot;
using System;

// Manages base behaviour of logos.
public partial class Objects : Node3D
{
  private Sprite3D _companyLogo;
  private Sprite3D _textLogo;

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {
    _companyLogo = GetNode<Sprite3D>("GodotLogo");
    _textLogo = GetNode<Sprite3D>("GameEngineLogo");
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta)
  {

  }
}
