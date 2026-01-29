namespace leson_27_01_2026_Forms
{
	partial class MainForm
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
			button1 = new Button();
			groupBox1 = new GroupBox();
			bRight = new RadioButton();
			bLeft = new RadioButton();
			bDown = new RadioButton();
			label1 = new Label();
			bUp = new RadioButton();
			button2 = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(12, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(bRight);
			groupBox1.Controls.Add(bLeft);
			groupBox1.Controls.Add(bDown);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(bUp);
			groupBox1.Location = new Point(93, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(695, 426);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// bRight
			// 
			bRight.AutoSize = true;
			bRight.Location = new Point(595, 175);
			bRight.Name = "bRight";
			bRight.Size = new Size(53, 19);
			bRight.TabIndex = 5;
			bRight.TabStop = true;
			bRight.Text = "Right";
			bRight.UseVisualStyleBackColor = true;
			bRight.CheckedChanged += rRirht_CheckedChanged;
			// 
			// bLeft
			// 
			bLeft.AutoSize = true;
			bLeft.Location = new Point(6, 175);
			bLeft.Name = "bLeft";
			bLeft.Size = new Size(45, 19);
			bLeft.TabIndex = 4;
			bLeft.TabStop = true;
			bLeft.Text = "Left";
			bLeft.UseVisualStyleBackColor = true;
			bLeft.CheckedChanged += rLeft_CheckedChanged;
			// 
			// bDown
			// 
			bDown.AutoSize = true;
			bDown.Location = new Point(308, 399);
			bDown.Name = "bDown";
			bDown.Size = new Size(56, 19);
			bDown.TabIndex = 3;
			bDown.TabStop = true;
			bDown.Text = "Down";
			bDown.UseVisualStyleBackColor = true;
			bDown.CheckedChanged += rDown_CheckedChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(293, 175);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// bUp
			// 
			bUp.AutoSize = true;
			bUp.Location = new Point(293, 22);
			bUp.Name = "bUp";
			bUp.Size = new Size(40, 19);
			bUp.TabIndex = 0;
			bUp.TabStop = true;
			bUp.Text = "Up";
			bUp.UseVisualStyleBackColor = true;
			bUp.CheckedChanged += rUp_CheckedChanged;
			// 
			// button2
			// 
			button2.Location = new Point(12, 41);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox1);
			Controls.Add(button1);
			Controls.Add(button2);
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private GroupBox groupBox1;
		private Label label1;
		private Button button2;
		private RadioButton bUp;
		private RadioButton bDown;
		private RadioButton bRight;
		private RadioButton bLeft;
	}
}