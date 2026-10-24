# Part 02 — Answers

---

## Reports

- **What was the problem?**

  The three report exporters duplicated the same workflow: loading data, validating it, formatting it, and saving the output. This made the code harder to maintain because changes to the workflow had to be repeated in multiple classes.

- **What did you change?**

  I created an abstract class called `ReportExporter` that contains the common export workflow in one `Export()` method. I moved the shared validation and saving logic into the base class and made `Load()` and `Format()` abstract methods. The three concrete exporters now implement only their specific data loading and formatting logic.

- **Why did you choose that approach?**

  I used the Template Method pattern because all exporters follow the same sequence of steps but differ in how they format the report. An abstract class is a better fit than an interface because it allows the base class to provide shared implementation and control the workflow while requiring subclasses to implement the variable steps.

---

## Enrollment

- **What was the problem?**

  The `Program.cs` file was responsible for creating and calling four services individually in the correct order to enroll a student. This exposed the enrollment workflow to the caller and made it more complicated to use.

- **What did you change?**

  I created an `EnrollmentFacade` class that coordinates the four existing services: `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService`. I added an `Enroll()` method that performs the operations in the original order. Now, `Program.cs` can enroll a student with a single method call.

- **Why did you choose that approach?**

  I used the Facade pattern because it provides a simple interface to a group of services and hides the complexity of coordinating them. This makes the calling code simpler and centralizes the enrollment workflow without modifying the four existing services.