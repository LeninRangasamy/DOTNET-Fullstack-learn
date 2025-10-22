## 🔹 Challenge 1: Constructor Chaining with `this` and `base`

Create two classes:

* **Person** (parent) with fields `name`, `age`.
* **Student** (child) with field `grade`.

👉 Requirements:

1. `Person` should have a constructor `(string name, int age)`.
2. `Student` should call the parent constructor using `base`.
3. Add another constructor in `Student` that takes only `name`, and uses `this` to call the first `Student` constructor with default values.
4. Write a `Show()` method to print all details.

---

## 🔹 Challenge 2: Method Hiding vs Overriding

Make classes:

* **Animal** → `public virtual void Sound()` prints `"Animal sound"`.
* **Dog** → Override `Sound()` to print `"Dog barks"`.
* **Cat** → Hide `Sound()` (using `new`) to print `"Cat meows"`.

👉 Test by:

* Creating objects of `Dog` and `Cat`.
* Also storing them in an `Animal` reference and calling `Sound()`.
* Observe the difference between **override** vs **new**.

---

## 🔹 Challenge 3: Base and This Together

Create classes:

* **Vehicle** → has a constructor `(string type)` that prints `"Vehicle: <type>"`.
* **Car** → has constructors:

  1. `(string type, string model)` → calls base constructor with type.
  2. `(string model)` → uses `this("Car", model)` to set default type as `"Car"`.

👉 Print `"Model: <model>"` inside child constructor.
Check what happens when you create objects with both constructors.

---

## 🔹 Challenge 4: Multiple Children

Create a parent class **Shape** with method `public virtual void Draw()`.
Then:

* **Circle** overrides `Draw()` to print `"Drawing Circle"`.
* **Square** overrides `Draw()` to print `"Drawing Square"`.

👉 Store objects in a `Shape[]` array and loop through to call `Draw()`.
(This is **polymorphism in action**).

---

## 🔹 Challenge 5: Mixing Protected + Base

Make a parent class **Employee** with:

* `protected string company = "ABC Corp";`
* `public void ShowCompany()` → prints company name.

Child class **Manager** should:

* Use `base.company` inside a method to print `"Manager works at ABC Corp"`.

👉 Create an object of Manager and test.

---
