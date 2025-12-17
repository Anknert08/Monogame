using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame
{
    public class SnowParticle
    {
        
        Texture2D texture;
        Vector2 position;
        int size = 1;
        float speed = 1;
        Vector2 drawPos;
        float time = 0;
        

        public SnowParticle(Texture2D texture, Vector2 position, int size)
        {
            this.texture = texture;
            this.position = position;
            this.size = size;

            speed = size/4f;
            time = new Random().Next(100000);
        }

        public void Update()
        {
            position.Y += speed;
            
            drawPos.Y = position.Y;
            drawPos.X = position.X = position.X +MathF.Sin(time) ;
            time += 1f/60f;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new(drawPos.ToPoint(), new Point(size, size));
            spriteBatch.Draw(texture, rec, Color.White);
        }

    }
}