using Newtonsoft.Json;

namespace WinForms_Task_QuestionnaireTWO;

public partial class Form1 : Form
{
	Database database = new Database();
	Person person = new Person();

	public Form1()
	{
		InitializeComponent();

		listBPerson.DisplayMember = "Name";
		listBPerson.Items.AddRange(database.GetPeopleList().ToArray());
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
		person = new Person();
		listBPerson.Items.Clear();
		Point pointTemp = buttonChange.Location;
		buttonChange.Location = buttonAdd.Location;
		buttonAdd.Location = pointTemp;
		person.Name = textBoxName.Text;
		person.Surname = textBoxSurname.Text;
		person.Email = textBoxEmail.Text;
		person.Phone = maskedTbPhone.Text;
		person.BirthDate = dateTimePicker1.Value;
		database.Add(database.GetPerson(person));
		listBPerson.DisplayMember = "Name";
		listBPerson.Items.AddRange(database.GetPeopleList().ToArray());
	}

	private void buttonChange_Click(object sender, EventArgs e)
	{
		Point pointTemp = buttonChange.Location;
		buttonChange.Location = buttonAdd.Location;
		buttonAdd.Location = pointTemp;

		if (textBFilename.Text == "Filename")
			textBFilename.ForeColor = Color.Gray;

		var itemp = listBPerson.SelectedItem as Person;
		database.Remove(itemp);
		listBPerson.Items.Clear();
		listBPerson.DisplayMember = "Name";
		listBPerson.Items.AddRange(database.GetPeopleList().ToArray());
	}

	public bool CheckAccessToProgram { get; set; }
	private void listBPerson_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (CheckAccessToProgram)
		{
			Person? person = listBPerson.SelectedItem as Person;
			textBoxName.Text = person?.Name;
			textBoxSurname.Text = person?.Surname;
			textBoxEmail.Text = person?.Email;
			maskedTbPhone.Text = person?.Phone;
			dateTimePicker1.Value = person.BirthDate;
		}

		CheckAccessToProgram = true;
	}

	public string Filename { get; set; }
	private void buttonLoad_Click(object sender, EventArgs e)
	{
		Filename = textBFilename.Text;
		if (File.Exists(Filename))
		{
			string result = File.ReadAllText(Filename);
			var list = JsonConvert.DeserializeObject<List<Person>>(result);
			database.SetList(list);
			listBPerson.DataSource = database.GetPeopleList();
		}
		else
			MessageBox.Show($"{Filename} --> this file does not exist !", "ALERT");
	}

	private void buttonSave_Click(object sender, EventArgs e)
	{
		Filename = textBFilename.Text;
		var result = JsonConvert.SerializeObject(database.GetPeopleList());
		File.WriteAllText(Filename, result);
	}

	private void textBoxName_Enter(object sender, EventArgs e)
	{
		if (textBoxName.Text == "Name")
			textBoxName.Text = String.Empty;
		else
			textBoxName.ForeColor = Color.Black;
	}

	private void textBoxName_Leave(object sender, EventArgs e)
	{
		if (textBoxName.Text == String.Empty)
			textBoxName.Text = "Name";
		else
			textBoxName.ForeColor = Color.Black;
	}

	private void textBoxSurname_Enter(object sender, EventArgs e)
	{
		if (textBoxSurname.Text == "Surname")
			textBoxSurname.Text = String.Empty;
		else
			textBoxSurname.ForeColor = Color.Black;
	}

	private void textBoxSurname_Leave(object sender, EventArgs e)
	{
		if (textBoxSurname.Text == String.Empty)
			textBoxSurname.Text = "Surname";
		else
			textBoxSurname.ForeColor = Color.Black;
	}

	private void textBoxEmail_Enter(object sender, EventArgs e)
	{
		if (textBoxEmail.Text == "email@example.com")
			textBoxEmail.Text = String.Empty;
		else
			textBoxEmail.ForeColor = Color.Black;
	}

	private void textBoxEmail_Leave(object sender, EventArgs e)
	{
		if (textBoxEmail.Text == String.Empty)
			textBoxEmail.Text = "email@example.com";
		else
			textBoxEmail.ForeColor = Color.Black;
	}

	private void textBFilename_Enter(object sender, EventArgs e)
	{
		if (textBFilename.Text == "Filename")
			textBFilename.Text = String.Empty;
		else
			textBFilename.ForeColor = Color.Black;
	}

	private void textBFilename_Leave(object sender, EventArgs e)
	{
		if (textBFilename.Text == String.Empty)
			textBFilename.Text = "Filename";
		else
			textBFilename.ForeColor = Color.Black;
	}
}