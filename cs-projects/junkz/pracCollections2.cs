using System;
using System.Collections;

class CollectionsTest
{
    static void Main(string[] args)
    {
        var cloth = Cloth.GetCloth("Shiht", "Liener", Size.Medium);
        Console.WriteLine(cloth);
        cloth.Size = Size.XXXLarge;
        Console.WriteLine(cloth);
        Console.WriteLine("-------------");
        ClothCollections clothes;
        clothes = new ClothCollections();
        clothes.Add(Cloth.GetCloth("Shiht", "Liener", Size.Medium));
        clothes.Add(Cloth.GetCloth("V-Neck", "Cotton", Size.XLarge));
        clothes.Add(Cloth.GetCloth("Polo", "Cotton", Size.Large));
        foreach (var newCloth in clothes)
        {
            Console.WriteLine(newCloth);
        }
    }
}

class ClothCollections : CollectionBase
{
    public void Add(Cloth cloth) => List.Add(cloth);
    public void Remove(Cloth cloth) => List.Remove(cloth);
    public Cloth this[int index]
    {
        get => (Cloth)List[index];
        set => List[index] = value;
    }
}

enum Size
{
    Medium,
    Large,
    XLarge,
    XXLarge,
    XXXLarge,
}

interface ICloth
{
    Size Size { get; set; }
}
class Cloth : ICloth
{
    private Size size;
    private string material, type;
    private Cloth(string type, string material, Size size = Size.Medium)
    {
        this.material = material;
        this.size = size;
        this.type = type;
    }
    public static Cloth GetCloth(string myType, string myMaterial, Size mySize) =>
              new Cloth(myType, myMaterial, mySize);
    public Size Size
    {
        get => size;
        set
        {
            this.size = value;
        }
    }
    public override string ToString() => $"Cloth{{Type: {type}, Material: {material}, Size: {size}}}";
}
