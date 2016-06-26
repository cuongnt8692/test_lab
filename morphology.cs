using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Math.Geometry;
using System.Drawing.Imaging;
using AForge;

namespace imagelocation
{
    class morphology
    {

        public static Bitmap Dilation(Bitmap srcImg)
		{
			int[,] se = new int[5, 21];
            for (int h = 0; h < 5; h ++)
            {
                for (int k = 0; k < 21; k++)
                {
                    if (h == 2 || k == 11)
                        se[h, k] = 1;
                    else
                        se[h, k] = 0;
                }
            }
 
			// get source image size
			int width = srcImg.Width;
			int height = srcImg.Height;
 
			// lock source bitmap data
			BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, width, height),
													ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
 
			// create new grayscale image
			Bitmap dstImg = AForge.Imaging.Image.CreateGrayscaleImage(width, height);
 
			// lock destination bitmap data
			BitmapData dstData = dstImg.LockBits(new Rectangle(0, 0, width, height),
													ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
 
			int stride = dstData.Stride;
			int offset = stride - width;
			int t, ir, jr, i, j;
			byte max, v;
 
			// do the job
			unsafe
			{
				byte * src = (byte *) srcData.Scan0.ToPointer();
				byte * dst = (byte *) dstData.Scan0.ToPointer();
 
				// for each line
				for (int y = 0; y < height; y++)
				{
					// for each pixel
					for (int x = 0; x < width; x++, src ++, dst ++)
					{
						max = 0;
						
						// for each SE row
						for (i = 0; i < 5; i++)
						{
							ir = i - 2;
							t = y + ir;
							
							// skip row
							if (t < 0)
								continue;
							
							// break
							if (t >= height)
								break;
							
							// for each SE column
							for (j = 0; j < 21; j++)
							{
								jr = j - 11;
								t = x + jr;
 
								// skip column
								if (t < 0)
									continue;
								if (t < width)
								{
									if (se[i, j] == 1)
									{
										// get new MAX value
										v = src[ir * stride + jr];
										if (v > max)
											max = v;
									}
								}
							}
						}
						// result pixel
						*dst = max;
					}
					src += offset;
					dst += offset;
				}
			}
			// unlock both images
			dstImg.UnlockBits(dstData);
			srcImg.UnlockBits(srcData);
			return dstImg;
		}

        public static Bitmap Erosion(Bitmap srcImg)
        {
            int[,] se = new int[11, 45];
            for (int h = 0; h < 11; h++)
            {
                for (int k = 0; k < 45; k++)
                {
                    if (h == 5 || k == 22)
                        se[h, k] = 1;
                    else
                        se[h, k] = 0;
                }
            }

            // get source image size
            int width = srcImg.Width;
            int height = srcImg.Height;

            // lock source bitmap data
            BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, width, height),
                                                    ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);

            // create new grayscale image
            Bitmap dstImg = AForge.Imaging.Image.CreateGrayscaleImage(width, height);

            // lock destination bitmap data
            BitmapData dstData = dstImg.LockBits(new Rectangle(0, 0, width, height),
                                                    ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int stride = dstData.Stride;
            int offset = stride - width;
            int t, ir, jr, i, j;
            byte min, v;

            // do the job
            unsafe
            {
                byte* src = (byte*)srcData.Scan0.ToPointer();
                byte* dst = (byte*)dstData.Scan0.ToPointer();

                // for each line
                for (int y = 0; y < height; y++)
                {

                    // for each pixel
                    for (int x = 0; x < width; x++, src++, dst++)
                    {
                        min = 255;

                        // for each SE row
                        for (i = 0; i < 11; i++)
                        {
                            ir = i - 5;
                            t = y + ir;

                            // skip row
                            if (t < 0)
                                continue;
                            // break
                            if (t >= height)
                                break;

                            // for each SE column
                            for (j = 0; j < 45; j++)
                            {
                                jr = j - 22;
                                t = x + jr;

                                // skip column
                                if (t < 0)
                                    continue;
                                if (t < width)
                                {
                                    if (se[i, j] == 1)
                                    {
                                        // get new MIN value
                                        v = src[ir * stride + jr];
                                        if (v < min)
                                            min = v;
                                    }
                                }

                            }
                        }
                        // result pixel
                        *dst = min;
                    }
                    src += offset;
                    dst += offset;
                }
            }
            // unlock both images
            dstImg.UnlockBits(dstData);
            srcImg.UnlockBits(srcData);
            return dstImg;
        }

        public static Bitmap Opening(Bitmap srcImg)
        {
            Bitmap bitmap = Dilation(srcImg);
            bitmap = Erosion(bitmap);
            return bitmap;
        }

    }
}
