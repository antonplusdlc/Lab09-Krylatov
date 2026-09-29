int totalExer = 1;

for (int num = 8; num >= totalExer; num--)
{
    Console.WriteLine($"ypr {num}");
}

Console.WriteLine("dz");

for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"kab {room}");
}

int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"ned {week} den {day}");
    }
    Console.WriteLine("^_^");
}

int ticketsCnt = 0;

for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        ticketsCnt++;
        continue;
    }

    Console.WriteLine($"firt avab ticket {ticket}\ntickects propushenno cnt: {ticketsCnt}");
    break;
}

for (; ; )
{
    Console.Write("enter group code (for exit - <<exit>>): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "exit") break;

    Console.WriteLine($"group code {groupCode} writed");
}

Console.WriteLine("shurnal ended");

// A

int N = 50;

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0) continue;

    Console.WriteLine(i);
}

// Б

for (int i = 100; i >= 0; i -= 10)
{
    Console.WriteLine(i);
}

// Индивидуальный вариант 

/*Console.Write("famil: ");
string sur = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(sur))
{
    Console.WriteLine("mo famil");
    return;
}

Random rnd = new Random(sur.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10).OrderBy(_ => rnd.Next()).Take(2).OrderBy(x => x).ToList();

Console.WriteLine($"{assigned[0]}, {assigned[1]}");*/

Console.WriteLine();

// 1 9

int nN = 100;

for (int i = 1; i <= nN; i++)
{
    if (i % 3 != 0) continue;

    Console.WriteLine(i);
}

//9
Console.WriteLine();

int nNn = 100;
int sum = 0;

for (int i = 1; i <= nNn; i++)
{
    if (i % 5 == 0) continue;

    sum += i;
}

Console.WriteLine(sum);

// Дополнительное задание

Console.WriteLine();

Console.Write("enter кол-вл недель тренеровок: ");
int nNnN = int.Parse(Console.ReadLine());
bool isEnough = false;
int trenDays = 0;

for (int week = 1; week <= nNnN && !isEnough; week++) {
    for (int day = 1; day <= 7; day++)
    {
        if (day == 7) continue;
        trenDays++;
        if (trenDays == 20)
        {
            Console.WriteLine($"неделя: {week}, день: {day}");
            isEnough = true;
        }
    }
}