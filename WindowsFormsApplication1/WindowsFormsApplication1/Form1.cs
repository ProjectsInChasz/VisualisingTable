using System;
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
      public static Class1 newClass;
      public Form1()
      {
         InitializeComponent();
         
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.dataGridView1.RowCount = int.Parse(this.numericUpDown1.Text);
         this.dataGridView1.ColumnCount = int.Parse(this.numericUpDown2.Text);

         this.numericUpDown3.Value = dataGridView1.RowCount;
         this.numericUpDown4.Value = dataGridView1.ColumnCount;

         newClass = new Class1(this.dataGridView1.RowCount, this.dataGridView1.ColumnCount);


        // dataGridView1.DataSource = newClass.Array();

         //int[,] array = newClass.Array();
         //for (int i = 0; i < dataGridView1.ColumnCount; i++)
         //{
         //   this.textBox1.AppendText(array.GetValue(i,i).ToString());
         //}
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void Form1_Load(object sender, EventArgs e)
      {
       //  dataGridView1.
      }

      private void button2_Click(object sender, EventArgs e)
      {
         //MessageBox.Show(newClass.X().ToString());
         //MessageBox.Show(dataGridView1.RowCount.ToString());

         //MessageBox.Show(newClass.Y().ToString());
         //MessageBox.Show(dataGridView1.ColumnCount.ToString());
         newClass.Populate(dataGridView1);
      }

      private void NUD1_Click(object sender, EventArgs e)
      {


      }

      private void NUD2_Click(object sender, EventArgs e)
      {

      }
   }
}
