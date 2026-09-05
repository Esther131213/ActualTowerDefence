using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace ActualTowerDefence
{
    internal class BasicEnemy
    {
        float speed;
        int attackDmg;
        int health;
        public Vector2 position;
        public Rectangle hitbox;

        public BasicEnemy(float speed, int attackDmg, int health, Vector2 position)
        {
            hitbox = new Rectangle((int)position.X, (int)position.Y, AssetManager.towerTex1.Width, AssetManager.towerTex1.Height);
            this.speed = speed;
            this.attackDmg = attackDmg;
            this.health = health;
            this.position = position;
        }

        public void Update(GameTime gameitme)
        {
            hitbox.X = (int)position.X;
            hitbox.Y = (int)position.Y;
            if (health > 0)
            {
                position.X += speed;
            }
            else
            {

            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.towerTex1, hitbox, Color.White);
            spriteBatch.DrawString(AssetManager.font, health.ToString(), new Vector2(hitbox.X + hitbox.Width / 3, hitbox.Y - 20), Color.Red);
        }
    }
}
