using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        ListView listView1;
        public Form1()
        {
            InitializeComponent();

            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(510, 200));
            listView1.View = View.Details;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.CheckBoxes = true;
            listView1.Sorting = SortOrder.Ascending;

            ListViewItem item1 = new ListViewItem("Написать синтезатор на С#", 0);
            item1.Checked = false; 
            item1.SubItems.Add("0");

            ListViewItem item2 = new ListViewItem("Слетать в Афины", 0);
            item2.Checked = false;
            item2.SubItems.Add("20000");

            ListViewItem item3 = new ListViewItem("Купить новое издание \"Бхагавадгиты\"", 0);
            item3.Checked = false; 
            item3.SubItems.Add("640");

            ListViewItem item4 = new ListViewItem("Закончить обучение в ШАГе", 0);
            item4.Checked = false; 
            item4.SubItems.Add("120000");

            ListViewItem item5 = new ListViewItem("Обновить ПК", 0);
            item5.Checked = false;
            item5.SubItems.Add("10000");

            listView1.Columns.Add("Название", 360, HorizontalAlignment.Left);
            listView1.Columns.Add("Цена", 70, HorizontalAlignment.Center);

            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5 });

            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListSmall.Images.Add(Bitmap.FromFile("1.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile("2.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("3.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("4.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("5.bmp"));

            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            this.Controls.Add(listView1);

            Width = 600;
            Height = 300;
        }
    }
}