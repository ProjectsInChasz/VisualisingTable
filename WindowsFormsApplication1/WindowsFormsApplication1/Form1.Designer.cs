namespace WindowsFormsApplication1
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.button1 = new System.Windows.Forms.Button();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button2 = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(12, 12);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.Size = new System.Drawing.Size(1153, 526);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(12, 623);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(208, 60);
         this.button1.TabIndex = 1;
         this.button1.Text = "Draw";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(6, 16);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
         this.numericUpDown1.TabIndex = 4;
         this.numericUpDown1.Click += new System.EventHandler(this.NUD1_Click);
         // 
         // numericUpDown2
         // 
         this.numericUpDown2.Location = new System.Drawing.Point(6, 16);
         this.numericUpDown2.Name = "numericUpDown2";
         this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
         this.numericUpDown2.TabIndex = 4;
         this.numericUpDown2.Click += new System.EventHandler(this.NUD2_Click);
         // 
         // numericUpDown3
         // 
         this.numericUpDown3.Location = new System.Drawing.Point(6, 42);
         this.numericUpDown3.Name = "numericUpDown3";
         this.numericUpDown3.Size = new System.Drawing.Size(53, 20);
         this.numericUpDown3.TabIndex = 4;
         // 
         // numericUpDown4
         // 
         this.numericUpDown4.Location = new System.Drawing.Point(6, 35);
         this.numericUpDown4.Name = "numericUpDown4";
         this.numericUpDown4.Size = new System.Drawing.Size(53, 20);
         this.numericUpDown4.TabIndex = 4;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(62, 72);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(183, 20);
         this.textBox1.TabIndex = 5;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(226, 623);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(208, 60);
         this.button2.TabIndex = 1;
         this.button2.Text = "Fill";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.numericUpDown3);
         this.groupBox1.Controls.Add(this.numericUpDown1);
         this.groupBox1.Location = new System.Drawing.Point(12, 544);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(65, 77);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Rows";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.numericUpDown2);
         this.groupBox2.Controls.Add(this.numericUpDown4);
         this.groupBox2.Location = new System.Drawing.Point(83, 545);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(72, 61);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Collumns";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1354, 721);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.dataGridView1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.NumericUpDown numericUpDown2;
      private System.Windows.Forms.NumericUpDown numericUpDown3;
      private System.Windows.Forms.NumericUpDown numericUpDown4;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
   }
}

