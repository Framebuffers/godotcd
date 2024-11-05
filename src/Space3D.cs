namespace Bios;

using Godot;
using System;

// Manages base behaviour of logos.
public partial class Space3D : Node3D
{
  private Sprite3D _companyLogo;
  private Sprite3D _textLogo;

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {
    _companyLogo = GetNode<Sprite3D>("Objects/GodotLogo");
    _textLogo = GetNode<Sprite3D>("Objects/GameEngineLogo");
    //Movement.CurvedPathTranslate(_companyLogo, 5.0f, 3.0f);
    _companyLogo.CurvedPathTranslate(0.01f, 30.0f);
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta)
  {

  }

}
