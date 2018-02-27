namespace Budget
{
    partial class Form1
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
            this.housBtn = new System.Windows.Forms.RadioButton();
            this.grocBtn = new System.Windows.Forms.RadioButton();
            this.entBtn = new System.Windows.Forms.RadioButton();
            this.catLbl = new System.Windows.Forms.Label();
            this.amtLbl = new System.Windows.Forms.Label();
            this.amtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.transBtn = new System.Windows.Forms.RadioButton();
            this.miscBtn = new System.Windows.Forms.RadioButton();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // housBtn
            // 
            this.housBtn.AutoSize = true;
            this.housBtn.Location = new System.Drawing.Point(12, 72);
            this.housBtn.Name = "housBtn";
            this.housBtn.Size = new System.Drawing.Size(81, 21);
            this.housBtn.TabIndex = 0;
            this.housBtn.TabStop = true;
            this.housBtn.Text = "Housing";
            this.housBtn.UseVisualStyleBackColor = true;
            // 
            // grocBtn
            // 
            this.grocBtn.AutoSize = true;
            this.grocBtn.Location = new System.Drawing.Point(12, 99);
            this.grocBtn.Name = "grocBtn";
            this.grocBtn.Size = new System.Drawing.Size(91, 21);
            this.grocBtn.TabIndex = 1;
            this.grocBtn.TabStop = true;
            this.grocBtn.Text = "Groceries";
            this.grocBtn.UseVisualStyleBackColor = true;
            // 
            // entBtn
            // 
            this.entBtn.AutoSize = true;
            this.entBtn.Location = new System.Drawing.Point(12, 126);
            this.entBtn.Name = "entBtn";
            this.entBtn.Size = new System.Drawing.Size(117, 21);
            this.entBtn.TabIndex = 2;
            this.entBtn.TabStop = true;
            this.entBtn.Text = "Entertainment";
            this.entBtn.UseVisualStyleBackColor = true;
            // 
            // catLbl
            // 
            this.catLbl.AutoSize = true;
            this.catLbl.Location = new System.Drawing.Point(28, 32);
            this.catLbl.Name = "catLbl";
            this.catLbl.Size = new System.Drawing.Size(65, 17);
            this.catLbl.TabIndex = 3;
            this.catLbl.Text = "Category";
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Location = new System.Drawing.Point(243, 32);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(56, 17);
            this.amtLbl.TabIndex = 4;
            this.amtLbl.Text = "Amount";
            // 
            // amtBox
            // 
            this.amtBox.Location = new System.Drawing.Point(227, 93);
            this.amtBox.Name = "amtBox";
            this.amtBox.Size = new System.Drawing.Size(100, 22);
            this.amtBox.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(398, 66);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(126, 32);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save Charge";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(79, 250);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(360, 250);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // transBtn
            // 
            this.transBtn.AutoSize = true;
            this.transBtn.Location = new System.Drawing.Point(12, 153);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(122, 21);
            this.transBtn.TabIndex = 9;
            this.transBtn.TabStop = true;
            this.transBtn.Text = "Transportation";
            this.transBtn.UseVisualStyleBackColor = true;
            // 
            // miscBtn
            // 
            this.miscBtn.AutoSize = true;
            this.miscBtn.Location = new System.Drawing.Point(12, 180);
            this.miscBtn.Name = "miscBtn";
            this.miscBtn.Size = new System.Drawing.Size(118, 21);
            this.miscBtn.TabIndex = 10;
            this.miscBtn.TabStop = true;
            this.miscBtn.Text = "Miscellaneous";
            this.miscBtn.UseVisualStyleBackColor = true;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(398, 120);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(126, 35);
            this.checkBtn.TabIndex = 11;
            this.checkBtn.Text = "Check Budget";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 292);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.miscBtn);
            this.Controls.Add(this.transBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.amtBox);
            this.Controls.Add(this.amtLbl);
            this.Controls.Add(this.catLbl);
            this.Controls.Add(this.entBtn);
            this.Controls.Add(this.grocBtn);
            this.Controls.Add(this.housBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton housBtn;
        private System.Windows.Forms.RadioButton grocBtn;
        private System.Windows.Forms.RadioButton entBtn;
        private System.Windows.Forms.Label catLbl;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.TextBox amtBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.RadioButton transBtn;
        private System.Windows.Forms.RadioButton miscBtn;
        private System.Windows.Forms.Button checkBtn;
    }
}

