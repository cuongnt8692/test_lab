using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagelocation
{
    class function
    {
        public string pathname;

        public Bitmap open(Bitmap bitmap)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                openfd.Title = "Open Image";
                openfd.Filter = "Image Files(*.jpg; *.png; *.gif; *.bmp)|*.jpg; *.png; *.gif; *.bmp";﻿
                //Read image
                bitmap = new Bitmap(openfd.FileName);
                this.pathname = openfd.FileName.ToString();
            }
            return bitmap;
        }

        public void save(Bitmap bitmap)
        {
            SaveFileDialog savefd = new SaveFileDialog();
            savefd.Filter = "Image Files(*.jpg; *.png; *.gif; *.bmp)|*.jpg; *.png; *.gif; *.bmp";
            if (bitmap != null)
            {
                if (savefd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (savefd.FileName.Substring(savefd.FileName.Length - 3).ToLower() == "bmp")
                    {
                        bitmap.Save(savefd.FileName, ImageFormat.Bmp);
                    }
                    if (savefd.FileName.Substring(savefd.FileName.Length - 3).ToLower() == "jpg")
                    {
                        bitmap.Save(savefd.FileName, ImageFormat.Jpeg);
                    }
                    if (savefd.FileName.Substring(savefd.FileName.Length - 3).ToLower() == "png")
                    {
                        bitmap.Save(savefd.FileName, ImageFormat.Png);
                    }
                    if (savefd.FileName.Substring(savefd.FileName.Length - 3).ToLower() == "gif")
                    {
                        bitmap.Save(savefd.FileName, ImageFormat.Gif);
                    }
                }
            }
            else
            {
                MessageBox.Show("Have no image! Choose image firstly!", "Warming");
            }
        }

        public void output(Bitmap bm)
        {
            int x, y;
            Color c;
            Byte red, green, blue;
            Console.WriteLine("\nRed\n");
            for (y = 0; y < bm.Height; y++)
            {
                for (x = 0; x < bm.Width; x++)
                {
                    c = bm.GetPixel(x, y);
                    red = Convert.ToByte(c.R);
                    Console.Write(red + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nGreen\n");
            for (y = 0; y < bm.Height; y++)
            {
                for (x = 0; x < bm.Width; x++)
                {
                    c = bm.GetPixel(x, y);
                    green = Convert.ToByte(c.G);
                    Console.Write(green + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nBlue\n");
            for (y = 0; y < bm.Height; y++)
            {
                for (x = 0; x < bm.Width; x++)
                {
                    c = bm.GetPixel(x, y);
                    blue = Convert.ToByte(c.B);
                    Console.Write(blue + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
