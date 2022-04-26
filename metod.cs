public class metod
{ 
    info i = new info();
    public void Menu()
    {
        Submenu();
    }

    public void Submenu()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("tedad khab ha ra vared konid");
        Console.ResetColor();
        Taskht();

        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("option ra entekhab konid (dar sorat nakhastan 0 ra vared konid)");
        System.Console.WriteLine("vip====> (1)");
        System.Console.WriteLine("vige===> (2)");
        Console.ResetColor();

        Check();
    }

    public void Taskht()
    {
        int c = Convert.ToInt32(Console.ReadLine());
        i.tdadKhab=c;
    }

    public void Check()
    {
        int check = Convert.ToInt32(Console.ReadLine());

        int add;
        if (check == 1)
        {
            add = 200000;
        }
        else if (check == 2)
        {
            add = 150000;
        }
        else
        {
            add = 0;
        }
        Price(add);
        

    }
    public void Price(int add)
    {
        
        int price = i.tdadKhab * 150000;
        price += add;
        i.price=price;
        facktor();
    }

    public void facktor()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.WriteLine("mablagh ghabel pardakht : " + i.price);
        Console.ResetColor();
    }
}