namespace RGZ_CG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPoints = new System.Windows.Forms.CheckBox();
            this.checkBoxWire = new System.Windows.Forms.CheckBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProjection = new System.Windows.Forms.ComboBox();
            this.labelTrZ = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarTranslateZ = new System.Windows.Forms.TrackBar();
            this.labelTrY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarTranslateY = new System.Windows.Forms.TrackBar();
            this.labelTrX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarTranslateX = new System.Windows.Forms.TrackBar();
            this.trackBarRotateZ = new System.Windows.Forms.TrackBar();
            this.trackBarRotateY = new System.Windows.Forms.TrackBar();
            this.labelZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRotateX = new System.Windows.Forms.TrackBar();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.checkBoxPoints);
            this.panel1.Controls.Add(this.checkBoxWire);
            this.panel1.Controls.Add(this.labelFile);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trackBarScale);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxProjection);
            this.panel1.Controls.Add(this.labelTrZ);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.trackBarTranslateZ);
            this.panel1.Controls.Add(this.labelTrY);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.trackBarTranslateY);
            this.panel1.Controls.Add(this.labelTrX);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.trackBarTranslateX);
            this.panel1.Controls.Add(this.trackBarRotateZ);
            this.panel1.Controls.Add(this.trackBarRotateY);
            this.panel1.Controls.Add(this.labelZ);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarRotateX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(690, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 521);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxPoints
            // 
            this.checkBoxPoints.AutoSize = true;
            this.checkBoxPoints.Checked = true;
            this.checkBoxPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPoints.Location = new System.Drawing.Point(137, 39);
            this.checkBoxPoints.Name = "checkBoxPoints";
            this.checkBoxPoints.Size = new System.Drawing.Size(73, 17);
            this.checkBoxPoints.TabIndex = 27;
            this.checkBoxPoints.Text = "Вершины";
            this.checkBoxPoints.UseVisualStyleBackColor = true;
            this.checkBoxPoints.CheckedChanged += new System.EventHandler(this.checkBoxPoints_CheckedChanged);
            // 
            // checkBoxWire
            // 
            this.checkBoxWire.AutoSize = true;
            this.checkBoxWire.Checked = true;
            this.checkBoxWire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWire.Location = new System.Drawing.Point(137, 62);
            this.checkBoxWire.Name = "checkBoxWire";
            this.checkBoxWire.Size = new System.Drawing.Size(57, 17);
            this.checkBoxWire.TabIndex = 26;
            this.checkBoxWire.Text = "Ребра";
            this.checkBoxWire.UseVisualStyleBackColor = true;
            this.checkBoxWire.CheckedChanged += new System.EventHandler(this.checkBoxWire_CheckedChanged);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(92, 55);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(0, 13);
            this.labelFile.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(9, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Масштабирование";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(12, 475);
            this.trackBarScale.Maximum = 5000;
            this.trackBarScale.Minimum = 10;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(198, 45);
            this.trackBarScale.TabIndex = 22;
            this.trackBarScale.TickFrequency = 500;
            this.trackBarScale.Value = 1000;
            this.trackBarScale.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Проекция";
            // 
            // comboBoxProjection
            // 
            this.comboBoxProjection.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxProjection.FormattingEnabled = true;
            this.comboBoxProjection.Items.AddRange(new object[] {
            "Ортогональная",
            "Перспектива"});
            this.comboBoxProjection.Location = new System.Drawing.Point(83, 12);
            this.comboBoxProjection.Name = "comboBoxProjection";
            this.comboBoxProjection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProjection.TabIndex = 20;
            this.comboBoxProjection.Text = "Ортогональная";
            this.comboBoxProjection.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjection_SelectedIndexChanged);
            // 
            // labelTrZ
            // 
            this.labelTrZ.AutoSize = true;
            this.labelTrZ.Location = new System.Drawing.Point(172, 408);
            this.labelTrZ.Name = "labelTrZ";
            this.labelTrZ.Size = new System.Drawing.Size(13, 13);
            this.labelTrZ.TabIndex = 19;
            this.labelTrZ.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Смещение по Z";
            // 
            // trackBarTranslateZ
            // 
            this.trackBarTranslateZ.LargeChange = 5000;
            this.trackBarTranslateZ.Location = new System.Drawing.Point(9, 424);
            this.trackBarTranslateZ.Maximum = 50000;
            this.trackBarTranslateZ.Minimum = -50000;
            this.trackBarTranslateZ.Name = "trackBarTranslateZ";
            this.trackBarTranslateZ.Size = new System.Drawing.Size(198, 45);
            this.trackBarTranslateZ.SmallChange = 1000;
            this.trackBarTranslateZ.TabIndex = 17;
            this.trackBarTranslateZ.TickFrequency = 5000;
            this.trackBarTranslateZ.ValueChanged += new System.EventHandler(this.trackBarTranslate_ValueChanged);
            // 
            // labelTrY
            // 
            this.labelTrY.AutoSize = true;
            this.labelTrY.Location = new System.Drawing.Point(172, 348);
            this.labelTrY.Name = "labelTrY";
            this.labelTrY.Size = new System.Drawing.Size(13, 13);
            this.labelTrY.TabIndex = 16;
            this.labelTrY.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Смещение по Y";
            // 
            // trackBarTranslateY
            // 
            this.trackBarTranslateY.LargeChange = 5000;
            this.trackBarTranslateY.Location = new System.Drawing.Point(9, 364);
            this.trackBarTranslateY.Maximum = 50000;
            this.trackBarTranslateY.Minimum = -50000;
            this.trackBarTranslateY.Name = "trackBarTranslateY";
            this.trackBarTranslateY.Size = new System.Drawing.Size(198, 45);
            this.trackBarTranslateY.SmallChange = 1000;
            this.trackBarTranslateY.TabIndex = 14;
            this.trackBarTranslateY.TickFrequency = 5000;
            this.trackBarTranslateY.ValueChanged += new System.EventHandler(this.trackBarTranslate_ValueChanged);
            // 
            // labelTrX
            // 
            this.labelTrX.AutoSize = true;
            this.labelTrX.Location = new System.Drawing.Point(172, 297);
            this.labelTrX.Name = "labelTrX";
            this.labelTrX.Size = new System.Drawing.Size(13, 13);
            this.labelTrX.TabIndex = 13;
            this.labelTrX.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Смещение по X";
            // 
            // trackBarTranslateX
            // 
            this.trackBarTranslateX.LargeChange = 5000;
            this.trackBarTranslateX.Location = new System.Drawing.Point(9, 313);
            this.trackBarTranslateX.Maximum = 50000;
            this.trackBarTranslateX.Minimum = -50000;
            this.trackBarTranslateX.Name = "trackBarTranslateX";
            this.trackBarTranslateX.Size = new System.Drawing.Size(198, 45);
            this.trackBarTranslateX.SmallChange = 1000;
            this.trackBarTranslateX.TabIndex = 11;
            this.trackBarTranslateX.TickFrequency = 5000;
            this.trackBarTranslateX.ValueChanged += new System.EventHandler(this.trackBarTranslate_ValueChanged);
            // 
            // trackBarRotateZ
            // 
            this.trackBarRotateZ.LargeChange = 10;
            this.trackBarRotateZ.Location = new System.Drawing.Point(9, 262);
            this.trackBarRotateZ.Maximum = 360;
            this.trackBarRotateZ.Minimum = -360;
            this.trackBarRotateZ.Name = "trackBarRotateZ";
            this.trackBarRotateZ.Size = new System.Drawing.Size(198, 45);
            this.trackBarRotateZ.TabIndex = 10;
            this.trackBarRotateZ.TickFrequency = 30;
            this.trackBarRotateZ.ValueChanged += new System.EventHandler(this.trackBarRotate_ValueChanged);
            // 
            // trackBarRotateY
            // 
            this.trackBarRotateY.LargeChange = 10;
            this.trackBarRotateY.Location = new System.Drawing.Point(9, 198);
            this.trackBarRotateY.Maximum = 360;
            this.trackBarRotateY.Minimum = -360;
            this.trackBarRotateY.Name = "trackBarRotateY";
            this.trackBarRotateY.Size = new System.Drawing.Size(198, 45);
            this.trackBarRotateY.TabIndex = 9;
            this.trackBarRotateY.TickFrequency = 30;
            this.trackBarRotateY.ValueChanged += new System.EventHandler(this.trackBarRotate_ValueChanged);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(172, 246);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(13, 13);
            this.labelZ.TabIndex = 8;
            this.labelZ.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Поворот по Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(172, 179);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(13, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поворот по Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(172, 115);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(13, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поворот по X";
            // 
            // trackBarRotateX
            // 
            this.trackBarRotateX.LargeChange = 10;
            this.trackBarRotateX.Location = new System.Drawing.Point(9, 131);
            this.trackBarRotateX.Maximum = 360;
            this.trackBarRotateX.Minimum = -360;
            this.trackBarRotateX.Name = "trackBarRotateX";
            this.trackBarRotateX.Size = new System.Drawing.Size(198, 45);
            this.trackBarRotateX.TabIndex = 0;
            this.trackBarRotateX.TickFrequency = 30;
            this.trackBarRotateX.ValueChanged += new System.EventHandler(this.trackBarRotate_ValueChanged);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(690, 521);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "3D файлы .obj|*.obj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 521);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(922, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.TrackBar trackBarRotateX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTrX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarTranslateX;
        private System.Windows.Forms.TrackBar trackBarRotateZ;
        private System.Windows.Forms.TrackBar trackBarRotateY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTrZ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarTranslateZ;
        private System.Windows.Forms.Label labelTrY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarTranslateY;
        private System.Windows.Forms.ComboBox comboBoxProjection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxWire;
        private System.Windows.Forms.CheckBox checkBoxPoints;
    }
}

