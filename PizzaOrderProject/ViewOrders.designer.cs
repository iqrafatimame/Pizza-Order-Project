
namespace PizzaOrderProject
{
    partial class viewOrder
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
            this.components = new System.ComponentModel.Container();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new PizzaOrderProject.Database1DataSet1();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.cUSTOMERSTableAdapter = new PizzaOrderProject.Database1DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.cUSTOMERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKORDERScustID6FE99F9FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERSTableAdapter = new PizzaOrderProject.Database1DataSet1TableAdapters.ORDERSTableAdapter();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srchCustBox = new System.Windows.Forms.TextBox();
            this.srchCustBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKORDERScustID6FE99F9FBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // sizeCombo
            // 
            this.sizeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Items.AddRange(new object[] {
            "8 ",
            "12",
            "14 ",
            "16 "});
            this.sizeCombo.Location = new System.Drawing.Point(997, 30);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(273, 32);
            this.sizeCombo.TabIndex = 5;
            this.sizeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERSBindingSource1
            // 
            this.cUSTOMERSBindingSource1.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource1.DataSource = this.database1DataSet1BindingSource;
            // 
            // cUSTOMERSBindingSource2
            // 
            this.cUSTOMERSBindingSource2.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource2.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1BindingSource1
            // 
            this.database1DataSet1BindingSource1.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource1.Position = 0;
            // 
            // cUSTOMERSBindingSource3
            // 
            this.cUSTOMERSBindingSource3.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource3.DataSource = this.database1DataSet1BindingSource1;
            // 
            // fKORDERScustID6FE99F9FBindingSource
            // 
            this.fKORDERScustID6FE99F9FBindingSource.DataMember = "FK__ORDERS__custID__6FE99F9F";
            this.fKORDERScustID6FE99F9FBindingSource.DataSource = this.cUSTOMERSBindingSource3;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.database1DataSet1BindingSource1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 574);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by Pizza Size";
            // 
            // srchCustBox
            // 
            this.srchCustBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchCustBox.ForeColor = System.Drawing.Color.Black;
            this.srchCustBox.Location = new System.Drawing.Point(284, 27);
            this.srchCustBox.Name = "srchCustBox";
            this.srchCustBox.Size = new System.Drawing.Size(302, 29);
            this.srchCustBox.TabIndex = 4;
            this.srchCustBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // srchCustBtn
            // 
            this.srchCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.srchCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchCustBtn.ForeColor = System.Drawing.Color.White;
            this.srchCustBtn.Location = new System.Drawing.Point(596, 25);
            this.srchCustBtn.Name = "srchCustBtn";
            this.srchCustBtn.Size = new System.Drawing.Size(176, 32);
            this.srchCustBtn.TabIndex = 6;
            this.srchCustBtn.Text = "Search";
            this.srchCustBtn.UseVisualStyleBackColor = false;
            this.srchCustBtn.Click += new System.EventHandler(this.srchCustBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.srchCustBtn);
            this.panel1.Controls.Add(this.srchCustBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 80);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // viewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sizeCombo);
            this.Controls.Add(this.panel1);
            this.Name = "viewOrder";
            this.Text = "viewOrder";
            this.Load += new System.EventHandler(this.viewOrder_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKORDERScustID6FE99F9FBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private Database1DataSet1TableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource2;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource3;
        private System.Windows.Forms.BindingSource fKORDERScustID6FE99F9FBindingSource;
        private Database1DataSet1TableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srchCustBox;
        private System.Windows.Forms.Button srchCustBtn;
        private System.Windows.Forms.Panel panel1;
    }
}