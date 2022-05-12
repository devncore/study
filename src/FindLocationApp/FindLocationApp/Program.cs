using System.Diagnostics;

bool result = true;

while (result)
{
    Console.Write("Input process name: ");
    string? name = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(name))
    {
        var apps = Process.GetProcesses().ToList();
        var find = apps.Where(X => X.ProcessName.ToUpper().Contains(name.ToUpper()));

        Console.WriteLine($"Found apps: {find.Count()}");
        foreach (var item in find)
        {
            Console.WriteLine("Name: " + item.ProcessName);
            Console.WriteLine("Path: " + item.MainModule.FileName);
        }
    }
}
