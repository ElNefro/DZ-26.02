namespace DZ_26._02
{
    internal class User
    {
        private string name;
        private string surName;
        private string secondName;
        int age;

        public User(string name, string surName, string secondName, int age)
        {
            this.name = name;
            this.surName = surName;
            this.secondName = secondName;
            this.age = age;
        }

        public void Fio()
        {
            Console.WriteLine($"Name: {name}, Surname: {surName}, Second name: {secondName}, age: {age}\n");
        }
    }
}