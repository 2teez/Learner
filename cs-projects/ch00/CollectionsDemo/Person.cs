namespace Collect
{
    public class Customer
    {
        private Person cust;
        private Item item;
        public Customer(string name = "", int age = 0, string item = "", decimal price = 0)
        {
            this.cust = new Person(age: age, name: name);
            this.item = new Item(item: item, price: price);
        }
        public Customer(string item = "", decimal price = 0) : this("", 0, item, price) { }
        public Item GetItem
        {
            get => this.item;
        }
        public override string ToString() => $"{this.cust} - {this.item}";

        public class Item
        {
            private string item;
            private decimal price;
            public Item(string item = "", decimal price = 0)
            {
                this.item = item;
                this.price = price;
            }
            public override string ToString() =>
                $"{this.GetType().Name}{{Item: {this.item}, Price: {this.price:C}}}";
        }
        class Person
        {
            private string name;
            private int age;
            public Person(string name = "", int age = 0)
            {
                this.name = name;
                this.age = age;
            }
            public override string ToString() =>
                $"{this.GetType().Name}{{Name: {this.name}, Age: {this.age}}}";
        }
    }
}
