using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReallyStupidGame.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;

		// Animation representing the player
		public Texture2D PlayerTexture;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		// Amount of hit points that player has
		public int Health
		{
			get { return health; }
			set { health = value; }
		}

		// Get the width of the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerTexture.Height; }
		}

		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		public void Initialize(Texture2D texture, Vector2 position)
		{
			this.active = true;
			this.health = 100;
			this.score = 0;
			this.PlayerTexture = texture;
			this.Position = position;

		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}

	}
}

