using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Monogame
{
    public class SnowSystem
    {
      List<SnowParticle> particles = new();
      Texture2D texture;
      Random random = new();

      public SnowSystem(Texture2D t) => texture = t;

      public void Update()
        {
            float xPos = random.Next(0,801);
            int size = random.Next(1,10);
            particles.Add(new SnowParticle(texture, new Vector2(xPos,0), size));
            foreach (var p in particles)
            {
                p.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var p in particles)
            {
                p.Draw(spriteBatch);
            }

            spriteBatch.End();
        }
      
    }
}