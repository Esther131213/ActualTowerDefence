using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace ActualTowerDefence
{
    public class Game1 : Game
    {
        public int TotalMoney = 0;
        private List<BasicEnemy> basiclist = new List<BasicEnemy>();
        public Rectangle EnemyHitbox;
        private BasicTowerClass basicTowerClass;
        int position;
        int i;

        int BasicEnemyAmount = 1;

        Random rnd = new Random();
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Initialize enemy hitbox explicitly

            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            AssetManager.LoadTextures(Content);
            // basiclist already initialized at declaration
            CreateEnemy(1);
            // TODO: use this.Content to load your game content here
        }

        public void CreateEnemy(int position)
        {
            if (position == 1)
            {
                var enemy = new BasicEnemy(1f, 10, 10, new Vector2(0, 100));
                basiclist.Add(enemy);
            }
            else if (position == 2)
            {

            }
        }

        //The Waves ---------------------------------------------------------------------
        public void Wave1()
        {


        }

        public void Wave2()
        {

        }

        //Update ------------------------------------------------------------------------
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (BasicEnemyAmount > 0)
            {
                CreateEnemy(1);
                BasicEnemyAmount--;
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
            
            foreach (BasicEnemy enemy in basiclist)
            {
                enemy.Update(gameTime);
            }
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            //spriteBatch.Draw(AssetManager.towerTex1, new Vector2(0,0), Color.White);
            foreach (BasicEnemy enemy in basiclist)
            {
                enemy.Draw(spriteBatch); // fixed: call instance being iterated
            }
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
