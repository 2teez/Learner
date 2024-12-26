
public enum Gender
{
  Male,
  Female,
};

public interface IPerson
{
  void say();
}

class Person : IPerson
{
   private Gender gender;
   private string name;
   private int age;
   public Person(string name, int age, Gender gender)
   {
      this.name = name;
      this.age = age;
      this.gender = gender;
   }

   public Person(): this("John Doe", 23, Gender.Male) {}
   public void say()
   {
       Console.WriteLine("Howdy..");
   }
   public override string ToString()
   {
      return base.ToString() + "{name: " + this.name + " gender: " +
        this.gender + " age: " + this.age + "}";
   }

}

var person = new Person();
Console.WriteLine(person);
var person2 = new Person("java", 23, Gender.Female);
Console.WriteLine(person2);