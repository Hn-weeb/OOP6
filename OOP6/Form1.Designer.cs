namespace OOP6
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
            this.btnBrush = new System.Windows.Forms.Button();
            this.listColor = new System.Windows.Forms.ListBox();
            this.listFigures = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 584);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click);
            // 
            // btnBrush
            // 
            this.btnBrush.Enabled = false;
            this.btnBrush.Location = new System.Drawing.Point(765, 15);
            this.btnBrush.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(63, 49);
            this.btnBrush.TabIndex = 1;
            this.btnBrush.TabStop = false;
            this.btnBrush.Text = "brush";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnChangeColor);
            // 
            // listColor
            // 
            this.listColor.FormattingEnabled = true;
            this.listColor.ItemHeight = 16;
            this.listColor.Items.AddRange(new object[] {
            "Blue",
            "Brown",
            "Yellow",
            "Green",
            "Purple",
            "Red",
            "White"});
            this.listColor.Location = new System.Drawing.Point(765, 71);
            this.listColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listColor.Name = "listColor";
            this.listColor.Size = new System.Drawing.Size(61, 132);
            this.listColor.TabIndex = 2;
            this.listColor.SelectedIndexChanged += new System.EventHandler(this.listColor_SelectedIndexChanged);
            // 
            // listFigures
            // 
            this.listFigures.FormattingEnabled = true;
            this.listFigures.ItemHeight = 16;
            this.listFigures.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Square",
            "Triangle"});
            this.listFigures.Location = new System.Drawing.Point(765, 482);
            this.listFigures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listFigures.Name = "listFigures";
            this.listFigures.Size = new System.Drawing.Size(112, 116);
            this.listFigures.TabIndex = 3;
            this.listFigures.SelectedIndexChanged += new System.EventHandler(this.listFigures_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 849);
            this.Controls.Add(this.listFigures);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.btnBrush);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.ListBox listFigures;
    }
}

