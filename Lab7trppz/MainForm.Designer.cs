namespace Lab7trppz
{
    partial class MainForm
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
            this.PartAddTitle = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartNameTextBox = new System.Windows.Forms.TextBox();
            this.PartMaterialLabel = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.WeightMaterialLabel = new System.Windows.Forms.Label();
            this.PartWeightTextBox = new System.Windows.Forms.TextBox();
            this.tabControl13 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.PartViewDeleteButton = new System.Windows.Forms.Button();
            this.PartViewRightButton = new System.Windows.Forms.Button();
            this.AddedPartMaterialTextBox = new System.Windows.Forms.TextBox();
            this.PartViewLeftButton = new System.Windows.Forms.Button();
            this.AddedPartsLabel = new System.Windows.Forms.Label();
            this.AddedPartWeightTextBox = new System.Windows.Forms.TextBox();
            this.AddedPartNameLabel = new System.Windows.Forms.Label();
            this.AddedWeightMaterialLabel = new System.Windows.Forms.Label();
            this.AddedPartNameTextBox = new System.Windows.Forms.TextBox();
            this.AddedPartMaterialLabel = new System.Windows.Forms.Label();
            this.PartAddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl13.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartAddTitle
            // 
            this.PartAddTitle.AutoSize = true;
            this.PartAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartAddTitle.Location = new System.Drawing.Point(6, 3);
            this.PartAddTitle.Name = "PartAddTitle";
            this.PartAddTitle.Size = new System.Drawing.Size(187, 20);
            this.PartAddTitle.TabIndex = 0;
            this.PartAddTitle.Text = "Додавання деталі:";
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartNameLabel.Location = new System.Drawing.Point(6, 38);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(66, 20);
            this.PartNameLabel.TabIndex = 1;
            this.PartNameLabel.Text = "Назва:";
            // 
            // PartNameTextBox
            // 
            this.PartNameTextBox.Location = new System.Drawing.Point(103, 38);
            this.PartNameTextBox.Name = "PartNameTextBox";
            this.PartNameTextBox.Size = new System.Drawing.Size(115, 22);
            this.PartNameTextBox.TabIndex = 2;
            // 
            // PartMaterialLabel
            // 
            this.PartMaterialLabel.AutoSize = true;
            this.PartMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartMaterialLabel.Location = new System.Drawing.Point(6, 69);
            this.PartMaterialLabel.Name = "PartMaterialLabel";
            this.PartMaterialLabel.Size = new System.Drawing.Size(92, 20);
            this.PartMaterialLabel.TabIndex = 3;
            this.PartMaterialLabel.Text = "Матеріал:";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(105, 69);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(113, 24);
            this.MaterialComboBox.TabIndex = 4;
            // 
            // WeightMaterialLabel
            // 
            this.WeightMaterialLabel.AutoSize = true;
            this.WeightMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightMaterialLabel.Location = new System.Drawing.Point(6, 102);
            this.WeightMaterialLabel.Name = "WeightMaterialLabel";
            this.WeightMaterialLabel.Size = new System.Drawing.Size(54, 20);
            this.WeightMaterialLabel.TabIndex = 5;
            this.WeightMaterialLabel.Text = "Вага:";
            // 
            // PartWeightTextBox
            // 
            this.PartWeightTextBox.Location = new System.Drawing.Point(105, 102);
            this.PartWeightTextBox.Name = "PartWeightTextBox";
            this.PartWeightTextBox.Size = new System.Drawing.Size(115, 22);
            this.PartWeightTextBox.TabIndex = 6;
            // 
            // tabControl13
            // 
            this.tabControl13.Controls.Add(this.tabPage1);
            this.tabControl13.Controls.Add(this.tabPage2);
            this.tabControl13.Location = new System.Drawing.Point(1, 1);
            this.tabControl13.Name = "tabControl13";
            this.tabControl13.SelectedIndex = 0;
            this.tabControl13.Size = new System.Drawing.Size(907, 528);
            this.tabControl13.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.AddProductButton);
            this.tabPage1.Controls.Add(this.PartViewDeleteButton);
            this.tabPage1.Controls.Add(this.PartViewRightButton);
            this.tabPage1.Controls.Add(this.AddedPartMaterialTextBox);
            this.tabPage1.Controls.Add(this.PartViewLeftButton);
            this.tabPage1.Controls.Add(this.AddedPartsLabel);
            this.tabPage1.Controls.Add(this.AddedPartWeightTextBox);
            this.tabPage1.Controls.Add(this.AddedPartNameLabel);
            this.tabPage1.Controls.Add(this.AddedWeightMaterialLabel);
            this.tabPage1.Controls.Add(this.AddedPartNameTextBox);
            this.tabPage1.Controls.Add(this.AddedPartMaterialLabel);
            this.tabPage1.Controls.Add(this.PartAddButton);
            this.tabPage1.Controls.Add(this.PartAddTitle);
            this.tabPage1.Controls.Add(this.PartWeightTextBox);
            this.tabPage1.Controls.Add(this.PartNameLabel);
            this.tabPage1.Controls.Add(this.WeightMaterialLabel);
            this.tabPage1.Controls.Add(this.PartNameTextBox);
            this.tabPage1.Controls.Add(this.MaterialComboBox);
            this.tabPage1.Controls.Add(this.PartMaterialLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Робота з колекціями";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(288, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 446);
            this.panel1.TabIndex = 20;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(348, 438);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(210, 29);
            this.AddProductButton.TabIndex = 19;
            this.AddProductButton.Text = "Додати продукт";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductFormOpener);
            // 
            // PartViewDeleteButton
            // 
            this.PartViewDeleteButton.Location = new System.Drawing.Point(79, 301);
            this.PartViewDeleteButton.Name = "PartViewDeleteButton";
            this.PartViewDeleteButton.Size = new System.Drawing.Size(82, 29);
            this.PartViewDeleteButton.TabIndex = 18;
            this.PartViewDeleteButton.Text = "Видалити";
            this.PartViewDeleteButton.UseVisualStyleBackColor = true;
            this.PartViewDeleteButton.Click += new System.EventHandler(this.PartViewDeleteButtonClick);
            // 
            // PartViewRightButton
            // 
            this.PartViewRightButton.Location = new System.Drawing.Point(167, 301);
            this.PartViewRightButton.Name = "PartViewRightButton";
            this.PartViewRightButton.Size = new System.Drawing.Size(74, 29);
            this.PartViewRightButton.TabIndex = 17;
            this.PartViewRightButton.Text = "Вправо";
            this.PartViewRightButton.UseVisualStyleBackColor = true;
            this.PartViewRightButton.Click += new System.EventHandler(this.PartViewRightButtonClick);
            // 
            // AddedPartMaterialTextBox
            // 
            this.AddedPartMaterialTextBox.Location = new System.Drawing.Point(105, 240);
            this.AddedPartMaterialTextBox.Name = "AddedPartMaterialTextBox";
            this.AddedPartMaterialTextBox.Size = new System.Drawing.Size(115, 22);
            this.AddedPartMaterialTextBox.TabIndex = 16;
            // 
            // PartViewLeftButton
            // 
            this.PartViewLeftButton.Location = new System.Drawing.Point(11, 301);
            this.PartViewLeftButton.Name = "PartViewLeftButton";
            this.PartViewLeftButton.Size = new System.Drawing.Size(61, 29);
            this.PartViewLeftButton.TabIndex = 15;
            this.PartViewLeftButton.Text = "Вліво";
            this.PartViewLeftButton.UseVisualStyleBackColor = true;
            this.PartViewLeftButton.Click += new System.EventHandler(this.PartViewLeftButtonClick);
            // 
            // AddedPartsLabel
            // 
            this.AddedPartsLabel.AutoSize = true;
            this.AddedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddedPartsLabel.Location = new System.Drawing.Point(7, 174);
            this.AddedPartsLabel.Name = "AddedPartsLabel";
            this.AddedPartsLabel.Size = new System.Drawing.Size(258, 20);
            this.AddedPartsLabel.TabIndex = 8;
            this.AddedPartsLabel.Text = "Перелік доданих деталей:";
            // 
            // AddedPartWeightTextBox
            // 
            this.AddedPartWeightTextBox.Location = new System.Drawing.Point(106, 273);
            this.AddedPartWeightTextBox.Name = "AddedPartWeightTextBox";
            this.AddedPartWeightTextBox.Size = new System.Drawing.Size(115, 22);
            this.AddedPartWeightTextBox.TabIndex = 14;
            // 
            // AddedPartNameLabel
            // 
            this.AddedPartNameLabel.AutoSize = true;
            this.AddedPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddedPartNameLabel.Location = new System.Drawing.Point(7, 209);
            this.AddedPartNameLabel.Name = "AddedPartNameLabel";
            this.AddedPartNameLabel.Size = new System.Drawing.Size(66, 20);
            this.AddedPartNameLabel.TabIndex = 9;
            this.AddedPartNameLabel.Text = "Назва:";
            // 
            // AddedWeightMaterialLabel
            // 
            this.AddedWeightMaterialLabel.AutoSize = true;
            this.AddedWeightMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddedWeightMaterialLabel.Location = new System.Drawing.Point(7, 273);
            this.AddedWeightMaterialLabel.Name = "AddedWeightMaterialLabel";
            this.AddedWeightMaterialLabel.Size = new System.Drawing.Size(54, 20);
            this.AddedWeightMaterialLabel.TabIndex = 13;
            this.AddedWeightMaterialLabel.Text = "Вага:";
            // 
            // AddedPartNameTextBox
            // 
            this.AddedPartNameTextBox.Location = new System.Drawing.Point(104, 209);
            this.AddedPartNameTextBox.Name = "AddedPartNameTextBox";
            this.AddedPartNameTextBox.Size = new System.Drawing.Size(115, 22);
            this.AddedPartNameTextBox.TabIndex = 10;
            // 
            // AddedPartMaterialLabel
            // 
            this.AddedPartMaterialLabel.AutoSize = true;
            this.AddedPartMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddedPartMaterialLabel.Location = new System.Drawing.Point(7, 240);
            this.AddedPartMaterialLabel.Name = "AddedPartMaterialLabel";
            this.AddedPartMaterialLabel.Size = new System.Drawing.Size(92, 20);
            this.AddedPartMaterialLabel.TabIndex = 11;
            this.AddedPartMaterialLabel.Text = "Матеріал:";
            // 
            // PartAddButton
            // 
            this.PartAddButton.Location = new System.Drawing.Point(10, 130);
            this.PartAddButton.Name = "PartAddButton";
            this.PartAddButton.Size = new System.Drawing.Size(210, 29);
            this.PartAddButton.TabIndex = 7;
            this.PartAddButton.Text = "Додати деталь";
            this.PartAddButton.UseVisualStyleBackColor = true;
            this.PartAddButton.Click += new System.EventHandler(this.AddPartButtonClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RichTextBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(899, 499);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Записати продукти у файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 529);
            this.Controls.Add(this.tabControl13);
            this.Name = "MainForm";
            this.Text = "Вироблення механізмів";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl13.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PartAddTitle;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.TextBox PartNameTextBox;
        private System.Windows.Forms.Label PartMaterialLabel;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label WeightMaterialLabel;
        private System.Windows.Forms.TextBox PartWeightTextBox;
        private System.Windows.Forms.TabControl tabControl13;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public  System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button PartAddButton;
        private System.Windows.Forms.Button PartViewLeftButton;
        private System.Windows.Forms.Label AddedPartsLabel;
        private System.Windows.Forms.TextBox AddedPartWeightTextBox;
        private System.Windows.Forms.Label AddedPartNameLabel;
        private System.Windows.Forms.Label AddedWeightMaterialLabel;
        private System.Windows.Forms.TextBox AddedPartNameTextBox;
        private System.Windows.Forms.Label AddedPartMaterialLabel;
        private System.Windows.Forms.TextBox AddedPartMaterialTextBox;
        private System.Windows.Forms.Button PartViewDeleteButton;
        private System.Windows.Forms.Button PartViewRightButton;
        private System.Windows.Forms.Button AddProductButton;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

