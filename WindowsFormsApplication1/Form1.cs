﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = Bitmap.FromFile(@"F:\ImageChroma\ImageChroma\Backgroud\1.jpg") as Bitmap;
            ImagePrintHelper imagePrintHelper = new ImagePrintHelper(bitmap);
            imagePrintHelper.PrintPreview();
        }
    }
}
