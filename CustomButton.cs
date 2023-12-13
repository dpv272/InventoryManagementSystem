using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CustomButton : PictureBox
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        private Image img;
        private Image imgHover;

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }

        public Image ImgHover
        {
            get { return imgHover; }
            set { imgHover = value; }
        }

        private void CustomButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = imgHover;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = img;
        }
    }
}
