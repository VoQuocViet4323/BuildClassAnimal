public class Cat : Animal{
    private string name{ get; set; }
    public Cat(string Weight, string Height,string name):base(Weight,Height)
    {
        this.name = name;
    }
    public override void PrintInfo()
     {
          Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.name);
     }
}