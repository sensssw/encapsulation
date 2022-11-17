 

namespace encapsulation
{
    public class Debtor:AbstractPerson
    {
        public Debtor(string name) : base(name) { }
        public override void EarnMoney()
        {
            base.EarnMoney();
        }
        public int Debt { get; set; }
        private int Money { get; set; }
        public void GetMoney() {
            Theft();
            SellKidney();
            Console.WriteLine("Method fired! He's get money");
        }
        private void Theft()
        {
            int rand = new Random().Next(0, 100);
            Money += rand;//объект новый и новый рандом
            Console.WriteLine("{0}Stole {1} money",Name,rand);
        }
        private void SellKidney()
        {
            int rand = new Random().Next(10000, 100000);
            Money += rand;//объект новый и новый рандом
            Console.WriteLine("{0}Sold kidney for {1}",Name,rand);
        }

        public Debtor(string name, int debt, int money):base(name)
        {
            Debt = new Random().Next(10000,10000);
            Money = new Random().Next(0,Debt);
            GetMoney();
        }
         
    }
}
