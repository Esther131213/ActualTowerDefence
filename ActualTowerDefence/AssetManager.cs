using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace ActualTowerDefence
{
    internal class AssetManager
    {
        //Towers
        public static Texture2D towerTex1;
        public static Texture2D towerTex2;
        public static Texture2D towerTex3;
        public static SpriteFont font;
        public static void LoadTextures(ContentManager content)
        {
            towerTex1 = content.Load<Texture2D>("2");
            towerTex2 = content.Load<Texture2D>("5");
            towerTex3 = content.Load<Texture2D>("7");
            font = content.Load<SpriteFont>("Font");
        }
    }
}

