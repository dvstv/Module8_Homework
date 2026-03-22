
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("=== заказ 1: простой эспрессо ===");
//         Beverage beverage1 = new Espresso();
//         Console.WriteLine($"{beverage1.GetDescription()}");
//         Console.WriteLine($"стоимость: {beverage1.Cost()} тг\n");
        
//         Console.WriteLine("=== заказ 2: эспрессо с молоком и сахаром ===");
//         Beverage beverage2 = new Espresso();
//         beverage2 = new Milk(beverage2);
//         beverage2 = new Sugar(beverage2);
//         Console.WriteLine($"{beverage2.GetDescription()}");
//         Console.WriteLine($"стоимость: {beverage2.Cost()} тг\n");
        
//         Console.WriteLine("=== заказ 3: латте с взбитыми сливками и карамелью ===");
//         Beverage beverage3 = new Latte();
//         beverage3 = new WhippedCream(beverage3);
//         beverage3 = new Caramel(beverage3);
//         Console.WriteLine($"{beverage3.GetDescription()}");
//         Console.WriteLine($"стоимость: {beverage3.Cost()} тг\n");
        
//         Console.WriteLine("=== заказ 4: мокка с молоком, сахаром и шоколадом ===");
//         Beverage beverage4 = new Mocha();
//         beverage4 = new Milk(beverage4);
//         beverage4 = new Sugar(beverage4);
//         beverage4 = new Chocolate(beverage4);
//         Console.WriteLine($"{beverage4.GetDescription()}");
//         Console.WriteLine($"стоимость: {beverage4.Cost()} тг\n");
        
//         Console.WriteLine("=== заказ 5: чай с молоком и ванилью ===");
//         Beverage beverage5 = new Tea();
//         beverage5 = new Milk(beverage5);
//         beverage5 = new Vanilla(beverage5);
//         Console.WriteLine($"{beverage5.GetDescription()}");
//         Console.WriteLine($"стоимость: {beverage5.Cost()} тг");
//     }
// }

// public abstract class Beverage
// {
//     public abstract string GetDescription();
//     public abstract double Cost();
// }

// public class Espresso : Beverage
// {
//     public override string GetDescription()
//     {
//         return "эспрессо";
//     }
    
//     public override double Cost()
//     {
//         return 500;
//     }
// }

// public class Tea : Beverage
// {
//     public override string GetDescription()
//     {
//         return "чай";
//     }
    
//     public override double Cost()
//     {
//         return 300;
//     }
// }

// public class Latte : Beverage
// {
//     public override string GetDescription()
//     {
//         return "латте";
//     }
    
//     public override double Cost()
//     {
//         return 700;
//     }
// }

// public class Mocha : Beverage
// {
//     public override string GetDescription()
//     {
//         return "мокка";
//     }
    
//     public override double Cost()
//     {
//         return 800;
//     }
// }

// public abstract class BeverageDecorator : Beverage
// {
//     protected Beverage beverage;
    
//     public BeverageDecorator(Beverage beverage)
//     {
//         this.beverage = beverage;
//     }
// }

// public class Milk : BeverageDecorator
// {
//     public Milk(Beverage beverage) : base(beverage)
//     {
//     }
    
//     public override string GetDescription()
//     {
//         return beverage.GetDescription() + ", молоко";
//     }
    
//     public override double Cost()
//     {
//         return beverage.Cost() + 100;
//     }
// }

// public class Sugar : BeverageDecorator
// {
//     public Sugar(Beverage beverage) : base(beverage)
//     {
//     }
    
//     public override string GetDescription()
//     {
//         return beverage.GetDescription() + ", сахар";
//     }
    
//     public override double Cost()
//     {
//         return beverage.Cost() + 30;
//     }
// }

// public class WhippedCream : BeverageDecorator
// {
//     public WhippedCream(Beverage beverage) : base(beverage)
//     {
//     }
    
//     public override string GetDescription()
//     {
//         return beverage.GetDescription() + ", взбитые сливки";
//     }
    
//     public override double Cost()
//     {
//         return beverage.Cost() + 150;
//     }
// }

// public class Caramel : BeverageDecorator
// {
//     public Caramel(Beverage beverage) : base(beverage)
//     {
//     }
    
//     public override string GetDescription()
//     {
//         return beverage.GetDescription() + ", карамель";
//     }
    
//     public override double Cost()
//     {
//         return beverage.Cost() + 120;
//     }
// }

// public class Chocolate : BeverageDecorator
// {
//     public Chocolate(Beverage beverage) : base(beverage)
//     {
//     }
    
//     public override string GetDescription()
//     {
//         return beverage.GetDescription() + ", шоколад";
//     }
    
//     public override double Cost()
//     {
//         return beverage.Cost() + 140;
//     }
// }

// public class Vanilla : BeverageDecorator
// {
//     public Vanilla(Beverage beverage) : base(beverage)
//     {
//     }
    
//     public override string GetDescription()
//     {
//         return beverage.GetDescription() + ", ваниль";
//     }
    
//     public override double Cost()
//     {
//         return beverage.Cost() + 110;
//     }
// }