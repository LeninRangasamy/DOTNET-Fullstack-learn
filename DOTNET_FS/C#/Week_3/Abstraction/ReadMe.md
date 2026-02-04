
---

# Challenges

##  Challenge 1: Shape Area Calculation (Abstract Class)

Create an abstract class Shape with:

1. An abstract method CalculateArea().
2. A non-abstract method DisplayInfo() that prints "This is a shape".
3. Create two child classes Circle and Rectangle that override CalculateArea().
4. In Main(), create objects and calculate/display their areas.



---

## Challenge 2: Payment System (Interface)

Create an interface IPayment with methods:
1. Pay(double amount)
2. Refund(double amount)
   
Implement this interface in two classes:
1. CreditCardPayment
2. PayPalPayment


In Main(), take user input to choose payment type and process a transaction.



---

## Challenge 3: Abstract vs Virtual

Create a class Animal with:

1. A virtual method Eat() that prints "Animal eats food".
2. An abstract method MakeSound().

Create classes Dog and Cat:

1. Override Eat() (optional).
2. Must override MakeSound().

In Main(), test polymorphism by storing objects in an Animal[].


---

## Challenge 4: Multiple Interfaces

Create two interfaces:

1. IPrintable with method Print().
2. IScannable with method Scan().
3. Create a class PrinterScanner that implements both.
4. In Main(), call both methods using interface references.

---

## Challenge 5: Abstract Bank Account

Create an abstract class BankAccount with:

1. A property Balance.
2. An abstract method Withdraw(double amount).
3. A non-abstract method Deposit(double amount).

Create two classes:
1. SavingsAccount (minimum balance check).
2. CurrentAccount (no minimum balance).

In Main(), simulate deposits and withdrawals.



---

## Extra Hard Challenge:
Make a Library Management System where:

1. IReadable interface has Read().
2. Abstract class Book has abstract method GetDetails().
3. Child classes Ebook and PrintedBook implement both.
4. In Main(), create a collection of books and call their methods polymorphically.

