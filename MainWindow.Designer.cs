namespace InventoryManagementSystem
{
    partial class MainWindow
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
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCustomer = new InventoryManagementSystem.CustomButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOrder = new InventoryManagementSystem.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCategory = new InventoryManagementSystem.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUser = new InventoryManagementSystem.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProduct = new InventoryManagementSystem.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonCustomer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonOrder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 120);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1171, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(67, 5, 108, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ORDERS";
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Image = global::InventoryManagementSystem.Properties.Resources.Customer;
            this.buttonCustomer.Img = global::InventoryManagementSystem.Properties.Resources.Customer;
            this.buttonCustomer.ImgHover = global::InventoryManagementSystem.Properties.Resources.Customer_hover;
            this.buttonCustomer.Location = new System.Drawing.Point(588, 29);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(75, 20, 75, 5);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(48, 48);
            this.buttonCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(979, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(59, 5, 66, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "USERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(758, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(48, 5, 58, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CATEGORIES";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Image = global::InventoryManagementSystem.Properties.Resources.Order;
            this.buttonOrder.Img = global::InventoryManagementSystem.Properties.Resources.Order;
            this.buttonOrder.ImgHover = global::InventoryManagementSystem.Properties.Resources.Order_hover;
            this.buttonOrder.Location = new System.Drawing.Point(1182, 29);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(75, 20, 120, 5);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(48, 48);
            this.buttonOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonOrder.TabIndex = 5;
            this.buttonOrder.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(561, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(51, 5, 47, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CUSTOMERS";
            // 
            // buttonCategory
            // 
            this.buttonCategory.Image = global::InventoryManagementSystem.Properties.Resources.Category;
            this.buttonCategory.Img = global::InventoryManagementSystem.Properties.Resources.Category;
            this.buttonCategory.ImgHover = global::InventoryManagementSystem.Properties.Resources.Category_hover;
            this.buttonCategory.Location = new System.Drawing.Point(786, 29);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(75, 20, 75, 5);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(48, 48);
            this.buttonCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCategory.TabIndex = 3;
            this.buttonCategory.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(369, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(369, 5, 50, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRODUCTS";
            // 
            // buttonUser
            // 
            this.buttonUser.Image = global::InventoryManagementSystem.Properties.Resources.Users;
            this.buttonUser.Img = global::InventoryManagementSystem.Properties.Resources.Users;
            this.buttonUser.ImgHover = global::InventoryManagementSystem.Properties.Resources.Users_hover;
            this.buttonUser.Location = new System.Drawing.Point(984, 29);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(75, 20, 75, 5);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(48, 48);
            this.buttonUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonUser.TabIndex = 4;
            this.buttonUser.TabStop = false;
            this.buttonUser.Click += new System.EventHandler(this.ButtonUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(50, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(50, 10, 100, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Image = global::InventoryManagementSystem.Properties.Resources.Product;
            this.buttonProduct.Img = global::InventoryManagementSystem.Properties.Resources.Product;
            this.buttonProduct.ImgHover = global::InventoryManagementSystem.Properties.Resources.Product_hover;
            this.buttonProduct.Location = new System.Drawing.Point(390, 29);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(50, 20, 75, 5);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(48, 48);
            this.buttonProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonProduct.TabIndex = 1;
            this.buttonProduct.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 7, 1069, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 701);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 28);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 120);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1350, 581);
            this.panelMain.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private CustomButton buttonOrder;
        private CustomButton buttonUser;
        private CustomButton buttonCategory;
        private CustomButton buttonCustomer;
        private CustomButton buttonProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
