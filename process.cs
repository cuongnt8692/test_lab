using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imagelocation
{
    class process
    {
        //Convert image to grayscale
        public static Bitmap im2gray(Bitmap image)
        {
            // create grayscale filter (BT709)
            Grayscale filter = new Grayscale(0.299, 0.587, 0.114);
            // apply the filter
            Bitmap grayImage = filter.Apply(image);
            return grayImage;
        }

        public static Bitmap im2bw(Bitmap bm, int thresh)
        {
            //Bitmap bitmap = convertToGrayScale(bm);
            Bitmap bitmap = new Bitmap(bm);
            Color c;
            int x, y;

            for (x = 0; x < bitmap.Width; x++)
            {
                for (y = 0; y < bitmap.Height; y++)
                {
                    c = bitmap.GetPixel(x, y);
                    if ((((c.R + c.G + c.B) / 3)) < thresh)
                        bitmap.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        bitmap.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            return bitmap;
        }

        public static double[,] convertToDouble(Bitmap bm)
        {
            var result = new double[bm.Width, bm.Height];
            //Console.WriteLine("\n");
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    result[x, y] = (double)bm.GetPixel(x, y).R / 255;
                   // Console.Write(String.Format("{0}", result[x, y]) + "\t");
                }
                //Console.WriteLine();
            }
            return result;
        }

        //Edge detection
        public static Bitmap cannyEdgeDetection(String pathname, byte lowThresh, byte highThresh)
        {
            Bitmap image = new Bitmap(pathname);
            image = im2gray(image);
            // create filter
            CannyEdgeDetector filter = new CannyEdgeDetector(lowThresh, highThresh);
            // apply the filter
            image = filter.Apply(image);
            return image;
        }

        public static Bitmap homogenityEdgeDetection(String pathname)
        {
            Bitmap image = new Bitmap(pathname);
            image = im2gray(image);
            // create filter
            HomogenityEdgeDetector filter = new HomogenityEdgeDetector();
            // apply the filter
            image = filter.Apply(image);
            return image;
        }

        public static Bitmap sobelEdgeDetection(String pathname)
        {
            Bitmap image = new Bitmap(pathname);
            image = im2gray(image);
            // create filter
            SobelEdgeDetector filter = new SobelEdgeDetector();
            // apply the filter
            image = filter.Apply(image);
            return image;
        }

        public static Bitmap defferenceEdgeDetection(String pathname)
        {
            Bitmap image = new Bitmap(pathname);
            image = im2gray(image);
            // create filter
            DifferenceEdgeDetector filter = new DifferenceEdgeDetector();
            // apply the filter
            image = filter.Apply(image);
            return image;
        }

        public static Bitmap dilatation(Bitmap image)
        {
            //Bitmap image = new Bitmap(filename);
            // create filter
            Dilatation filter = new Dilatation();
            // apply the filter
            //image = im2gray(image);
            Bitmap newimage = filter.Apply(image);
            return newimage;
        }

        public static Bitmap erosion(Bitmap image)
        {
            // create filter
            Erosion filter = new Erosion();
            // apply the filter
            image = filter.Apply(image);
            return image;
        }

        public static Bitmap opening(Bitmap image)
        {
            // create filter
            Opening filter = new Opening();
            // apply the filter
            image = filter.Apply(image);
            return image;
        }

        public static Bitmap closing(Bitmap image)
        {
            // create filter
            Closing filter = new Closing();
            // apply the filter
            image = filter.Apply(image);
            return image;
        }
    }
}
