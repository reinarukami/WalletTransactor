namespace WalletTransactor
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
			this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StatusRichTextBox
			// 
			this.StatusRichTextBox.Location = new System.Drawing.Point(12, 12);
			this.StatusRichTextBox.Name = "StatusRichTextBox";
			this.StatusRichTextBox.Size = new System.Drawing.Size(710, 291);
			this.StatusRichTextBox.TabIndex = 0;
			this.StatusRichTextBox.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 420);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.StatusRichTextBox);
			this.Name = "Form1";
			this.Text = "Wallet Transactor";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox StatusRichTextBox;
		private System.Windows.Forms.Button button1;
	}
}

