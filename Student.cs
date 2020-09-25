public class Student
    {
        private string name;
        private int age;

        //todo Example of using private fields with a getter and a setter method

        public string GetName()
        {
            if (age >= 18)
            {
                return name;
            }

            return "This student is too young";
        }

        public void SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                name = newName;
            }
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newAge)
        {
            if (newAge > 0)
            {
                age = newAge;
            }
        }
    }
