
namespace PizzaOrderProject
{
    partial class CustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.cancelCustBtn = new System.Windows.Forms.Button();
            this.custIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(164, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(71, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phon Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(71, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(320, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(324, 71);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(194, 29);
            this.nameBox.TabIndex = 2;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.Black;
            this.phoneBox.Location = new System.Drawing.Point(72, 151);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(446, 29);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneBox_KeyDown);
            // 
            // addressbox
            // 
            this.addressbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbox.ForeColor = System.Drawing.Color.Black;
            this.addressbox.Location = new System.Drawing.Point(72, 226);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(446, 29);
            this.addressbox.TabIndex = 4;
            this.addressbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressbox_KeyDown);
            // 
            // addCustBtn
            // 
            this.addCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addCustBtn.ForeColor = System.Drawing.Color.White;
            this.addCustBtn.Location = new System.Drawing.Point(417, 296);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(128, 48);
            this.addCustBtn.TabIndex = 5;
            this.addCustBtn.Text = "Continue";
            this.addCustBtn.UseVisualStyleBackColor = false;
            this.addCustBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelCustBtn
            // 
            this.cancelCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cancelCustBtn.ForeColor = System.Drawing.Color.White;
            this.cancelCustBtn.Location = new System.Drawing.Point(294, 296);
            this.cancelCustBtn.Name = "cancelCustBtn";
            this.cancelCustBtn.Size = new System.Drawing.Size(117, 48);
            this.cancelCustBtn.TabIndex = 6;
            this.cancelCustBtn.Text = "Cancel";
            this.cancelCustBtn.UseVisualStyleBackColor = false;
            this.cancelCustBtn.Click += new System.EventHandler(this.cancelCustBtn_Click);
            // 
            // custIdBox
            // 
            this.custIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.custIdBox.Location = new System.Drawing.Point(77, 71);
            this.custIdBox.Name = "custIdBox";
            this.custIdBox.Size = new System.Drawing.Size(226, 29);
            this.custIdBox.TabIndex = 7;
            this.custIdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custIdBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(73, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.custIdBox);
            this.panel1.Controls.Add(this.cancelCustBtn);
            this.panel1.Controls.Add(this.addCustBtn);
            this.panel1.Controls.Add(this.addressbox);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(497, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 379);
            this.panel1.TabIndex = 0;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1299, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button cancelCustBtn;
        private System.Windows.Forms.TextBox custIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}