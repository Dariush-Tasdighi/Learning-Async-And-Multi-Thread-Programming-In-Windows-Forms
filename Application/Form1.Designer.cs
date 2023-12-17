namespace Application
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
			numberLabel = new System.Windows.Forms.Label();
			startButton = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// numberLabel
			// 
			numberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			numberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			numberLabel.Location = new System.Drawing.Point(12, 44);
			numberLabel.Name = "numberLabel";
			numberLabel.Size = new System.Drawing.Size(358, 300);
			numberLabel.TabIndex = 1;
			numberLabel.Text = "Number";
			numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// startButton
			// 
			startButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			startButton.Location = new System.Drawing.Point(12, 12);
			startButton.Name = "startButton";
			startButton.Size = new System.Drawing.Size(358, 29);
			startButton.TabIndex = 0;
			startButton.Text = "&Start";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += StartButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(382, 353);
			Controls.Add(numberLabel);
			Controls.Add(startButton);
			Name = "Form1";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Form (1)";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Label numberLabel;
		private System.Windows.Forms.Button startButton;
	}
}