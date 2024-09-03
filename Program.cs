using LabirintusCLI;

LabSim labsim = new("Lab1.txt");
//Console.WriteLine("5. feladat: labirintus adatai:");
//Console.WriteLine($"oszlopok szama: {labsim.OszlopokSzama}");
//Console.WriteLine($"sorok szama: {labsim.SorokSzama}");
//Console.WriteLine($"kijarat indexe: " +
//    $"s:{labsim.KijaratSorIndex}, " +
//    $"o:{labsim.KijaratOszlopIndex}");

labsim.Utkereses();