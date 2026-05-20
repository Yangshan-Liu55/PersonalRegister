using System.Collections;
using System.Text;

string? numStr;
Console.Write("Ange antalet anställda: ");
numStr = Console.ReadLine();
if (numStr == null)
{
    return;
}

int num = int.Parse(numStr);
StringBuilder output = new StringBuilder();
ArrayList personnelList = new ArrayList();

for (int i = 1; i <= num; i++)
{
    string? name;
    Console.Write("Ange namn för personalnummer " + i + ": ");
    name = Console.ReadLine();
    string? salary;
    Console.Write("Ange lön för personalnummer " + i + ": ");
    salary = Console.ReadLine();
    Personnel per = new Personnel();
    per.Name = name;
    per.Salary = salary;

    personnelList.Add(per);
}

output.AppendLine("Personallista:");

foreach (Personnel per in personnelList)
{
    output.AppendLine(per.Name + " " + per.Salary);
}

Console.Write(output.ToString());

class Personnel()
{
    public string? Name { get; set;}
    public string? Salary { get; set;}
}