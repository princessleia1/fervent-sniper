namespace ArrayOfObjects
{
    class Person
    {
        private string name;
        private int age;
        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}