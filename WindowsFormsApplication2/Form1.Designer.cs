namespace WindowsFormsApplication2
{
    partial class formheading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formheading));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yesbutton = new System.Windows.Forms.Button();
            this.nobutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(294, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to create a new password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(440, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click on one of the buttons below";
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.PeachPuff;
            this.yesbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton.ForeColor = System.Drawing.Color.Tomato;
            this.yesbutton.Location = new System.Drawing.Point(510, 575);
            this.yesbutton.Margin = new System.Windows.Forms.Padding(5);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(126, 63);
            this.yesbutton.TabIndex = 2;
            this.yesbutton.Text = "Yes";
            this.yesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            this.yesbutton.MouseLeave += new System.EventHandler(this.yesbutton_leave);
            this.yesbutton.MouseHover += new System.EventHandler(this.yesbutton_hover);
            // 
            // nobutton
            // 
            this.nobutton.BackColor = System.Drawing.Color.PeachPuff;
            this.nobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nobutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobutton.ForeColor = System.Drawing.Color.Tomato;
            this.nobutton.Location = new System.Drawing.Point(728, 575);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(127, 63);
            this.nobutton.TabIndex = 3;
            this.nobutton.Text = "No";
            this.nobutton.UseVisualStyleBackColor = false;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click);
            this.nobutton.MouseLeave += new System.EventHandler(this.nobutton_leave);
            this.nobutton.MouseHover += new System.EventHandler(this.nobutton_hover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4388, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // formheading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nobutton);
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "formheading";
            this.Text = "Beshield";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.formheading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Label label3;
    }
}

