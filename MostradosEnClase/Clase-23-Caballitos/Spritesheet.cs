using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Caballitos
{
    public class Spritesheet
    {
        //w: 50px h: 96px
        Bitmap sheet;
        int fWidth, fHeight;
        int framesPerRow, framesPerCol;
        //int x, y;
        public Bitmap curState;

        public Spritesheet(string path, int width, int height)
            : this (new Bitmap(path), width, height)
        {
        }

        public Spritesheet(Image imagen, int width, int height)
            : this(new Bitmap(imagen), width, height)
        {
        }

        public Spritesheet(Bitmap bitmap, int width, int height)
        {
            sheet = bitmap;
            fWidth = width;
            fHeight = height;
            framesPerRow = sheet.Width / fWidth;
            framesPerCol = sheet.Height / fHeight;

            Rectangle cloneRect = new Rectangle(0 * fWidth, 1 * fHeight, fWidth, fHeight);
            curState = this.sheet.Clone(cloneRect, this.sheet.PixelFormat);
        }

        int curFrame = 0;
        int curRow = 0;
        int count = 0;
        public void playSprite(int frameSpeed, int endFrame, int endRow)
        {
            bool play = true;

            while (play)
            {
                if (count == (frameSpeed - 1))
                {
                    curFrame = (curFrame+1) % endFrame;
                    if (curFrame == 0)
                        curRow = (curRow + 1) % endRow;
                    Rectangle cloneRect = new Rectangle(curFrame * fWidth, curRow * fHeight, fWidth, fHeight);
                    System.Drawing.Imaging.PixelFormat pFormat = sheet.PixelFormat;
                    curState = sheet.Clone(cloneRect, pFormat);

                    play = false;
                }

                count = (count + 1) % frameSpeed;
            }
        }
    }
}
