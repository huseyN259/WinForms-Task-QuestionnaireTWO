namespace WinForms_Task_QuestionnaireTWO;

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
			this.labelAnket = new System.Windows.Forms.Label();
			this.listBPerson = new System.Windows.Forms.ListBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelSurname = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.maskedTbPhone = new System.Windows.Forms.MaskedTextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBFilename = new System.Windows.Forms.TextBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelListb = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// labelAnket
			// 
			this.labelAnket.BackColor = System.Drawing.Color.Fuchsia;
			this.labelAnket.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelAnket.ForeColor = System.Drawing.Color.Black;
			this.labelAnket.Location = new System.Drawing.Point(61, 49);
			this.labelAnket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelAnket.Name = "labelAnket";
			this.labelAnket.Size = new System.Drawing.Size(497, 582);
			this.labelAnket.TabIndex = 0;
			this.labelAnket.Text = "QUESTIONNAIRE";
			this.labelAnket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelAnket.UseCompatibleTextRendering = true;
			// 
			// listBPerson
			// 
			this.listBPerson.BackColor = System.Drawing.Color.Fuchsia;
			this.listBPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listBPerson.FormattingEnabled = true;
			this.listBPerson.ItemHeight = 24;
			this.listBPerson.Location = new System.Drawing.Point(709, 105);
			this.listBPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBPerson.Name = "listBPerson";
			this.listBPerson.Size = new System.Drawing.Size(256, 364);
			this.listBPerson.TabIndex = 1;
			this.listBPerson.SelectedIndexChanged += new System.EventHandler(this.listBPerson_SelectedIndexChanged);
			// 
			// labelName
			// 
			this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelName.Location = new System.Drawing.Point(113, 172);
			this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(133, 35);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Name";
			// 
			// labelSurname
			// 
			this.labelSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
			this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelSurname.Location = new System.Drawing.Point(113, 243);
			this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSurname.Name = "labelSurname";
			this.labelSurname.Size = new System.Drawing.Size(133, 35);
			this.labelSurname.TabIndex = 2;
			this.labelSurname.Text = "Surname";
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelEmail.Location = new System.Drawing.Point(113, 308);
			this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(133, 35);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "Email";
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelPhone.Location = new System.Drawing.Point(113, 374);
			this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(133, 35);
			this.labelPhone.TabIndex = 2;
			this.labelPhone.Text = "Phone";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
			this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelBirthDate.Location = new System.Drawing.Point(113, 443);
			this.labelBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(133, 35);
			this.labelBirthDate.TabIndex = 2;
			this.labelBirthDate.Text = "BirthDate";
			// 
			// maskedTbPhone
			// 
			this.maskedTbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.maskedTbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.maskedTbPhone.ForeColor = System.Drawing.Color.Gray;
			this.maskedTbPhone.Location = new System.Drawing.Point(257, 374);
			this.maskedTbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.maskedTbPhone.Mask = "(+\\9\\94) 00-000-00-00";
			this.maskedTbPhone.Name = "maskedTbPhone";
			this.maskedTbPhone.Size = new System.Drawing.Size(267, 24);
			this.maskedTbPhone.TabIndex = 3;
			// 
			// textBoxName
			// 
			this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxName.ForeColor = System.Drawing.Color.Gray;
			this.textBoxName.Location = new System.Drawing.Point(256, 172);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(265, 24);
			this.textBoxName.TabIndex = 4;
			this.textBoxName.Text = "Name";
			this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxSurname.ForeColor = System.Drawing.Color.Gray;
			this.textBoxSurname.Location = new System.Drawing.Point(257, 243);
			this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(265, 24);
			this.textBoxSurname.TabIndex = 4;
			this.textBoxSurname.Text = "Surname";
			this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
			this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
			this.textBoxEmail.Location = new System.Drawing.Point(257, 308);
			this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(267, 24);
			this.textBoxEmail.TabIndex = 4;
			this.textBoxEmail.Text = "email@example.com";
			this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
			this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
			// 
			// buttonChange
			// 
			this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonChange.Location = new System.Drawing.Point(256, 504);
			this.buttonChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(120, 49);
			this.buttonChange.TabIndex = 5;
			this.buttonChange.Text = "Change";
			this.buttonChange.UseVisualStyleBackColor = false;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAdd.Location = new System.Drawing.Point(256, 563);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(120, 49);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBFilename
			// 
			this.textBFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.textBFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBFilename.ForeColor = System.Drawing.Color.Gray;
			this.textBFilename.Location = new System.Drawing.Point(709, 480);
			this.textBFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBFilename.Name = "textBFilename";
			this.textBFilename.Size = new System.Drawing.Size(256, 27);
			this.textBFilename.TabIndex = 4;
			this.textBFilename.Text = "Filename";
			this.textBFilename.Enter += new System.EventHandler(this.textBFilename_Enter);
			this.textBFilename.Leave += new System.EventHandler(this.textBFilename_Leave);
			// 
			// buttonLoad
			// 
			this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonLoad.Location = new System.Drawing.Point(709, 523);
			this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(108, 48);
			this.buttonLoad.TabIndex = 5;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = false;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonSave.Location = new System.Drawing.Point(859, 523);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(108, 48);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// labelListb
			// 
			this.labelListb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelListb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelListb.Location = new System.Drawing.Point(709, 70);
			this.labelListb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelListb.Name = "labelListb";
			this.labelListb.Size = new System.Drawing.Size(257, 30);
			this.labelListb.TabIndex = 6;
			this.labelListb.Text = "People List";
			this.labelListb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(259, 443);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(265, 27);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Purple;
			this.ClientSize = new System.Drawing.Size(1067, 692);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.labelListb);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBFilename);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.maskedTbPhone);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelSurname);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.listBPerson);
			this.Controls.Add(this.labelAnket);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Label labelAnket;
	private System.Windows.Forms.ListBox listBPerson;
	private System.Windows.Forms.Label labelName;
	private System.Windows.Forms.Label labelSurname;
	private System.Windows.Forms.Label labelEmail;
	private System.Windows.Forms.Label labelPhone;
	private System.Windows.Forms.Label labelBirthDate;
	private System.Windows.Forms.MaskedTextBox maskedTbPhone;
	private System.Windows.Forms.TextBox textBoxName;
	private System.Windows.Forms.TextBox textBoxSurname;
	private System.Windows.Forms.TextBox textBoxEmail;
	private System.Windows.Forms.Button buttonChange;
	private System.Windows.Forms.Button buttonAdd;
	private System.Windows.Forms.TextBox textBFilename;
	private System.Windows.Forms.Button buttonLoad;
	private System.Windows.Forms.Button buttonSave;
	private System.Windows.Forms.Label labelListb;
	private System.Windows.Forms.DateTimePicker dateTimePicker1;
}