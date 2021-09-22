int EmpHrs = 0;
int EmpWage = 0;
int TotalEmployeeWage = 0;

for (int day = 0; day < NUmOfWorkingDays; day++)
{
    Random random = new Random();

    int EmpCheck = random.Next(3);
    switch (EmpCheck)
    {
        case IsPartTime:
            EmpHrs = 4;
            break;

        case IsFullTime:
            EmpHrs = 8;
            break;

        default:
            EmpHrs = 8;
            break;
    }
    EmpWage = EmpHrs * EmpRatePerHour;
    TotalEmployeeWage += EmpWage;
    Console.WriteLine("Emp Wage :" + EmpWage);
}
Console.WriteLine(" Total Emp Wage :" + TotalEmployeeWage);
        }
    }
