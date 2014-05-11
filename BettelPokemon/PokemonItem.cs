using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
namespace Pokemon_Trouble
{
   public class PokemonItem
    {
        public int X = 100;
        public int Y = 100;
        protected Image img=null;
        public Rectangle ImageBounds = new Rectangle(0, 0, 10, 10);
        public Rectangle MovingBounds = new Rectangle();
        public PokemonItem()
        {
            img = null;
        }
        public PokemonItem(string fileName)
        {
            img = Image.FromFile(fileName);
            ImageBounds.Width = img.Width;
            ImageBounds.Height = img.Height;
        } 
        public int Width
        {
            get
            {
                return ImageBounds.Width;
            }
        } 
        public int Height
        {
            get
            {
                return ImageBounds.Height;
            }
        }
        public virtual Rectangle GetBounds()
        {
            return MovingBounds;
        }
        public void UpdateBounds()
        {
            MovingBounds = ImageBounds;
            MovingBounds.Offset(X, Y);
        }
        public virtual void Draw(Graphics g)
        {
            UpdateBounds();
            g.DrawImage(img, MovingBounds, 0, 0, ImageBounds.Width, ImageBounds.Height, GraphicsUnit.Pixel);
        }
    }
}