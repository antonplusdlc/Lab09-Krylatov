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