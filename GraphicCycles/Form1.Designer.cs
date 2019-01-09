namespace GraphicCycles
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLines = new System.Windows.Forms.Button();
            this.buttonAllLines = new System.Windows.Forms.Button();
            this.buttonDiagLines = new System.Windows.Forms.Button();
            this.buttonConeOfRays = new System.Windows.Forms.Button();
            this.buttonConeOfRays1 = new System.Windows.Forms.Button();
            this.buttonSquares = new System.Windows.Forms.Button();
            this.buttonSquares1 = new System.Windows.Forms.Button();
            this.buttonTracery = new System.Windows.Forms.Button();
            this.buttonTracery1 = new System.Windows.Forms.Button();
            this.buttonLinesInSquares = new System.Windows.Forms.Button();
            this.buttonCirclesInSquares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(24, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 301);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(249, 23);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLines
            // 
            this.buttonLines.Location = new System.Drawing.Point(61, 23);
            this.buttonLines.Name = "buttonLines";
            this.buttonLines.Size = new System.Drawing.Size(42, 23);
            this.buttonLines.TabIndex = 3;
            this.buttonLines.Text = "Lines";
            this.buttonLines.UseVisualStyleBackColor = true;
            this.buttonLines.Click += new System.EventHandler(this.buttonLines_Click);
            // 
            // buttonAllLines
            // 
            this.buttonAllLines.Location = new System.Drawing.Point(109, 23);
            this.buttonAllLines.Name = "buttonAllLines";
            this.buttonAllLines.Size = new System.Drawing.Size(52, 23);
            this.buttonAllLines.TabIndex = 4;
            this.buttonAllLines.Text = "AllLines";
            this.buttonAllLines.UseVisualStyleBackColor = true;
            this.buttonAllLines.Click += new System.EventHandler(this.buttonAllLines_Click);
            // 
            // buttonDiagLines
            // 
            this.buttonDiagLines.Location = new System.Drawing.Point(167, 23);
            this.buttonDiagLines.Name = "buttonDiagLines";
            this.buttonDiagLines.Size = new System.Drawing.Size(63, 23);
            this.buttonDiagLines.TabIndex = 5;
            this.buttonDiagLines.Text = "DiagLines";
            this.buttonDiagLines.UseVisualStyleBackColor = true;
            this.buttonDiagLines.Click += new System.EventHandler(this.buttonDiagLines_Click);
            // 
            // buttonConeOfRays
            // 
            this.buttonConeOfRays.Location = new System.Drawing.Point(61, 52);
            this.buttonConeOfRays.Name = "buttonConeOfRays";
            this.buttonConeOfRays.Size = new System.Drawing.Size(80, 23);
            this.buttonConeOfRays.TabIndex = 6;
            this.buttonConeOfRays.Text = "ConeOfRays";
            this.buttonConeOfRays.UseVisualStyleBackColor = true;
            this.buttonConeOfRays.Click += new System.EventHandler(this.buttonConeOfRays_Click);
            // 
            // buttonConeOfRays1
            // 
            this.buttonConeOfRays1.Location = new System.Drawing.Point(150, 52);
            this.buttonConeOfRays1.Name = "buttonConeOfRays1";
            this.buttonConeOfRays1.Size = new System.Drawing.Size(90, 23);
            this.buttonConeOfRays1.TabIndex = 7;
            this.buttonConeOfRays1.Text = "ConeOfRays1";
            this.buttonConeOfRays1.UseVisualStyleBackColor = true;
            this.buttonConeOfRays1.Click += new System.EventHandler(this.buttonConeOfRays1_Click);
            // 
            // buttonSquares
            // 
            this.buttonSquares.Location = new System.Drawing.Point(23, 81);
            this.buttonSquares.Name = "buttonSquares";
            this.buttonSquares.Size = new System.Drawing.Size(55, 23);
            this.buttonSquares.TabIndex = 8;
            this.buttonSquares.Text = "Squares";
            this.buttonSquares.UseVisualStyleBackColor = true;
            this.buttonSquares.Click += new System.EventHandler(this.buttonSquares_Click);
            // 
            // buttonSquares1
            // 
            this.buttonSquares1.Location = new System.Drawing.Point(84, 81);
            this.buttonSquares1.Name = "buttonSquares1";
            this.buttonSquares1.Size = new System.Drawing.Size(64, 23);
            this.buttonSquares1.TabIndex = 9;
            this.buttonSquares1.Text = "Squares1";
            this.buttonSquares1.UseVisualStyleBackColor = true;
            this.buttonSquares1.Click += new System.EventHandler(this.buttonSquares1_Click);
            // 
            // buttonTracery
            // 
            this.buttonTracery.Location = new System.Drawing.Point(154, 81);
            this.buttonTracery.Name = "buttonTracery";
            this.buttonTracery.Size = new System.Drawing.Size(64, 23);
            this.buttonTracery.TabIndex = 10;
            this.buttonTracery.Text = "Tracery";
            this.buttonTracery.UseVisualStyleBackColor = true;
            this.buttonTracery.Click += new System.EventHandler(this.buttonTracery_Click);
            // 
            // buttonTracery1
            // 
            this.buttonTracery1.Location = new System.Drawing.Point(224, 81);
            this.buttonTracery1.Name = "buttonTracery1";
            this.buttonTracery1.Size = new System.Drawing.Size(64, 23);
            this.buttonTracery1.TabIndex = 11;
            this.buttonTracery1.Text = "Tracery1";
            this.buttonTracery1.UseVisualStyleBackColor = true;
            this.buttonTracery1.Click += new System.EventHandler(this.buttonTracery1_Click);
            // 
            // buttonLinesInSquares
            // 
            this.buttonLinesInSquares.Location = new System.Drawing.Point(154, 110);
            this.buttonLinesInSquares.Name = "buttonLinesInSquares";
            this.buttonLinesInSquares.Size = new System.Drawing.Size(94, 23);
            this.buttonLinesInSquares.TabIndex = 12;
            this.buttonLinesInSquares.Text = "LinesInSquares";
            this.buttonLinesInSquares.UseVisualStyleBackColor = true;
            this.buttonLinesInSquares.Click += new System.EventHandler(this.buttonLinesInSquares_Click);
            // 
            // buttonCirclesInSquares
            // 
            this.buttonCirclesInSquares.Location = new System.Drawing.Point(154, 139);
            this.buttonCirclesInSquares.Name = "buttonCirclesInSquares";
            this.buttonCirclesInSquares.Size = new System.Drawing.Size(94, 23);
            this.buttonCirclesInSquares.TabIndex = 13;
            this.buttonCirclesInSquares.Text = "CirclesInSquares";
            this.buttonCirclesInSquares.UseVisualStyleBackColor = true;
            this.buttonCirclesInSquares.Click += new System.EventHandler(this.buttonCirclesInSquares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 471);
            this.Controls.Add(this.buttonCirclesInSquares);
            this.Controls.Add(this.buttonLinesInSquares);
            this.Controls.Add(this.buttonTracery1);
            this.Controls.Add(this.buttonTracery);
            this.Controls.Add(this.buttonSquares1);
            this.Controls.Add(this.buttonSquares);
            this.Controls.Add(this.buttonConeOfRays1);
            this.Controls.Add(this.buttonConeOfRays);
            this.Controls.Add(this.buttonDiagLines);
            this.Controls.Add(this.buttonAllLines);
            this.Controls.Add(this.buttonLines);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графические циклы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLines;
        private System.Windows.Forms.Button buttonAllLines;
        private System.Windows.Forms.Button buttonDiagLines;
        private System.Windows.Forms.Button buttonConeOfRays;
        private System.Windows.Forms.Button buttonConeOfRays1;
        private System.Windows.Forms.Button buttonSquares;
        private System.Windows.Forms.Button buttonSquares1;
        private System.Windows.Forms.Button buttonTracery;
        private System.Windows.Forms.Button buttonTracery1;
        private System.Windows.Forms.Button buttonLinesInSquares;
        private System.Windows.Forms.Button buttonCirclesInSquares;
    }
}

