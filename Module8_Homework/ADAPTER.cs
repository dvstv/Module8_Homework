using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== оплата через PayPal ===");
        IPaymentProcessor paypalProcessor = new PayPalPaymentProcessor();
        paypalProcessor.ProcessPayment(5000);
        
        Console.WriteLine("\n=== оплата через Stripe (адаптер) ===");
        StripePaymentService stripeService = new StripePaymentService();
        IPaymentProcessor stripeProcessor = new StripePaymentAdapter(stripeService);
        stripeProcessor.ProcessPayment(7500);
        
        Console.WriteLine("\n=== оплата через Square (адаптер) ===");
        SquarePaymentService squareService = new SquarePaymentService();
        IPaymentProcessor squareProcessor = new SquarePaymentAdapter(squareService);
        squareProcessor.ProcessPayment(3200);
        
        Console.WriteLine("\n=== работа через единый интерфейс ===");
        IPaymentProcessor[] processors = new IPaymentProcessor[]
        {
            new PayPalPaymentProcessor(),
            new StripePaymentAdapter(new StripePaymentService()),
            new SquarePaymentAdapter(new SquarePaymentService())
        };
        
        double amount = 10000;
        foreach (IPaymentProcessor processor in processors)
        {
            processor.ProcessPayment(amount);
            Console.WriteLine();
        }
    }
}

public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"обработка платежа через PayPal");
        Console.WriteLine($"сумма: {amount} тг");
        Console.WriteLine($"комиссия PayPal: {amount * 0.03} тг");
        Console.WriteLine($"платеж успешно обработан через PayPal!");
    }
}

public class StripePaymentService
{
    public void MakeTransaction(double totalAmount)
    {
        Console.WriteLine($"Stripe: создание транзакции");
        Console.WriteLine($"Stripe: сумма транзакции: {totalAmount} тг");
        Console.WriteLine($"Stripe: комиссия: {totalAmount * 0.025} тг");
        Console.WriteLine($"Stripe: транзакция успешно выполнена!");
    }
}

public class StripePaymentAdapter : IPaymentProcessor
{
    private StripePaymentService stripeService;
    
    public StripePaymentAdapter(StripePaymentService stripeService)
    {
        this.stripeService = stripeService;
    }
    
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"адаптер: преобразование вызова для Stripe");
        stripeService.MakeTransaction(amount);
    }
}

public class SquarePaymentService
{
    public void ExecutePayment(double paymentAmount, string currency)
    {
        Console.WriteLine($"Square: выполнение платежа");
        Console.WriteLine($"Square: сумма: {paymentAmount} {currency}");
        Console.WriteLine($"Square: комиссия: {paymentAmount * 0.028} {currency}");
        Console.WriteLine($"Square: платеж успешно проведен!");
    }
}

public class SquarePaymentAdapter : IPaymentProcessor
{
    private SquarePaymentService squareService;
    
    public SquarePaymentAdapter(SquarePaymentService squareService)
    {
        this.squareService = squareService;
    }
    
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"адаптер: преобразование вызова для Square");
        squareService.ExecutePayment(amount, "тг");
    }
}