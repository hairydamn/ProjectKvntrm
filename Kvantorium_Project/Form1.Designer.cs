namespace Kvantorium_Project
{
    partial class FormMenu
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
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonSotrud = new System.Windows.Forms.Button();
            this.buttonPostav = new System.Windows.Forms.Button();
            this.buttonUchetPostav = new System.Windows.Forms.Button();
            this.buttonGetOborud = new System.Windows.Forms.Button();
            this.buttonPeredachaOborud = new System.Windows.Forms.Button();
            this.buttonOborud = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(150, 19);
            this.labelHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(107, 22);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Здравствуй";
            // 
            // buttonSotrud
            // 
            this.buttonSotrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.buttonSotrud.FlatAppearance.BorderSize = 0;
            this.buttonSotrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSotrud.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSotrud.ForeColor = System.Drawing.Color.White;
            this.buttonSotrud.Location = new System.Drawing.Point(12, 259);
            this.buttonSotrud.Name = "buttonSotrud";
            this.buttonSotrud.Size = new System.Drawing.Size(471, 64);
            this.buttonSotrud.TabIndex = 2;
            this.buttonSotrud.Text = "Сотрудники центра";
            this.buttonSotrud.UseVisualStyleBackColor = false;
            this.buttonSotrud.Click += new System.EventHandler(this.buttonSotrud_Click);
            // 
            // buttonPostav
            // 
            this.buttonPostav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.buttonPostav.FlatAppearance.BorderSize = 0;
            this.buttonPostav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostav.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPostav.ForeColor = System.Drawing.Color.White;
            this.buttonPostav.Location = new System.Drawing.Point(12, 337);
            this.buttonPostav.Name = "buttonPostav";
            this.buttonPostav.Size = new System.Drawing.Size(471, 64);
            this.buttonPostav.TabIndex = 3;
            this.buttonPostav.Text = "Поставщики оборудования";
            this.buttonPostav.UseVisualStyleBackColor = false;
            this.buttonPostav.Click += new System.EventHandler(this.buttonPostav_Click);
            // 
            // buttonUchetPostav
            // 
            this.buttonUchetPostav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.buttonUchetPostav.FlatAppearance.BorderSize = 0;
            this.buttonUchetPostav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUchetPostav.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUchetPostav.ForeColor = System.Drawing.Color.White;
            this.buttonUchetPostav.Location = new System.Drawing.Point(12, 495);
            this.buttonUchetPostav.Name = "buttonUchetPostav";
            this.buttonUchetPostav.Size = new System.Drawing.Size(471, 64);
            this.buttonUchetPostav.TabIndex = 4;
            this.buttonUchetPostav.Text = "Учет поставки";
            this.buttonUchetPostav.UseVisualStyleBackColor = false;
            this.buttonUchetPostav.Click += new System.EventHandler(this.buttonUchetPostav_Click);
            // 
            // buttonGetOborud
            // 
            this.buttonGetOborud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.buttonGetOborud.FlatAppearance.BorderSize = 0;
            this.buttonGetOborud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetOborud.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetOborud.ForeColor = System.Drawing.Color.White;
            this.buttonGetOborud.Location = new System.Drawing.Point(12, 575);
            this.buttonGetOborud.Name = "buttonGetOborud";
            this.buttonGetOborud.Size = new System.Drawing.Size(471, 64);
            this.buttonGetOborud.TabIndex = 5;
            this.buttonGetOborud.Text = "Выдача оборудования сотрудникам";
            this.buttonGetOborud.UseVisualStyleBackColor = false;
            this.buttonGetOborud.Click += new System.EventHandler(this.buttonGetOborud_Click);
            // 
            // buttonPeredachaOborud
            // 
            this.buttonPeredachaOborud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.buttonPeredachaOborud.FlatAppearance.BorderSize = 0;
            this.buttonPeredachaOborud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPeredachaOborud.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPeredachaOborud.ForeColor = System.Drawing.Color.White;
            this.buttonPeredachaOborud.Location = new System.Drawing.Point(12, 654);
            this.buttonPeredachaOborud.Name = "buttonPeredachaOborud";
            this.buttonPeredachaOborud.Size = new System.Drawing.Size(471, 76);
            this.buttonPeredachaOborud.TabIndex = 6;
            this.buttonPeredachaOborud.Text = "Передача оборудования между сотрудниками";
            this.buttonPeredachaOborud.UseVisualStyleBackColor = false;
            this.buttonPeredachaOborud.Click += new System.EventHandler(this.buttonPeredachaOborud_Click);
            // 
            // buttonOborud
            // 
            this.buttonOborud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(73)))), ((int)(((byte)(208)))));
            this.buttonOborud.FlatAppearance.BorderSize = 0;
            this.buttonOborud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOborud.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOborud.ForeColor = System.Drawing.Color.White;
            this.buttonOborud.Location = new System.Drawing.Point(12, 415);
            this.buttonOborud.Name = "buttonOborud";
            this.buttonOborud.Size = new System.Drawing.Size(471, 64);
            this.buttonOborud.TabIndex = 8;
            this.buttonOborud.Text = "Оборудование";
            this.buttonOborud.UseVisualStyleBackColor = false;
            this.buttonOborud.Click += new System.EventHandler(this.buttonOborud_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Kvantorium_Project.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 59);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(471, 166);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(498, 756);
            this.Controls.Add(this.buttonOborud);
            this.Controls.Add(this.buttonPeredachaOborud);
            this.Controls.Add(this.buttonGetOborud);
            this.Controls.Add(this.buttonUchetPostav);
            this.Controls.Add(this.buttonPostav);
            this.Controls.Add(this.buttonSotrud);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelHello);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonSotrud;
        private System.Windows.Forms.Button buttonPostav;
        private System.Windows.Forms.Button buttonUchetPostav;
        private System.Windows.Forms.Button buttonGetOborud;
        private System.Windows.Forms.Button buttonPeredachaOborud;
        private System.Windows.Forms.Button buttonOborud;
    }
}

