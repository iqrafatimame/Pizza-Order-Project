
namespace PizzaOrderProject
{
    partial class OrderDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderNoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.garlicBox = new System.Windows.Forms.CheckBox();
            this.spinachBox = new System.Windows.Forms.CheckBox();
            this.jalapenoBox = new System.Windows.Forms.CheckBox();
            this.mushroomBox = new System.Windows.Forms.CheckBox();
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.peperoniBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.quantityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cnfrmOrder = new System.Windows.Forms.Button();
            this.cancelOrdBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.orderIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custIdBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.orderNoLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(274, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 65);
            this.panel1.TabIndex = 1;
            // 
            // orderNoLbl
            // 
            this.orderNoLbl.AutoSize = true;
            this.orderNoLbl.ForeColor = System.Drawing.Color.White;
            this.orderNoLbl.Location = new System.Drawing.Point(477, 13);
            this.orderNoLbl.Name = "orderNoLbl";
            this.orderNoLbl.Size = new System.Drawing.Size(0, 13);
            this.orderNoLbl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "-- Place Your Order --";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizza Size (Inches)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(33, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 28);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "8";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(162, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 28);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "12";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(307, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 28);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "14";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(459, 53);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 28);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "16";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(274, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 105);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.garlicBox);
            this.panel3.Controls.Add(this.spinachBox);
            this.panel3.Controls.Add(this.jalapenoBox);
            this.panel3.Controls.Add(this.mushroomBox);
            this.panel3.Controls.Add(this.cheeseBox);
            this.panel3.Controls.Add(this.peperoniBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(274, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 208);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // garlicBox
            // 
            this.garlicBox.AutoSize = true;
            this.garlicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garlicBox.Location = new System.Drawing.Point(419, 152);
            this.garlicBox.Name = "garlicBox";
            this.garlicBox.Size = new System.Drawing.Size(151, 28);
            this.garlicBox.TabIndex = 7;
            this.garlicBox.Text = "Roasted Garlic";
            this.garlicBox.UseVisualStyleBackColor = true;
            // 
            // spinachBox
            // 
            this.spinachBox.AutoSize = true;
            this.spinachBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinachBox.Location = new System.Drawing.Point(419, 110);
            this.spinachBox.Name = "spinachBox";
            this.spinachBox.Size = new System.Drawing.Size(98, 28);
            this.spinachBox.TabIndex = 7;
            this.spinachBox.Text = "Spinach";
            this.spinachBox.UseVisualStyleBackColor = true;
            // 
            // jalapenoBox
            // 
            this.jalapenoBox.AutoSize = true;
            this.jalapenoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jalapenoBox.Location = new System.Drawing.Point(419, 71);
            this.jalapenoBox.Name = "jalapenoBox";
            this.jalapenoBox.Size = new System.Drawing.Size(106, 28);
            this.jalapenoBox.TabIndex = 7;
            this.jalapenoBox.Text = "Jalapeno";
            this.jalapenoBox.UseVisualStyleBackColor = true;
            // 
            // mushroomBox
            // 
            this.mushroomBox.AutoSize = true;
            this.mushroomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mushroomBox.Location = new System.Drawing.Point(54, 152);
            this.mushroomBox.Name = "mushroomBox";
            this.mushroomBox.Size = new System.Drawing.Size(120, 28);
            this.mushroomBox.TabIndex = 7;
            this.mushroomBox.Text = "Mushroom";
            this.mushroomBox.UseVisualStyleBackColor = true;
            // 
            // cheeseBox
            // 
            this.cheeseBox.AutoSize = true;
            this.cheeseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheeseBox.Location = new System.Drawing.Point(54, 110);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(143, 28);
            this.cheeseBox.TabIndex = 7;
            this.cheeseBox.Text = "Extra Cheese";
            this.cheeseBox.UseVisualStyleBackColor = true;
            // 
            // peperoniBox
            // 
            this.peperoniBox.AutoSize = true;
            this.peperoniBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peperoniBox.Location = new System.Drawing.Point(54, 71);
            this.peperoniBox.Name = "peperoniBox";
            this.peperoniBox.Size = new System.Drawing.Size(117, 28);
            this.peperoniBox.TabIndex = 7;
            this.peperoniBox.Text = "Pepperoni";
            this.peperoniBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toppings (Rs. 125 each)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.quantityBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(274, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 107);
            this.panel4.TabIndex = 7;
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.FormattingEnabled = true;
            this.quantityBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.quantityBox.Location = new System.Drawing.Point(267, 37);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(320, 32);
            this.quantityBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // cnfrmOrder
            // 
            this.cnfrmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cnfrmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnfrmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnfrmOrder.ForeColor = System.Drawing.Color.White;
            this.cnfrmOrder.Location = new System.Drawing.Point(768, 569);
            this.cnfrmOrder.Name = "cnfrmOrder";
            this.cnfrmOrder.Size = new System.Drawing.Size(186, 49);
            this.cnfrmOrder.TabIndex = 8;
            this.cnfrmOrder.Text = "Confirm Order";
            this.cnfrmOrder.UseVisualStyleBackColor = false;
            this.cnfrmOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelOrdBtn
            // 
            this.cancelOrdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelOrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOrdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrdBtn.ForeColor = System.Drawing.Color.White;
            this.cancelOrdBtn.Location = new System.Drawing.Point(635, 569);
            this.cancelOrdBtn.Name = "cancelOrdBtn";
            this.cancelOrdBtn.Size = new System.Drawing.Size(122, 49);
            this.cancelOrdBtn.TabIndex = 8;
            this.cancelOrdBtn.Text = "Cancel";
            this.cancelOrdBtn.UseVisualStyleBackColor = false;
            this.cancelOrdBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order ID";
            // 
            // orderIdBox
            // 
            this.orderIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdBox.Location = new System.Drawing.Point(740, 81);
            this.orderIdBox.Name = "orderIdBox";
            this.orderIdBox.Size = new System.Drawing.Size(220, 27);
            this.orderIdBox.TabIndex = 10;
            this.orderIdBox.MouseLeave += new System.EventHandler(this.orderIdBox_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Id";
            // 
            // custIdBox
            // 
            this.custIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIdBox.Location = new System.Drawing.Point(407, 81);
            this.custIdBox.Name = "custIdBox";
            this.custIdBox.Size = new System.Drawing.Size(210, 27);
            this.custIdBox.TabIndex = 10;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1351, 697);
            this.Controls.Add(this.custIdBox);
            this.Controls.Add(this.orderIdBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelOrdBtn);
            this.Controls.Add(this.cnfrmOrder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox garlicBox;
        private System.Windows.Forms.CheckBox spinachBox;
        private System.Windows.Forms.CheckBox jalapenoBox;
        private System.Windows.Forms.CheckBox mushroomBox;
        private System.Windows.Forms.CheckBox cheeseBox;
        private System.Windows.Forms.CheckBox peperoniBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox quantityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cnfrmOrder;
        private System.Windows.Forms.Button cancelOrdBtn;
        private System.Windows.Forms.Label orderNoLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custIdBox;
    }
}