
using System.Windows.Forms;

namespace CustomDGV
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Margin = new Padding(0, 3, -2, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "v";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Margin =  new Padding(0, 2, 0, 0);
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;


            panel.ColumnCount = 2;
            panel.RowCount = 1;

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            textBox1.Dock = DockStyle.Fill;
            //button1.Dock = DockStyle.Fill;

            panel.Controls.Add(textBox1, 0, 0);
            panel.Controls.Add(button1, 1, 0);

            panel.Dock = DockStyle.Fill;

            this.Controls.Add(this.panel);

            //this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(panel.Size.Width, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
