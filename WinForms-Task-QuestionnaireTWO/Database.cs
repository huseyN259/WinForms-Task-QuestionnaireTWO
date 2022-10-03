class Database
{
	private List<Person> people = new List<Person>()
	{
		new Person()
		{
			Name = "Huseyn",
			Surname = "Ibrahimov",
			Email = "huseyn@gmail.com",
			Phone = "0000000000",
			BirthDate = new DateTime(2003, 5, 9)
		},
		new Person()
		{
			Name = "Nuran",
			Surname = "Huseynova",
			Email = "nuran@gmail.com",
			Phone = "0000000000",
			BirthDate = new DateTime(2003, 4, 25)
		}
	};
	public Person GetPerson(Person person)
	{
		return person;
	}

	public void Add(Person person)
	{
		people.Add(person);
	}

	public void Remove(Person person)
	{
		people.Remove(person);
	}

	public void SetList(List<Person> peoplelist)
	{
		people = peoplelist;
	}

	public List<Person> GetPeopleList()
	{
		return people;
	}
}