namespace OOP_GItHub
{
    partial class Shops
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
            this.Recipe = new System.Windows.Forms.Label();
            this.Goods_List = new System.Windows.Forms.ListBox();
            this.Booked_Goods = new System.Windows.Forms.ListBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.Buy_button = new System.Windows.Forms.Button();
            this.Book_button = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.Browse_button = new System.Windows.Forms.Button();
            this.Shops1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Recipe
            // 
            this.Recipe.AutoSize = true;
            this.Recipe.Location = new System.Drawing.Point(426, 62);
            this.Recipe.Name = "Recipe";
            this.Recipe.Size = new System.Drawing.Size(116, 17);
            this.Recipe.TabIndex = 6;
            this.Recipe.Text = "Choose the good";
            this.Recipe.Click += new System.EventHandler(this.Recipe_Click);
            // 
            // Goods_List
            // 
            this.Goods_List.BackColor = System.Drawing.Color.Green;
            this.Goods_List.FormattingEnabled = true;
            this.Goods_List.ItemHeight = 16;
            this.Goods_List.Location = new System.Drawing.Point(359, 82);
            this.Goods_List.Name = "Goods_List";
            this.Goods_List.Size = new System.Drawing.Size(259, 132);
            this.Goods_List.TabIndex = 7;
            this.Goods_List.SelectedIndexChanged += new System.EventHandler(this.Goods_List_SelectedIndexChanged);
            // 
            // Booked_Goods
            // 
            this.Booked_Goods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Booked_Goods.FormattingEnabled = true;
            this.Booked_Goods.ItemHeight = 16;
            this.Booked_Goods.Location = new System.Drawing.Point(37, 229);
            this.Booked_Goods.Name = "Booked_Goods";
            this.Booked_Goods.Size = new System.Drawing.Size(258, 116);
            this.Booked_Goods.TabIndex = 12;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Red;
            this.Delete_button.Location = new System.Drawing.Point(220, 363);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 36);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.Red;
            this.Buy.Location = new System.Drawing.Point(37, 363);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(78, 36);
            this.Buy.TabIndex = 15;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Buy_button
            // 
            this.Buy_button.BackColor = System.Drawing.Color.Red;
            this.Buy_button.Location = new System.Drawing.Point(359, 229);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(75, 36);
            this.Buy_button.TabIndex = 16;
            this.Buy_button.Text = "Buy";
            this.Buy_button.UseVisualStyleBackColor = false;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            // 
            // Book_button
            // 
            this.Book_button.BackColor = System.Drawing.Color.Red;
            this.Book_button.Location = new System.Drawing.Point(543, 229);
            this.Book_button.Name = "Book_button";
            this.Book_button.Size = new System.Drawing.Size(75, 36);
            this.Book_button.TabIndex = 17;
            this.Book_button.Text = "Book";
            this.Book_button.UseVisualStyleBackColor = false;
            this.Book_button.Click += new System.EventHandler(this.Book_button_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtPath.Location = new System.Drawing.Point(37, 82);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(258, 22);
            this.txtPath.TabIndex = 18;
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.Color.Red;
            this.Load_button.Location = new System.Drawing.Point(37, 110);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(75, 36);
            this.Load_button.TabIndex = 19;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = false;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Browse_button
            // 
            this.Browse_button.BackColor = System.Drawing.Color.Red;
            this.Browse_button.Location = new System.Drawing.Point(220, 110);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(75, 36);
            this.Browse_button.TabIndex = 20;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = false;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // Shops1
            // 
            this.Shops1.AutoSize = true;
            this.Shops1.Location = new System.Drawing.Point(106, 62);
            this.Shops1.Name = "Shops1";
            this.Shops1.Size = new System.Drawing.Size(115, 17);
            this.Shops1.TabIndex = 21;
            this.Shops1.Text = "Choose the shop";
            // 
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(648, 421);
            this.Controls.Add(this.Shops1);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.Book_button);
            this.Controls.Add(this.Buy_button);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Booked_Goods);
            this.Controls.Add(this.Goods_List);
            this.Controls.Add(this.Recipe);
            this.Name = "Shops";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recipe;
        private System.Windows.Forms.ListBox Goods_List;
        private System.Windows.Forms.ListBox Booked_Goods;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Button Buy_button;
        private System.Windows.Forms.Button Book_button;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.Label Shops1;
    }
}

