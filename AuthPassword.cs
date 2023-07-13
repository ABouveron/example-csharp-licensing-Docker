namespace example_csharp_licensing_Docker;

public class AuthPassword
{
    public string Password { get; }

    public AuthPassword()
    {
        var pass = string.Empty;
        ConsoleKey key;
        do
        {
            var keyInfo = Console.ReadKey(intercept: true);
            key = keyInfo.Key;

            if (key == ConsoleKey.Backspace && pass.Length > 0)
            {
                Console.Write("\b \b");
                pass = pass[..^1];
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                pass += keyInfo.KeyChar;
            }
        } while (key != ConsoleKey.Enter);

        Password = pass;
    }
}
