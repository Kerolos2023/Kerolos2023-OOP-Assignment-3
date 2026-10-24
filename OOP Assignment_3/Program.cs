using OOP_Assignment_3.Refactoring.Part_01;
using RefactoringLab;
using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;
using RefactoringLab.Part03.BlockedUsers;
using RefactoringLab.Part03.Students;

namespace OOP_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IShippingCarrier[] carriers = new IShippingCarrier[]
            //{
            //    new AramexCarrier(),
            //    new FedExCarrier(),
            //    new DhlCarrier()
            //};

            //ShippingCostCalculator calculator = new ShippingCostCalculator(carriers);
            //decimal cost = calculator.CalculateShippingCost(new AramexCarrier(), 10);
            //Console.WriteLine(cost);

            //INotificationChannel email =
            //new UrgentNotification(
            //new EmailNotification());

            //email.Send("user@example.com", "Your order is confirmed");


            //var repo = new SqlOrderRepository();
            //var Email = new SmtpEmailSender();

            //var processor = new OrderProcessor(repo, Email);

            //processor.Process(101, "customer@example.com");

            //Console.WriteLine("=== Reports ===");

            //var outDir = Path.Combine(
            //    Path.GetTempPath(),
            //    "refactoring-lab-part02");

            //Directory.CreateDirectory(outDir);

            //new CsvReportExporter().Export(
            //    Path.Combine(outDir, "report.csv"));

            //new JsonReportExporter().Export(
            //    Path.Combine(outDir, "report.json"));

            //new TextReportExporter().Export(
            //    Path.Combine(outDir, "report.txt"));

            //Console.WriteLine($"Wrote reports to {outDir}");
            //Console.WriteLine();

            //Console.WriteLine("=== Enrollment ===");

            //var studentId = "S100";
            //var courseId = "CS201";
            //var amount = 1500m;

            //var enrollment = new EnrollmentFacade();

            //enrollment.Enroll(studentId, courseId, amount);


            Console.WriteLine("=== Blocked users ===");

            const int blockedCount = 50_000;
            const int requestCount = 5_000;

            var blockedIds = BlockedUserChecker.BuildBlockedIds(blockedCount);
            var requestIds = BlockedUserChecker.BuildRequestIds(requestCount, blockedCount);

            var ms = BlockedUserChecker.MeasureAverageMs(
                blockedIds, requestIds, 10, out var found);

            Console.WriteLine(
                $"blockedIds={blockedCount}, requests={requestCount}, " +
                $"found={found}, average time={ms:F2} ms");

            Console.WriteLine();

            Console.WriteLine("=== Students (1_000_000) ===");

            var printed = 0;

            foreach (var student in StudentCatalog.GetAllStudents())
            {
                Console.WriteLine($"{student.Id}: {student.Name}");

                printed++;

                if (printed == 3)
                    break;
            }

            Console.WriteLine($"printed={printed}");


        }
    }
}
