namespace TempatureConverter {
	partial class TempatureConverterForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.fahrenheitLabel = new System.Windows.Forms.Label();
			this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
			this.cOutLabel = new System.Windows.Forms.Label();
			this.convertFtoCButton = new System.Windows.Forms.Button();
			this.convertCtoFButton = new System.Windows.Forms.Button();
			this.fOutLabel = new System.Windows.Forms.Label();
			this.celsiusTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// fahrenheitLabel
			// 
			this.fahrenheitLabel.ForeColor = System.Drawing.Color.White;
			this.fahrenheitLabel.Location = new System.Drawing.Point(18, 14);
			this.fahrenheitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.fahrenheitLabel.Name = "fahrenheitLabel";
			this.fahrenheitLabel.Size = new System.Drawing.Size(256, 20);
			this.fahrenheitLabel.TabIndex = 0;
			this.fahrenheitLabel.Text = "Fahrenheit (°F) to Celsius (°C)";
			this.fahrenheitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fahrenheitTextBox
			// 
			this.fahrenheitTextBox.BackColor = System.Drawing.Color.White;
			this.fahrenheitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fahrenheitTextBox.Location = new System.Drawing.Point(18, 37);
			this.fahrenheitTextBox.MaxLength = 10;
			this.fahrenheitTextBox.Name = "fahrenheitTextBox";
			this.fahrenheitTextBox.Size = new System.Drawing.Size(115, 18);
			this.fahrenheitTextBox.TabIndex = 1;
			this.fahrenheitTextBox.Text = "74";
			this.fahrenheitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.fahrenheitTextBox.WordWrap = false;
			// 
			// cOutLabel
			// 
			this.cOutLabel.ForeColor = System.Drawing.Color.White;
			this.cOutLabel.Location = new System.Drawing.Point(131, 37);
			this.cOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.cOutLabel.Name = "cOutLabel";
			this.cOutLabel.Size = new System.Drawing.Size(143, 20);
			this.cOutLabel.TabIndex = 2;
			this.cOutLabel.Text = "= 23.33°C";
			// 
			// convertFtoCButton
			// 
			this.convertFtoCButton.BackColor = System.Drawing.Color.White;
			this.convertFtoCButton.FlatAppearance.BorderSize = 0;
			this.convertFtoCButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.convertFtoCButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.convertFtoCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertFtoCButton.ForeColor = System.Drawing.Color.Black;
			this.convertFtoCButton.Location = new System.Drawing.Point(18, 61);
			this.convertFtoCButton.Name = "convertFtoCButton";
			this.convertFtoCButton.Size = new System.Drawing.Size(256, 26);
			this.convertFtoCButton.TabIndex = 3;
			this.convertFtoCButton.Text = "Convert";
			this.convertFtoCButton.UseVisualStyleBackColor = false;
			this.convertFtoCButton.Click += new System.EventHandler(this.convertFtoCButton_Click);
			// 
			// convertCtoFButton
			// 
			this.convertCtoFButton.BackColor = System.Drawing.Color.White;
			this.convertCtoFButton.FlatAppearance.BorderSize = 0;
			this.convertCtoFButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.convertCtoFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.convertCtoFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertCtoFButton.ForeColor = System.Drawing.Color.Black;
			this.convertCtoFButton.Location = new System.Drawing.Point(18, 166);
			this.convertCtoFButton.Name = "convertCtoFButton";
			this.convertCtoFButton.Size = new System.Drawing.Size(256, 26);
			this.convertCtoFButton.TabIndex = 7;
			this.convertCtoFButton.Text = "Convert";
			this.convertCtoFButton.UseVisualStyleBackColor = false;
			this.convertCtoFButton.Click += new System.EventHandler(this.convertCtoFButton_Click);
			// 
			// fOutLabel
			// 
			this.fOutLabel.ForeColor = System.Drawing.Color.White;
			this.fOutLabel.Location = new System.Drawing.Point(131, 142);
			this.fOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.fOutLabel.Name = "fOutLabel";
			this.fOutLabel.Size = new System.Drawing.Size(143, 20);
			this.fOutLabel.TabIndex = 6;
			this.fOutLabel.Text = "= 73.99°F";
			// 
			// celsiusTextBox
			// 
			this.celsiusTextBox.BackColor = System.Drawing.Color.White;
			this.celsiusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.celsiusTextBox.Location = new System.Drawing.Point(18, 142);
			this.celsiusTextBox.MaxLength = 10;
			this.celsiusTextBox.Name = "celsiusTextBox";
			this.celsiusTextBox.Size = new System.Drawing.Size(115, 18);
			this.celsiusTextBox.TabIndex = 5;
			this.celsiusTextBox.Text = "23.33";
			this.celsiusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.celsiusTextBox.WordWrap = false;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(18, 119);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Celsius (°C) to Fahrenheit (°F)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TempatureConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(292, 218);
			this.Controls.Add(this.convertCtoFButton);
			this.Controls.Add(this.fOutLabel);
			this.Controls.Add(this.celsiusTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.convertFtoCButton);
			this.Controls.Add(this.cOutLabel);
			this.Controls.Add(this.fahrenheitTextBox);
			this.Controls.Add(this.fahrenheitLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "TempatureConverterForm";
			this.Text = "Tempature Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fahrenheitLabel;
		private System.Windows.Forms.TextBox fahrenheitTextBox;
		private System.Windows.Forms.Label cOutLabel;
		private System.Windows.Forms.Button convertFtoCButton;
		private System.Windows.Forms.Button convertCtoFButton;
		private System.Windows.Forms.Label fOutLabel;
		private System.Windows.Forms.TextBox celsiusTextBox;
		private System.Windows.Forms.Label label3;
	}
}