// RustySpoon.cs
//Using declarations
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReallyStupidGame
{
	public class RustySpoon
	{
		private Texture2D texture;
		private int damage;
		private float rustySpoonSpeed;
		private Vector2 position;

		public Texture2D Texture
		{
			get { return texture; }
			set { texture = value; }
		}

		public int Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public float RustySpoonSpeed
		{
			get { return rustySpoonSpeed; }
			set { rustySpoonSpeed = value; }
		}

		public Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}

		public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
		{
			this.texture = texture;
			this.position = position;
			this.damage = 5;
			this.rustySpoonSpeed = .2;
		}

		public void Update()
		{
			Position.X += rustySpoonSpeed;
			Position.Y += .25;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Texture, Position, null, Color.White, position.Y*3, Vector2.Zero, 0f);
		}

		public RustySpoon ()
		{
			
		}
	}
}

