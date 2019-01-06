namespace Using_File
{
    partial class Form_Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Read = new System.Windows.Forms.Button();
            this.Button_Write = new System.Windows.Forms.Button();
            this.Button_Append = new System.Windows.Forms.Button();
            this.Button_Clear_Table = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Input = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Product_ID = new System.Windows.Forms.Label();
            this.Label_Product_Name = new System.Windows.Forms.Label();
            this.Label_Product_Price = new System.Windows.Forms.Label();
            this.Label_Product_Quantity = new System.Windows.Forms.Label();
            this.Text_Product_ID = new System.Windows.Forms.TextBox();
            this.Text_Product_Name = new System.Windows.Forms.TextBox();
            this.Text_Product_Price = new System.Windows.Forms.TextBox();
            this.Text_Product_Quantity = new System.Windows.Forms.TextBox();
            this.List_Table = new System.Windows.Forms.ListView();
            this.Column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_IsNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(752, 504);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Button_Add, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Button_Delete, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Button_Update, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Button_Clear, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Button_Read, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.Button_Write, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.Button_Append, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.Button_Clear_Table, 0, 8);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(564, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 504);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Add.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(10, 10);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(168, 30);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.Text = "add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Delete.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.Location = new System.Drawing.Point(10, 60);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(168, 30);
            this.Button_Delete.TabIndex = 1;
            this.Button_Delete.Text = "delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Update.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.Location = new System.Drawing.Point(10, 110);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(168, 30);
            this.Button_Update.TabIndex = 2;
            this.Button_Update.Text = "update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Clear.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clear.Location = new System.Drawing.Point(10, 160);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(168, 30);
            this.Button_Clear.TabIndex = 3;
            this.Button_Clear.Text = "clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Read
            // 
            this.Button_Read.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Read.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Read.Location = new System.Drawing.Point(10, 260);
            this.Button_Read.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(168, 30);
            this.Button_Read.TabIndex = 4;
            this.Button_Read.Text = "read";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // Button_Write
            // 
            this.Button_Write.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Write.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Write.Location = new System.Drawing.Point(10, 310);
            this.Button_Write.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Write.Name = "Button_Write";
            this.Button_Write.Size = new System.Drawing.Size(168, 30);
            this.Button_Write.TabIndex = 5;
            this.Button_Write.Text = "write";
            this.Button_Write.UseVisualStyleBackColor = true;
            this.Button_Write.Click += new System.EventHandler(this.Button_Write_Click);
            // 
            // Button_Append
            // 
            this.Button_Append.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Append.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Append.Location = new System.Drawing.Point(10, 360);
            this.Button_Append.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Append.Name = "Button_Append";
            this.Button_Append.Size = new System.Drawing.Size(168, 30);
            this.Button_Append.TabIndex = 6;
            this.Button_Append.Text = "append";
            this.Button_Append.UseVisualStyleBackColor = true;
            this.Button_Append.Click += new System.EventHandler(this.Button_Append_Click);
            // 
            // Button_Clear_Table
            // 
            this.Button_Clear_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Clear_Table.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clear_Table.Location = new System.Drawing.Point(10, 410);
            this.Button_Clear_Table.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Clear_Table.Name = "Button_Clear_Table";
            this.Button_Clear_Table.Size = new System.Drawing.Size(168, 30);
            this.Button_Clear_Table.TabIndex = 7;
            this.Button_Clear_Table.Text = "clear table";
            this.Button_Clear_Table.UseVisualStyleBackColor = true;
            this.Button_Clear_Table.Click += new System.EventHandler(this.Button_Clear_Table_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel_Input, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.List_Table, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(564, 504);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel_Input
            // 
            this.tableLayoutPanel_Input.ColumnCount = 2;
            this.tableLayoutPanel_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Input.Controls.Add(this.Label_Product_ID, 0, 0);
            this.tableLayoutPanel_Input.Controls.Add(this.Label_Product_Name, 0, 1);
            this.tableLayoutPanel_Input.Controls.Add(this.Label_Product_Price, 0, 2);
            this.tableLayoutPanel_Input.Controls.Add(this.Label_Product_Quantity, 0, 3);
            this.tableLayoutPanel_Input.Controls.Add(this.Text_Product_ID, 1, 0);
            this.tableLayoutPanel_Input.Controls.Add(this.Text_Product_Name, 1, 1);
            this.tableLayoutPanel_Input.Controls.Add(this.Text_Product_Price, 1, 2);
            this.tableLayoutPanel_Input.Controls.Add(this.Text_Product_Quantity, 1, 3);
            this.tableLayoutPanel_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Input.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Input.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_Input.Name = "tableLayoutPanel_Input";
            this.tableLayoutPanel_Input.RowCount = 4;
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Input.Size = new System.Drawing.Size(564, 201);
            this.tableLayoutPanel_Input.TabIndex = 1;
            // 
            // Label_Product_ID
            // 
            this.Label_Product_ID.AutoSize = true;
            this.Label_Product_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Product_ID.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Product_ID.Location = new System.Drawing.Point(3, 0);
            this.Label_Product_ID.Name = "Label_Product_ID";
            this.Label_Product_ID.Size = new System.Drawing.Size(276, 50);
            this.Label_Product_ID.TabIndex = 0;
            this.Label_Product_ID.Text = "Product ID";
            this.Label_Product_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Product_Name
            // 
            this.Label_Product_Name.AutoSize = true;
            this.Label_Product_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Product_Name.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Product_Name.Location = new System.Drawing.Point(3, 50);
            this.Label_Product_Name.Name = "Label_Product_Name";
            this.Label_Product_Name.Size = new System.Drawing.Size(276, 50);
            this.Label_Product_Name.TabIndex = 1;
            this.Label_Product_Name.Text = "Product Name";
            this.Label_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Product_Price
            // 
            this.Label_Product_Price.AutoSize = true;
            this.Label_Product_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Product_Price.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Product_Price.Location = new System.Drawing.Point(3, 100);
            this.Label_Product_Price.Name = "Label_Product_Price";
            this.Label_Product_Price.Size = new System.Drawing.Size(276, 50);
            this.Label_Product_Price.TabIndex = 2;
            this.Label_Product_Price.Text = "Price";
            this.Label_Product_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Product_Quantity
            // 
            this.Label_Product_Quantity.AutoSize = true;
            this.Label_Product_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Product_Quantity.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Product_Quantity.Location = new System.Drawing.Point(3, 150);
            this.Label_Product_Quantity.Name = "Label_Product_Quantity";
            this.Label_Product_Quantity.Size = new System.Drawing.Size(276, 51);
            this.Label_Product_Quantity.TabIndex = 3;
            this.Label_Product_Quantity.Text = "Quantity";
            this.Label_Product_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Text_Product_ID
            // 
            this.Text_Product_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Product_ID.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Product_ID.Location = new System.Drawing.Point(292, 10);
            this.Text_Product_ID.Margin = new System.Windows.Forms.Padding(10);
            this.Text_Product_ID.Name = "Text_Product_ID";
            this.Text_Product_ID.Size = new System.Drawing.Size(262, 30);
            this.Text_Product_ID.TabIndex = 4;
            this.Text_Product_ID.WordWrap = false;
            // 
            // Text_Product_Name
            // 
            this.Text_Product_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Product_Name.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Product_Name.Location = new System.Drawing.Point(292, 60);
            this.Text_Product_Name.Margin = new System.Windows.Forms.Padding(10);
            this.Text_Product_Name.Name = "Text_Product_Name";
            this.Text_Product_Name.Size = new System.Drawing.Size(262, 30);
            this.Text_Product_Name.TabIndex = 5;
            this.Text_Product_Name.WordWrap = false;
            // 
            // Text_Product_Price
            // 
            this.Text_Product_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Product_Price.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Product_Price.Location = new System.Drawing.Point(292, 110);
            this.Text_Product_Price.Margin = new System.Windows.Forms.Padding(10);
            this.Text_Product_Price.Name = "Text_Product_Price";
            this.Text_Product_Price.Size = new System.Drawing.Size(262, 30);
            this.Text_Product_Price.TabIndex = 6;
            this.Text_Product_Price.WordWrap = false;
            // 
            // Text_Product_Quantity
            // 
            this.Text_Product_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Product_Quantity.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Product_Quantity.Location = new System.Drawing.Point(292, 160);
            this.Text_Product_Quantity.Margin = new System.Windows.Forms.Padding(10);
            this.Text_Product_Quantity.Name = "Text_Product_Quantity";
            this.Text_Product_Quantity.Size = new System.Drawing.Size(262, 30);
            this.Text_Product_Quantity.TabIndex = 7;
            this.Text_Product_Quantity.WordWrap = false;
            // 
            // List_Table
            // 
            this.List_Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_ID,
            this.Column_Name,
            this.Column_Price,
            this.Column_Quantity,
            this.Column_IsNew});
            this.List_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_Table.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Table.FullRowSelect = true;
            this.List_Table.GridLines = true;
            this.List_Table.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.List_Table.Location = new System.Drawing.Point(10, 211);
            this.List_Table.Margin = new System.Windows.Forms.Padding(10);
            this.List_Table.MultiSelect = false;
            this.List_Table.Name = "List_Table";
            this.List_Table.Size = new System.Drawing.Size(544, 283);
            this.List_Table.TabIndex = 2;
            this.List_Table.UseCompatibleStateImageBehavior = false;
            this.List_Table.View = System.Windows.Forms.View.Details;
            this.List_Table.DoubleClick += new System.EventHandler(this.List_Table_DoubleClick);
            // 
            // Column_ID
            // 
            this.Column_ID.Text = "PRODUCT ID";
            // 
            // Column_Name
            // 
            this.Column_Name.Text = "PRODUCT NAME";
            // 
            // Column_Price
            // 
            this.Column_Price.Text = "PRICE";
            // 
            // Column_Quantity
            // 
            this.Column_Quantity.Text = "QUANTITY";
            // 
            // Column_IsNew
            // 
            this.Column_IsNew.Text = "IsNew";
            this.Column_IsNew.Width = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel_Input.ResumeLayout(false);
            this.tableLayoutPanel_Input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Read;
        private System.Windows.Forms.Button Button_Write;
        private System.Windows.Forms.Button Button_Append;
        private System.Windows.Forms.Button Button_Clear_Table;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Input;
        private System.Windows.Forms.Label Label_Product_Name;
        private System.Windows.Forms.Label Label_Product_Price;
        private System.Windows.Forms.Label Label_Product_Quantity;
        private System.Windows.Forms.TextBox Text_Product_ID;
        private System.Windows.Forms.TextBox Text_Product_Name;
        private System.Windows.Forms.TextBox Text_Product_Price;
        private System.Windows.Forms.TextBox Text_Product_Quantity;
        private System.Windows.Forms.Label Label_Product_ID;
        private System.Windows.Forms.ListView List_Table;
        private System.Windows.Forms.ColumnHeader Column_ID;
        private System.Windows.Forms.ColumnHeader Column_Name;
        private System.Windows.Forms.ColumnHeader Column_Price;
        private System.Windows.Forms.ColumnHeader Column_Quantity;
        private System.Windows.Forms.ColumnHeader Column_IsNew;
    }
}

