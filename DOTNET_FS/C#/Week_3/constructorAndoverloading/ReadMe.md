##  Solved questions and answers are uploaded
## 🔹 **Challenges**

### 🏆 Challenge 1: Employee Constructor

Create a class `Employee` with fields: `id`, `name`, and `salary`.

* Add a **constructor** to initialize all fields.
* Create two employee objects and print their details.

---

### 🏆 Challenge 2: Book Overloaded Constructors

Create a class `Book` with fields: `title`, `author`, and `price`.

* Add **three constructors**:

  1. Default (set `"Unknown"` values).
  2. Title + Author (set default price = 500).
  3. Title + Author + Price.
* Create objects using all three constructors and display them.

---

### 🏆 Challenge 3: Car Showroom

Create a class `Car` with fields: `brand`, `model`, `price`.

* Add one constructor with **all three values**.
* Add another constructor that takes only **brand and model** (set default price = 10,00,000).
* Add a method `ShowDetails()` to display values.
* Create at least 3 car objects using different constructors.

---

### 🏆 Challenge 4: Student Database

Create a class `Student` with fields: `rollNo`, `name`, `marks`.

* Use **constructor overloading** to allow creating a student object in 3 ways:

  1. No details → Default rollNo = 0, name = "Unknown", marks = 0.
  2. Only name → Default marks = 50, rollNo = auto-generated (hint: use a static counter).
  3. All details provided.
* Print the student details.

---

### 🏆 Challenge 5 (Advanced): Online Order System

Create a class `Order` with fields: `orderId`, `productName`, `quantity`, `price`.

* Provide multiple constructors:

  * Default (orderId = 0, productName = "Unknown", quantity = 0, price = 0).
  * ProductName + Quantity (price = 100 by default).
  * ProductName + Quantity + Price.
* Add a method `GetTotalAmount()` that returns `quantity * price`.
* Create different objects and print order details + total amount.

---
