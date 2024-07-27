using System;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using DotNet8ConsoleApp.ReadFromCsvFile.Models;

using (var reader = new StreamReader("Data/data.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var lst = csv.GetRecords<CsvModel>().ToList();
    foreach (var record in lst)
    {
        Console.WriteLine($"ID: {record.ID}");
        Console.WriteLine($"IDName {record.Name}");
        Console.WriteLine($"Email: {record.Email}");
        Console.WriteLine("-------------------");
    }
}

Console.ReadKey();
