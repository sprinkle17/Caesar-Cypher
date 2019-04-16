namespace Caesar_Cipher
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
            this.textBoxKeyValue = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.checkBoxDecrypt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKeyValue
            // 
            this.textBoxKeyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyValue.Location = new System.Drawing.Point(226, 11);
            this.textBoxKeyValue.Name = "textBoxKeyValue";
            this.textBoxKeyValue.Size = new System.Drawing.Size(168, 26);
            this.textBoxKeyValue.TabIndex = 1;
            this.textBoxKeyValue.Text = "Key Value (1-20):";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 64);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(673, 127);
            this.textBoxInput.TabIndex = 2;
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEncrypt.Location = new System.Drawing.Point(12, 13);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(82, 24);
            this.checkBoxEncrypt.TabIndex = 3;
            this.checkBoxEncrypt.Text = "Encrypt";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            // 
            // checkBoxDecrypt
            // 
            this.checkBoxDecrypt.AutoSize = true;
            this.checkBoxDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDecrypt.Location = new System.Drawing.Point(125, 13);
            this.checkBoxDecrypt.Name = "checkBoxDecrypt";
            this.checkBoxDecrypt.Size = new System.Drawing.Size(83, 24);
            this.checkBoxDecrypt.TabIndex = 4;
            this.checkBoxDecrypt.Text = "Decrypt";
            this.checkBoxDecrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message:";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(12, 217);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(673, 144);
            this.listBoxOutput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result:";
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(409, 11);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(135, 26);
            this.buttonGo.TabIndex = 8;
            this.buttonGo.Text = "Press to Cypher";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(550, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 26);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 373);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDecrypt);
            this.Controls.Add(this.checkBoxEncrypt);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxKeyValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxKeyValue;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.CheckBox checkBoxEncrypt;
        private System.Windows.Forms.CheckBox checkBoxDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonExit;
    }
}

