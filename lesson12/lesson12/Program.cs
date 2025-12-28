namespace lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter login, password and confirmation:");
            Console.Write("Login: ");
            string _login = Console.ReadLine();
            Console.Write("Password: ");
            string _password = Console.ReadLine();
            Console.Write("Confirm Password: ");
            string _confirmPassword = Console.ReadLine();

            try
            {
                MyClasses.Authentification.Validate(_login, _password, _confirmPassword);
                Console.WriteLine("You have successfully logged in!");
            }
            catch (Exceptions.WrongLoginException ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
            }
            catch (Exceptions.WrongPasswordException ex)
            {
                Console.WriteLine($"Password error: {ex.Message}");
            }
            catch (Exceptions.WrongPasswordConfirmationException ex)
            {
                Console.WriteLine($"Password confirmation error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
