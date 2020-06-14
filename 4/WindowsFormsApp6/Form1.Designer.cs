namespace Лаб_4
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
            this.components = new System.ComponentModel.Container();
            this.processed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.make_it_gray = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.original = new System.Windows.Forms.PictureBox();
            this.Openbutton = new System.Windows.Forms.Button();
            this.ThresholdButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.processed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            this.SuspendLayout();
            // 
            // processed
            // 
            this.processed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processed.Location = new System.Drawing.Point(760, 42);
            this.processed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processed.Name = "processed";
            this.processed.Size = new System.Drawing.Size(486, 508);
            this.processed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processed.TabIndex = 1;
            this.processed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "До";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1000, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "После";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // make_it_gray
            // 
            this.make_it_gray.Location = new System.Drawing.Point(18, 209);
            this.make_it_gray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.make_it_gray.Name = "make_it_gray";
            this.make_it_gray.Size = new System.Drawing.Size(200, 50);
            this.make_it_gray.TabIndex = 4;
            this.make_it_gray.Text = "Оттенки серого";
            this.make_it_gray.UseVisualStyleBackColor = true;
            this.make_it_gray.Click += new System.EventHandler(this.make_it_gray_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(18, 42);
            this.info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(200, 50);
            this.info.TabIndex = 6;
            this.info.Text = "Информация";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // original
            // 
            this.original.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.original.Location = new System.Drawing.Point(252, 42);
            this.original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(449, 508);
            this.original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.original.TabIndex = 0;
            this.original.TabStop = false;
            this.original.Click += new System.EventHandler(this.original_Click);
            // 
            // Openbutton
            // 
            this.Openbutton.ImageKey = "(отсутствует)";
            this.Openbutton.Location = new System.Drawing.Point(18, 126);
            this.Openbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Openbutton.Name = "Openbutton";
            this.Openbutton.Size = new System.Drawing.Size(200, 50);
            this.Openbutton.TabIndex = 7;
            this.Openbutton.Text = "Открыть";
            this.Openbutton.UseVisualStyleBackColor = true;
            this.Openbutton.Click += new System.EventHandler(this.Openbutton_Click);
            // 
            // ThresholdButton
            // 
            this.ThresholdButton.Location = new System.Drawing.Point(18, 292);
            this.ThresholdButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThresholdButton.Name = "ThresholdButton";
            this.ThresholdButton.Size = new System.Drawing.Size(200, 50);
            this.ThresholdButton.TabIndex = 8;
            this.ThresholdButton.Text = "Неполная пороговая обработка";
            this.ThresholdButton.UseVisualStyleBackColor = true;
            this.ThresholdButton.Click += new System.EventHandler(this.ThresholdButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 427);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Масочная фильтрация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(18, 496);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(200, 50);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Сохранить изображение";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ThresholdButton);
            this.Controls.Add(this.Openbutton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.make_it_gray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processed);
            this.Controls.Add(this.original);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Контрастное масштабирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox processed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button make_it_gray;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.PictureBox original;
        private System.Windows.Forms.Button Openbutton;
        private System.Windows.Forms.Button ThresholdButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


