
namespace FileInfoViewer
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBmpName = new System.Windows.Forms.Label();
            this.lblBmpSize = new System.Windows.Forms.Label();
            this.lblBmpRect = new System.Windows.Forms.Label();
            this.lblBmpColors = new System.Windows.Forms.Label();
            this.lblJpgName = new System.Windows.Forms.Label();
            this.lblJpgSize = new System.Windows.Forms.Label();
            this.lblJpgRect = new System.Windows.Forms.Label();
            this.lblJpgColors = new System.Windows.Forms.Label();
            this.lblPngName = new System.Windows.Forms.Label();
            this.lblPngSize = new System.Windows.Forms.Label();
            this.lblPngRect = new System.Windows.Forms.Label();
            this.lblPngColors = new System.Windows.Forms.Label();
            this.lblGifName = new System.Windows.Forms.Label();
            this.lblGifSize = new System.Windows.Forms.Label();
            this.lblGifRect = new System.Windows.Forms.Label();
            this.lblGifColors = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить изображение";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBmpName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBmpSize, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBmpRect, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBmpColors, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJpgName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJpgSize, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJpgRect, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJpgColors, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPngName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPngSize, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPngRect, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPngColors, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGifName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGifSize, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGifRect, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGifColors, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 375);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(5, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 75);
            this.label9.TabIndex = 8;
            this.label9.Text = "gif";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(5, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 72);
            this.label8.TabIndex = 7;
            this.label8.Text = "png";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(5, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 72);
            this.label7.TabIndex = 6;
            this.label7.Text = "jpg";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(5, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 72);
            this.label6.TabIndex = 5;
            this.label6.Text = "bmp";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(481, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 72);
            this.label5.TabIndex = 4;
            this.label5.Text = "Глубина цвета";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(362, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 72);
            this.label4.TabIndex = 3;
            this.label4.Text = "Разре-\r\nшение";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(243, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "Размер файла";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(124, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBmpName
            // 
            this.lblBmpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBmpName.AutoSize = true;
            this.lblBmpName.Location = new System.Drawing.Point(179, 105);
            this.lblBmpName.Name = "lblBmpName";
            this.lblBmpName.Size = new System.Drawing.Size(0, 13);
            this.lblBmpName.TabIndex = 9;
            // 
            // lblBmpSize
            // 
            this.lblBmpSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBmpSize.AutoSize = true;
            this.lblBmpSize.Location = new System.Drawing.Point(298, 105);
            this.lblBmpSize.Name = "lblBmpSize";
            this.lblBmpSize.Size = new System.Drawing.Size(0, 13);
            this.lblBmpSize.TabIndex = 9;
            // 
            // lblBmpRect
            // 
            this.lblBmpRect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBmpRect.AutoSize = true;
            this.lblBmpRect.Location = new System.Drawing.Point(417, 105);
            this.lblBmpRect.Name = "lblBmpRect";
            this.lblBmpRect.Size = new System.Drawing.Size(0, 13);
            this.lblBmpRect.TabIndex = 9;
            // 
            // lblBmpColors
            // 
            this.lblBmpColors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBmpColors.AutoSize = true;
            this.lblBmpColors.Location = new System.Drawing.Point(537, 105);
            this.lblBmpColors.Name = "lblBmpColors";
            this.lblBmpColors.Size = new System.Drawing.Size(0, 13);
            this.lblBmpColors.TabIndex = 9;
            // 
            // lblJpgName
            // 
            this.lblJpgName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJpgName.AutoSize = true;
            this.lblJpgName.Location = new System.Drawing.Point(179, 179);
            this.lblJpgName.Name = "lblJpgName";
            this.lblJpgName.Size = new System.Drawing.Size(0, 13);
            this.lblJpgName.TabIndex = 9;
            // 
            // lblJpgSize
            // 
            this.lblJpgSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJpgSize.AutoSize = true;
            this.lblJpgSize.Location = new System.Drawing.Point(298, 179);
            this.lblJpgSize.Name = "lblJpgSize";
            this.lblJpgSize.Size = new System.Drawing.Size(0, 13);
            this.lblJpgSize.TabIndex = 9;
            // 
            // lblJpgRect
            // 
            this.lblJpgRect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJpgRect.AutoSize = true;
            this.lblJpgRect.Location = new System.Drawing.Point(417, 179);
            this.lblJpgRect.Name = "lblJpgRect";
            this.lblJpgRect.Size = new System.Drawing.Size(0, 13);
            this.lblJpgRect.TabIndex = 9;
            // 
            // lblJpgColors
            // 
            this.lblJpgColors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJpgColors.AutoSize = true;
            this.lblJpgColors.Location = new System.Drawing.Point(537, 179);
            this.lblJpgColors.Name = "lblJpgColors";
            this.lblJpgColors.Size = new System.Drawing.Size(0, 13);
            this.lblJpgColors.TabIndex = 9;
            // 
            // lblPngName
            // 
            this.lblPngName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPngName.AutoSize = true;
            this.lblPngName.Location = new System.Drawing.Point(179, 253);
            this.lblPngName.Name = "lblPngName";
            this.lblPngName.Size = new System.Drawing.Size(0, 13);
            this.lblPngName.TabIndex = 9;
            // 
            // lblPngSize
            // 
            this.lblPngSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPngSize.AutoSize = true;
            this.lblPngSize.Location = new System.Drawing.Point(298, 253);
            this.lblPngSize.Name = "lblPngSize";
            this.lblPngSize.Size = new System.Drawing.Size(0, 13);
            this.lblPngSize.TabIndex = 9;
            // 
            // lblPngRect
            // 
            this.lblPngRect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPngRect.AutoSize = true;
            this.lblPngRect.Location = new System.Drawing.Point(417, 253);
            this.lblPngRect.Name = "lblPngRect";
            this.lblPngRect.Size = new System.Drawing.Size(0, 13);
            this.lblPngRect.TabIndex = 9;
            // 
            // lblPngColors
            // 
            this.lblPngColors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPngColors.AutoSize = true;
            this.lblPngColors.Location = new System.Drawing.Point(537, 253);
            this.lblPngColors.Name = "lblPngColors";
            this.lblPngColors.Size = new System.Drawing.Size(0, 13);
            this.lblPngColors.TabIndex = 9;
            // 
            // lblGifName
            // 
            this.lblGifName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGifName.AutoSize = true;
            this.lblGifName.Location = new System.Drawing.Point(179, 329);
            this.lblGifName.Name = "lblGifName";
            this.lblGifName.Size = new System.Drawing.Size(0, 13);
            this.lblGifName.TabIndex = 9;
            // 
            // lblGifSize
            // 
            this.lblGifSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGifSize.AutoSize = true;
            this.lblGifSize.Location = new System.Drawing.Point(298, 329);
            this.lblGifSize.Name = "lblGifSize";
            this.lblGifSize.Size = new System.Drawing.Size(0, 13);
            this.lblGifSize.TabIndex = 9;
            // 
            // lblGifRect
            // 
            this.lblGifRect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGifRect.AutoSize = true;
            this.lblGifRect.Location = new System.Drawing.Point(417, 329);
            this.lblGifRect.Name = "lblGifRect";
            this.lblGifRect.Size = new System.Drawing.Size(0, 13);
            this.lblGifRect.TabIndex = 9;
            // 
            // lblGifColors
            // 
            this.lblGifColors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGifColors.AutoSize = true;
            this.lblGifColors.Location = new System.Drawing.Point(537, 329);
            this.lblGifColors.Name = "lblGifColors";
            this.lblGifColors.Size = new System.Drawing.Size(0, 13);
            this.lblGifColors.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBmpName;
        private System.Windows.Forms.Label lblBmpSize;
        private System.Windows.Forms.Label lblBmpRect;
        private System.Windows.Forms.Label lblBmpColors;
        private System.Windows.Forms.Label lblJpgName;
        private System.Windows.Forms.Label lblJpgSize;
        private System.Windows.Forms.Label lblJpgRect;
        private System.Windows.Forms.Label lblJpgColors;
        private System.Windows.Forms.Label lblPngName;
        private System.Windows.Forms.Label lblPngSize;
        private System.Windows.Forms.Label lblPngRect;
        private System.Windows.Forms.Label lblPngColors;
        private System.Windows.Forms.Label lblGifName;
        private System.Windows.Forms.Label lblGifSize;
        private System.Windows.Forms.Label lblGifRect;
        private System.Windows.Forms.Label lblGifColors;
    }
}

