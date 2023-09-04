using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            ImageList il = new ImageList();
            il.ImageSize = new Size(256, 256);
            il.Images.Add("test1", Image.FromFile(@"D:\網頁專案\布哥\hanying\hanying-project\hanying-api\public\float\img\philosophy.png"));
            il.Images.Add("test2", Image.FromFile(@"D:\網頁專案\布哥\hanying\hanying-project\hanying-api\public\float\img\philosophy.png"));
            il.Images.Add("test3", Image.FromFile(@"D:\網頁專案\布哥\hanying\hanying-project\hanying-api\public\float\img\philosophy.png"));

            productlistView.View = View.LargeIcon;
            productlistView.LargeImageList = il;

            for (int i = 0; i < il.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "koala 1";
                productlistView.Items.Add(lvi);
            }
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            var productForm = new Products.Main();
            productForm.ShowDialog();
        }
    }
}
