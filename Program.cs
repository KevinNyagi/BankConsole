// See https://aka.ms/new-console-template for more information

HttpClient client = new HttpClient();
GetAllTransactions();

Console.WriteLine("Bank - Kevin Nyagi ");
Console.WriteLine("choose user: \n 1. Admin \n 2. Customer");
int user = Convert.ToInt32(Console.ReadLine());

if (user == 1)
{
    Console.WriteLine("Tervetuloa Admin");
    GetAllTransactions();
}
else if (user == 2)
{
    Console.WriteLine("Enter your account number");
    int accountnumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tervetuloa Customer {0}", accountnumber);
    Console.WriteLine("What services are you looking for: \n 1. Monthly Statement \n 2. Cumulative Balance ");
    int service = Convert.ToInt32(Console.ReadLine());


    if (service == 1)
    {
        //code for the monthly balance 
    }
    else if (service == 2)
    {
        //code for the monthly balance 
    }
    else { Console.WriteLine("invalid option, try again "); }
}
else { Console.WriteLine("invalid option. try again "); }


static async Task GetAllTransactions()
{
    HttpClient client = new HttpClient();

    string response = await client.GetStringAsync("");

    Console.WriteLine(response);

}

