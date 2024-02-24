public class User
{
	private string _name;
	private int _age;
	private string _sex;
	private int _weight;

	public User(string name, int age, string sex, int weight)
	{
		_name = name;
		_age = age;
		_sex = sex;
		_weight = weight;
	}

	public void DisplayUserDetails()
	{
		Console.WriteLine("User Details:");
		Console.WriteLine($"Name: {_name}");
		Console.WriteLine($"Age: {_age}");
		Console.WriteLine($"Sex: {_sex}");
		Console.WriteLine($"Weight: {_weight} kg");
	}
}