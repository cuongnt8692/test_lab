using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagelocation
{
    public partial class Form1 : Form
    {
        function func = new function();

        private Bitmap bitmap;
        private string filename;
        private int[] x_location, y_location, width_location, height_location;
        private int size;
        private int[] x_coordinate, y_coordinate, width_coordinate, height_coordinate;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxInput.ImageLocation = @"C:\Users\Cuong\Documents\Visual Studio 2013\Projects\imagelocation\imagelocation\picture\input.jpg";
            pictureBoxOutput.ImageLocation = @"C:\Users\Cuong\Documents\Visual Studio 2013\Projects\imagelocation\imagelocation\picture\output.jpg";
            lblInfo.Visible = false;
            lblProcess.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            lblProcess.Visible = false;
            pictureBoxInput.ImageLocation = @"C:\Users\Cuong\Documents\Visual Studio 2013\Projects\imagelocation\imagelocation\picture\input.jpg";
            pictureBoxOutput.ImageLocation = @"C:\Users\Cuong\Documents\Visual Studio 2013\Projects\imagelocation\imagelocation\picture\output.jpg";
            bitmap = func.open(bitmap);
            if (bitmap != null)
            {
                filename = func.pathname;
                lblInfo.Text = "Image Information: " + "\nFile name: " + filename + "\nSize: " + bitmap.Width + " × " + bitmap.Height;
                lblInfo.Visible = true;
                pictureBoxInput.Image = bitmap;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func.save(bitmap);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            bitmap = process.cannyEdgeDetection(filename, frm2.lowThreshold, frm2.highThreshold);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Canny Edge Detector";
            lblProcess.Visible = true;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.sobelEdgeDetection(filename);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Sobel Edge Detector";
            lblProcess.Visible = true;
        }

        private void homogeneityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.homogenityEdgeDetection(filename);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Homogenity Edge Detector";
            lblProcess.Visible = true;
        }

        private void differenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.defferenceEdgeDetection(filename);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Defference Edge Detector";
            lblProcess.Visible = true;
        }

        private void dilatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.sobelEdgeDetection(filename);
            bitmap = process.dilatation(bitmap);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Dilatation operator from Mathematical Morphology";
            lblProcess.Visible = true;
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.sobelEdgeDetection(filename); ;
            bitmap = process.erosion(bitmap);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Erosion operator from Mathematical Morphology";
            lblProcess.Visible = true;
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.sobelEdgeDetection(filename);
            bitmap = process.opening(bitmap);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Opening operator from Mathematical Morphology";
            lblProcess.Visible = true;
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = process.sobelEdgeDetection(filename);
            bitmap = process.closing(bitmap);
            pictureBoxOutput.Image = bitmap;
            lblProcess.Text = "Process: Closing operator from Mathematical Morphology";
            lblProcess.Visible = true;
        }

        private unsafe void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            location loca = new location();
            bitmap = loca.detection_text_areas(filename);
            pictureBoxOutput.Image = bitmap;

            size = loca.x_location.Count();
            x_location = loca.x_location;
            y_location = loca.y_location;
            width_location = loca.width_location;
            height_location = loca.height_location;

            lblProcess.Text = "Process: Location";
            lblProcess.Visible = true;
        }

        private void segmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            location loca = new location();
            var Listx = new List<int>();
            var Listy = new List<int>();
            var Listwidth = new List<int>();
            var Listheight = new List<int>();

            bitmap = loca.detection_text_areas(filename);

            size = loca.x_location.Count();
            x_location = loca.x_location;
            y_location = loca.y_location;
            width_location = loca.width_location;
            height_location = loca.height_location;

            Bitmap bmp = new Bitmap(filename);
            //bmp = process.im2bw(bmp, 100);
            double[,] arraydouble = process.convertToDouble(bmp);
            for (int i = 0; i < size; i++)
            {
                loca.segmentation(filename, arraydouble, x_location[i], y_location[i], width_location[i], height_location[i]);
                Listx.AddRange(loca.coord_x);
                Listy.AddRange(loca.coord_y);
                Listwidth.AddRange(loca.coord_width);
                Listheight.AddRange(loca.coord_height);
            }

            x_coordinate = Listx.ToArray();
            y_coordinate = Listy.ToArray();
            width_coordinate = Listwidth.ToArray();
            height_coordinate = Listheight.ToArray();
            int size_coordinate = x_coordinate.Count();

            foreach (int k in x_coordinate)
            {
                Console.Write(k + "\t");
            }

            Console.WriteLine();
            foreach (int k in y_coordinate)
            {
                Console.Write(k + "\t");
            }


            Console.WriteLine();
            foreach (int k in width_coordinate)
            {
                Console.Write(k + "\t");
            }

            Console.WriteLine();
            foreach (int k in height_coordinate)
            {
                Console.Write(k + "\t");
            }

            bitmap = new Bitmap(filename);
            Graphics graphicsObj;
            graphicsObj = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(System.Drawing.Color.Red, 1);
            Rectangle[] rectangleObj = new Rectangle[size_coordinate];

            for (int k = 0; k < size_coordinate; k++)
            {
                //Console.WriteLine(x_coordinate[k] + "\t" + y_coordinate[k] + "\t" + width_coordinate[k] + "\t" + height_coordinate[k]);
                rectangleObj[k] = new Rectangle(x_coordinate[k], y_coordinate[k], width_coordinate[k], height_coordinate[k]);
            }

            for (int k = 0; k < size_coordinate; k++)
            {
                graphicsObj.DrawRectangle(myPen, rectangleObj[k]);
            }

            //Save coordinate segmentation
            #region
            int[,] matrix_coord = new int[size_coordinate, 4];

            Stream stream = File.Open(@"C:\Users\Cuong\Desktop\test1.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf1 = new BinaryFormatter();
            stream.Close();

            StreamWriter sw = new StreamWriter(@"C:\Users\Cuong\Desktop\test1.txt");

            for (int i = 0; i < size_coordinate; i++)
            {
                matrix_coord[i, 0] = x_coordinate[i];
                sw.Write(matrix_coord[i, 0] + "\t");
                matrix_coord[i, 1] = y_coordinate[i];
                sw.Write(matrix_coord[i, 1] + "\t");
                matrix_coord[i, 2] = width_coordinate[i];
                sw.Write(matrix_coord[i, 2] + "\t");
                matrix_coord[i, 3] = height_coordinate[i];
                sw.Write(matrix_coord[i, 3] + "\t");
                sw.WriteLine();
            }

            sw.Close();
            #endregion

            pictureBoxOutput.Image = bitmap;

            lblProcess.Text = "Process: Segmentation";
            lblProcess.Visible = true;
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(filename);
            // create filter
            Median filter = new Median(100);
            // apply the filter
            bitmap = filter.Apply(bitmap);
            pictureBoxOutput.Image = bitmap;

        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            lblProcess.Visible = false;
            pictureBoxInput.ImageLocation = @"C:\Users\Cuong\Documents\Visual Studio 2013\Projects\imagelocation\imagelocation\picture\input.jpg";
            pictureBoxOutput.ImageLocation = @"C:\Users\Cuong\Documents\Visual Studio 2013\Projects\imagelocation\imagelocation\picture\output.jpg";
            bitmap = func.open(bitmap);
            if (bitmap != null)
            {
                filename = func.pathname;
                lblInfo.Text = "Image Information: " + "\nFile name: " + filename + "\nSize: " + bitmap.Width + " × " + bitmap.Height;
                lblInfo.Visible = true;
                pictureBoxInput.Image = bitmap;
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            func.save(bitmap);
        }

        private unsafe void tspLoca_Click(object sender, EventArgs e)
        {
            location loca = new location();
            bitmap = loca.detection_text_areas(filename);
            pictureBoxOutput.Image = bitmap;

            size = loca.x_location.Count();
            x_location = loca.x_location;
            y_location = loca.y_location;
            width_location = loca.width_location;
            height_location = loca.height_location;

            lblProcess.Text = "Process: Location";
            lblProcess.Visible = true;
        }

        private void tsbRec_Click(object sender, EventArgs e)
        {
            location loca = new location();
            var Listx = new List<int>();
            var Listy = new List<int>();
            var Listwidth = new List<int>();
            var Listheight = new List<int>();

            bitmap = loca.detection_text_areas(filename);

            size = loca.x_location.Count();
            x_location = loca.x_location;
            y_location = loca.y_location;
            width_location = loca.width_location;
            height_location = loca.height_location;

            Bitmap bmp = new Bitmap(filename);
            //bmp = process.im2bw(bmp, 100);
            double[,] arraydouble = process.convertToDouble(bmp);
            for (int i = 0; i < size; i++)
            {
                loca.segmentation(filename, arraydouble, x_location[i], y_location[i], width_location[i], height_location[i]);
                Listx.AddRange(loca.coord_x);
                Listy.AddRange(loca.coord_y);
                Listwidth.AddRange(loca.coord_width);
                Listheight.AddRange(loca.coord_height);
            }

            x_coordinate = Listx.ToArray();
            y_coordinate = Listy.ToArray();
            width_coordinate = Listwidth.ToArray();
            height_coordinate = Listheight.ToArray();
            int size_coordinate = x_coordinate.Count();

            //foreach (int k in x_coordinate)
            //{
            //    Console.Write(k + "\t");
            //}

            //Console.WriteLine();
            //foreach (int k in y_coordinate)
            //{
            //    Console.Write(k + "\t");
            //}


            //Console.WriteLine();
            //foreach (int k in width_coordinate)
            //{
            //    Console.Write(k + "\t");
            //}

            //Console.WriteLine();
            //foreach (int k in height_coordinate)
            //{
            //    Console.Write(k + "\t");
            //}

            bitmap = new Bitmap(filename);
            Graphics graphicsObj;
            graphicsObj = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(System.Drawing.Color.Red, 1);
            Rectangle[] rectangleObj = new Rectangle[size_coordinate];

            for (int k = 0; k < size_coordinate; k++)
            {
                //Console.WriteLine(x_coordinate[k] + "\t" + y_coordinate[k] + "\t" + width_coordinate[k] + "\t" + height_coordinate[k]);
                rectangleObj[k] = new Rectangle(x_coordinate[k], y_coordinate[k], width_coordinate[k], height_coordinate[k]);
            }

            for (int k = 0; k < size_coordinate; k++)
            {
                graphicsObj.DrawRectangle(myPen, rectangleObj[k]);
            }

            pictureBoxOutput.Image = bitmap;

            lblProcess.Text = "Process: Segmentation";
            lblProcess.Visible = true;
        }

        private void tsbInfo_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}