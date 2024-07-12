using Godot;
using System;
using System.Diagnostics;

public partial class coin : Area2D
{
	private void _on_body_entered(Node2D body)
	{
		Debug.WriteLine("WoW~ 1 Coin!");
		QueueFree();
	}
}
