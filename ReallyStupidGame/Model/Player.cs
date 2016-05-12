using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReallyStupidGame.View;

namespace ReallyStupidGame.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;
		private Animation playerAnimation;

		// Animation representing the player
		public Animation PlayerAnimation
		{
			get { return playerAnimation; }
			set { playerAnimation = value; }
		}

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
			get { return PlayerAnimation.FrameWidth; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerAnimation.FrameHeight; }
		}

		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		//public void Initialize(Texture2D texture, Vector2 position)
		//{
		//	this.active = true;
		//	this.health = 100;
		//	this.score = 0;
		//	this.PlayerTexture = texture;
		//	this.Position = position;
		//
		//}

		// Initialize the player
		public void Initialize(Animation animation, Vector2 position)
		{
			this.PlayerAnimation = animation;

			// Set the starting position of the player around the middle of the screen and to the back
			this.Position = position;

			// Set the player to be active
			this.Active = true;

			// Set the player health
			this.Health = 100;

			this.score = 0;
		}

		// Update the player animation
		public void Update(GameTime gameTime)
		{
			PlayerAnimation.Position = Position;
			PlayerAnimation.Update(gameTime);
		}

		// Draw the player
		public void Draw(SpriteBatch spriteBatch)
		{
			PlayerAnimation.Draw(spriteBatch);
		}

	}
}

