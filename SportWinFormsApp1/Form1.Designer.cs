namespace SportWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            windowDataBindingSource = new BindingSource(components);
            windowDataBindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            distanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            durationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            avgSpeedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxSpeedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minSpeedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowDataBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Json|*.json";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(989, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(189, 26);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(189, 26);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(840, 144);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { distanceDataGridViewTextBoxColumn, durationDataGridViewTextBoxColumn, avgSpeedDataGridViewTextBoxColumn, maxSpeedDataGridViewTextBoxColumn, minSpeedDataGridViewTextBoxColumn });
            dataGridView1.DataSource = windowDataBindingSource;
            dataGridView1.Location = new Point(12, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(840, 374);
            dataGridView1.TabIndex = 2;
            // 
            // windowDataBindingSource
            // 
            windowDataBindingSource.DataSource = typeof(Models.WindowData);
            // 
            // windowDataBindingSource1
            // 
            windowDataBindingSource1.DataSource = typeof(Models.WindowData);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 3;
            label1.Text = "Общая информация:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 236);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 4;
            label2.Text = "Данные о тренировке:";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            distanceDataGridViewTextBoxColumn.HeaderText = "Дистанция";
            distanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            distanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            durationDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            durationDataGridViewTextBoxColumn.Width = 175;
            // 
            // avgSpeedDataGridViewTextBoxColumn
            // 
            avgSpeedDataGridViewTextBoxColumn.DataPropertyName = "AvgSpeed";
            avgSpeedDataGridViewTextBoxColumn.HeaderText = "Средняя скорость";
            avgSpeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            avgSpeedDataGridViewTextBoxColumn.Name = "avgSpeedDataGridViewTextBoxColumn";
            avgSpeedDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxSpeedDataGridViewTextBoxColumn
            // 
            maxSpeedDataGridViewTextBoxColumn.DataPropertyName = "MaxSpeed";
            maxSpeedDataGridViewTextBoxColumn.HeaderText = "Максимальная скорость";
            maxSpeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxSpeedDataGridViewTextBoxColumn.Name = "maxSpeedDataGridViewTextBoxColumn";
            maxSpeedDataGridViewTextBoxColumn.Width = 125;
            // 
            // minSpeedDataGridViewTextBoxColumn
            // 
            minSpeedDataGridViewTextBoxColumn.DataPropertyName = "MinSpeed";
            minSpeedDataGridViewTextBoxColumn.HeaderText = "Минимальная скорость";
            minSpeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            minSpeedDataGridViewTextBoxColumn.Name = "minSpeedDataGridViewTextBoxColumn";
            minSpeedDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 679);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowDataBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private BindingSource windowDataBindingSource;
        private DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private BindingSource windowDataBindingSource1;
        private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn avgSpeedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxSpeedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minSpeedDataGridViewTextBoxColumn;
    }
}
