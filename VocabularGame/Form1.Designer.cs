namespace VocabularGame
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddEnglish = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(56, 43);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMainMenu.Size = new System.Drawing.Size(519, 51);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Select the desired action\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play German";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Modify Vocabulary German";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(247, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddEnglish
            // 
            this.btnAddEnglish.Location = new System.Drawing.Point(198, 300);
            this.btnAddEnglish.Name = "btnAddEnglish";
            this.btnAddEnglish.Size = new System.Drawing.Size(247, 40);
            this.btnAddEnglish.TabIndex = 4;
            this.btnAddEnglish.Text = "Modify Vocabulary English";
            this.btnAddEnglish.UseVisualStyleBackColor = true;
            this.btnAddEnglish.Click += new System.EventHandler(this.btnAddEnglish_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Play English";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 483);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddEnglish);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddEnglish;
        private System.Windows.Forms.Button button3;
    }
}

