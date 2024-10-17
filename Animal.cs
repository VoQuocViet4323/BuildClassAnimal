public abstract class Animal{
    protected string Weight{ get; set; }
    protected string Height{ get; set; }
    public Animal(string Weight, string Height) {
        this.Weight = Weight;
        this.Height = Height;
    }
    public abstract void PrintInfo();
}