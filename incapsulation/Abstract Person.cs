 namespace encapsulation
{
    public abstract class AbstractPerson
    {
        public string Name{ get; set; }
        public virtual void EarnMoney()//virtual можно поменять под нужды класса
        {
            int money = 0;
            money += 10;
        }

        public  AbstractPerson(string name)
        {
            Name =name;
            Console.WriteLine($"His name is {Name} ");
        }

        //method2
    }
}
