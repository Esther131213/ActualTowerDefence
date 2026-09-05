using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Threading;

namespace ActualTowerDefence
{
    internal class BasicTowerClass
    {
        private int towerCost1 = 10;
        private int towerCost2 = 20;
        private int towerCost3 = 30;
        private int towerDmg;
        private int towerRange;
        private int towerLevel;
        public Rectangle hitbox;
        Texture2D towerTex;

        //Timer
        GameTime gameTime;
        private double delay = 1.0;
        private bool completed = false;

        public BasicTowerClass(Rectangle position, int towerCost)
        {
            towerCost = towerCost1;
        }

        public void Update()
        {
            if (!completed)
            {
                delay -= gameTime.ElapsedGameTime.TotalSeconds;

                if (delay <= 0)
                {
                    completed = true;
                    Hit();
                }
            }
        }

        public void Hit()
        {
            if (towerLevel == 1)
            {
                Debug.WriteLine("Hitting");

            }
            else if (towerLevel == 2)
            {

            }
            else
            {

            }
        }

        public void Upgrade(int CurrentMoney)
        {
            if (towerLevel == 1 && CurrentMoney >= towerCost2)
            {
                towerTex = AssetManager.towerTex2;
                towerLevel = 2;
            }
            else if (towerLevel == 2 && CurrentMoney >= towerCost3)
            {
                towerTex = AssetManager.towerTex3;
                towerLevel = 3;
            }
        }
    }
}
