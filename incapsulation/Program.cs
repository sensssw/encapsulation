using encapsulation;

Collector Meruert = new Collector();
Debtor debtor = new Debtor("Shukhrat ");
EvilCollector Dima = new EvilCollector();
Atai atai = new Atai("Atai");
debtor.GetMoney();
Meruert.BreakLegs(debtor);
Dima.BreakHands(debtor);
//var tr = new Triangle(2, 3);
//Console.WriteLine($"Area: {tr.GetArea()}");