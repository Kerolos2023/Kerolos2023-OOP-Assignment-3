using System;

class Program
{
    static void Main()
    {
        string?[] phones =
        {
            "01012345678",
            "01212345678",
            "01512345678",
            "+201012345678",
            "02012345678",
            "0101234567",
            "",
            null
        };

        Console.WriteLine("=== Egyptian Phone Validation ===");

        foreach (string? phone in phones)
        {
            Console.WriteLine(
                $"{phone ?? "null"} => {phone.IsValidEgyptianPhone()}"
            );
        }

        string?[] nationalIds =
        {
            "30101011234567",
            "20101011234567",
            "10101011234567",
            "3010101123456",
            "301010112345678",
            "",
            null
        };

        Console.WriteLine("\n=== Egyptian National ID Validation ===");

        foreach (string? nationalId in nationalIds)
        {
            Console.WriteLine(
                $"{nationalId ?? "null"} => {nationalId.IsValidEgyptianNationalId()}"
            );
        }
    }
}
