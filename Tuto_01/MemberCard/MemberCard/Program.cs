using System;

class Member
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNo { get; set; }
    public string MemberCardID { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("\nResult =>");
        Console.WriteLine("Member Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone No.: " + PhoneNo);
        Console.WriteLine("Member Card ID: " + MemberCardID);
    }
}

class Program
{
    static void Main()
    {
        int memberCount = 1;

        while (true)
        {
            Member newMember = new Member();

            Console.Write("Type \"Member Name\" for input 1, and then press Enter: ");
            newMember.Name = Console.ReadLine();

            Console.Write("Type \"Email\" for input 2, and then press Enter: ");
            newMember.Email = Console.ReadLine();

            Console.Write("Type \"Phone No.\" for input 3, and then press Enter: ");
            newMember.PhoneNo = Console.ReadLine();

            newMember.MemberCardID = $"MC-{memberCount:D4}";
            newMember.DisplayInfo();

            Console.Write("Type \"E\" for \"Exit\" or \"N\" for the next entry: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "E")
            {
                break;
            }

            memberCount++;
        }
    }
}