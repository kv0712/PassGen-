Console.WriteLine("enter your password lengthenter your password length");
if (int.TryParse(Console.ReadLine(), out int passwordLength))
{
    List<string> symbol = [ "0123456789",
                        "abcdefghijklmnopqrstuvwxyz",
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                        "!@#$%^&*" ];
    int symbolLength = 0;

    for (int i = 0; i < symbol.Count; i++)
    {
        symbolLength += symbol[i].Length;
    }

    if (passwordLength >= 8 && passwordLength <= symbolLength)
    {

        Random rnd = new Random();
        string password = "";
        int count = symbol.Count;
        int randomFromCount = rnd.Next(count);
        int randomFromLength = rnd.Next(symbol[randomFromCount].Length);
        password += symbol[randomFromCount][randomFromLength];

        for (int i = 0; i < passwordLength - 1; i++)
        {
            randomFromCount = rnd.Next(count);
            randomFromLength = rnd.Next(symbol[randomFromCount].Length);
            bool isInsert = true;
            for (int j = 0; j < password.Length; j++)
            {
                if (symbol[randomFromCount][randomFromLength] == password[j])
                {
                    isInsert = false;
                    break;
                }
            }
            if (isInsert)
                password += symbol[randomFromCount][randomFromLength];
            else i--;
        }
        System.Console.WriteLine(password);

    }
    else Console.WriteLine("Invalid password length");
}
else Console.WriteLine("ERROR");