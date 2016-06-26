using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imagelocation
{
    class location
    {
        public int[] x_location, y_location, width_location, height_location;
        public int[] coord_x, coord_y, coord_width, coord_height;

        public Bitmap detection_text_areas(String filename)
        {
            Bitmap bmp = process.cannyEdgeDetection(filename, 0, 0);
            int widthbmp = bmp.Width;
            int heightbmp = bmp.Height;
            bmp = morphology.Dilation(bmp);
            bmp = morphology.Opening(bmp);
            bmp = process.im2bw(bmp, 50);

            bmp = grahamConvexHul(bmp);
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(bmp);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            int counter = blobCounter.ObjectsCount; // Counting number of objects

            //x_location = new int[counter];
            //y_location = new int[counter];
            //width_location = new int[counter];
            //height_location = new int[counter];

            var listx = new List<int>();
            var listy = new List<int>();
            var listw = new List<int>();
            var listh = new List<int>();

            int i = 0, j;
            foreach (Blob blob in blobs)
            {
                listx.Add(blob.Rectangle.X);
                listy.Add(blob.Rectangle.Y);
                listw.Add(blob.Rectangle.Width);
                listh.Add(blob.Rectangle.Height);
            }

            //for (i = 0; i < counter; i++)
            //{
            //    Console.WriteLine(listx[i] + "\t" + listy[i] + "\t" + listw[i] + "\t" + listh[i]);
            //}

            var listremove = new List<int>();
            for (i = 0; i < counter; i++)
            {
                for (j = 0; j < counter; j++)
                {
                    if ((listx[i] > listx[j] && listy[i] > listy[j] && listx[i] + listw[i] < listx[j] + listw[j] && listy[i] + listh[i] < listy[j] + listh[j]))
                    {
                        listremove.Add(i);
                        break;
                    }
                }
            }

            int index;
            for (i = 0; i < listremove.Count(); i++)
            {
                index = listremove[i];
                listx[index] = 0;
                listy[index] = 0;
                listw[index] = 0;
                listh[index] = 0;
            }

            i = 0;
            while (i < listx.Count())
            {
                if (listx[i] == 0 && listy[i] == 0 && listw[i] == 0 && listh[i] == 0)
                {
                    listx.RemoveAt(i);
                    listy.RemoveAt(i);
                    listw.RemoveAt(i);
                    listh.RemoveAt(i);
                    i--;
                }
                i++;
            }

            //for (i = 0; i < listw.Count(); i++)
            //{
            //    Console.WriteLine(listx[i] + "\t" + listy[i] + "\t" + listw[i] + "\t" + listh[i]);
            //}

            x_location = listx.ToArray();
            y_location = listy.ToArray();
            width_location = listw.ToArray();
            height_location = listh.ToArray();

            Bitmap newbitmap = new Bitmap(filename);

            int k;
            Graphics graphicsObj;
            Bitmap newbmp = new Bitmap(filename);
            graphicsObj = Graphics.FromImage(newbmp);
            Pen myPen = new Pen(System.Drawing.Color.Red, 1);
            Rectangle[] rectangleObj = new Rectangle[counter];

            int xadd, yadd;
            for (k = 0; k < listw.Count(); k++)
            {
                if (x_location[k] > 5)
                {
                    xadd = -5;
                }
                else
                {
                    xadd = 0;
                }
                if (y_location[k] > 3)
                {
                    yadd = -3;
                }
                else
                {
                    yadd = 0;
                }

                x_location[k] = x_location[k] + xadd;
                y_location[k] = y_location[k] + yadd;
                width_location[k] = width_location[k] - xadd;
                height_location[k] = height_location[k] - yadd;

                rectangleObj[k] = new Rectangle(x_location[k], y_location[k], width_location[k] - 1, height_location[k] - 1);
            }

            for (k = 0; k < counter; k++)
            {
                graphicsObj.DrawRectangle(myPen, rectangleObj[k]);
            }

            graphicsObj.Dispose();

            return newbmp;
        }

        public void segmentation(string filename, double[,] arrdouble, int x_location, int y_location, int width_location, int height_location)
        {
            int i, j, x, y;

            double[,] arraydouble = new double[arrdouble.GetLength(0), arrdouble.GetLength(1)];

            for (i = 0; i < arrdouble.GetLength(0); i++)
            {
                for (j = 0; j < arrdouble.GetLength(1); j++)
                {
                    arraydouble[i, j] = 1 - arrdouble[i, j];
                }
            }

            int sizesumx = width_location + 1;
            int sizesumy = height_location + 1;
            var listSumx = new List<double>();
            double s;
            for (x = x_location; x < x_location + width_location; x++)
            {
                s = 0;
                for (y = y_location; y < y_location + height_location; y++)
                {
                    s = s + arraydouble[x, y];
                }
                listSumx.Add(s);
            }

            double[] sumx;
            sumx = listSumx.ToArray();
            //foreach(double k in sumx)
            //{
            //    Console.WriteLine(k);
            //}

            var listPos = new List<int>();
            double thresh = sumx.Average() * 0.275; 
            for (i = 0; i < sumx.Count(); i++)
            {
                if (i == 0 || i == sumx.Count() - 1)
                {
                    if (i == 0)
                    {
                        if (sumx[i] > thresh)
                        {
                            listPos.Add(i + x_location);
                        }
                        else if (sumx[i + 1] > thresh)
                        {
                            listPos.Add(i + x_location);
                        }
                    }
                    else if (i == sumx.Count() - 1)
                    {
                        if (sumx[i] > thresh)
                        {
                            listPos.Add(i + x_location);
                        }
                        else if (sumx[i - 1] > thresh)
                        {
                            listPos.Add(i + x_location);
                        }
                    }
                }
                else
                {
                    if (sumx[i + 1] > thresh && sumx[i] < thresh)
                    {
                        listPos.Add(i + x_location);
                    }
                    if (sumx[i] < thresh && sumx[i - 1] > thresh)
                    {
                        listPos.Add(i + x_location);
                    }
                }
            }

            int[] pos;
            pos = listPos.ToArray();
            int countpos = pos.Length / 2;
            var listx = new List<int>();
            var listy = new List<int>();
            var listwidth = new List<int>();
            var listheight = new List<int>();

            Bitmap bmp = new Bitmap(filename);
            bmp = process.im2bw(bmp, 150);
            double[,] matrixdouble = process.convertToDouble(bmp);
            for (i = 0; i < countpos; i++)
            {
                int[] arr;
                arr = coorddetermine(matrixdouble, pos[2 * i], pos[2 * i + 1], y_location, height_location + y_location);
                listx.Add(arr[0]);
                listy.Add(arr[1]);
                listwidth.Add(arr[2]);
                listheight.Add(arr[3]);
            }

            coord_x = listx.ToArray();
            coord_y = listy.ToArray();
            coord_width = listwidth.ToArray();
            coord_height = listheight.ToArray();
        }

        private int[] coorddetermine(double[,] matrixdouble, int X1, int X2, int Y1, int Y2)
        {   
            int minx = X2, maxx = X1, miny = Y2, maxy = Y1;
            for (int i = X1; i < X2;  i++)
            {
                for(int j = Y1; j < Y2; j++)
                {
                    if (matrixdouble[i, j] < 1)
                    {
                        if (i < minx)
                            minx = i;
                        if (i > maxx)
                            maxx = i;
                        if (j < miny)
                            miny = j;
                        if (j > maxy)
                            maxy = j;
                    }
                }
            }

            int[] array = {minx, miny, maxx - minx + 1, maxy - miny + 1};

            //foreach (int k in array)
            //{
            //    Console.Write(k + "\t");
            //}
            //Console.WriteLine();
            return array;
        }

        private static Bitmap grahamConvexHul(Bitmap image)
        {
            // process image with blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(image);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // create convex hull searching algorithm
            GrahamConvexHull hullFinder = new GrahamConvexHull();

            // lock image to draw on it
            BitmapData data = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, image.PixelFormat);

            // process each blob
            foreach (Blob blob in blobs)
            {
                List<IntPoint> leftPoints = new List<IntPoint>();
                List<IntPoint> rightPoints = new List<IntPoint>();
                List<IntPoint> edgePoints = new List<IntPoint>();

                // get blob's edge points
                blobCounter.GetBlobsLeftAndRightEdges(blob, out leftPoints, out rightPoints);

                edgePoints.AddRange(leftPoints);
                edgePoints.AddRange(rightPoints);

                // blob's convex hull
                List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                //Drawing.Polygon(data, hull, Color.Red);
                Drawing.Rectangle(data, blob.Rectangle, Color.Red);
            }

            image.UnlockBits(data);
            return image;
        }
    }
}
