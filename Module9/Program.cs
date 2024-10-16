using System;

namespace Module9_1;

public class CustomException : Exception // собственное исключание
{
    public CustomException(string message) : base(message) { } // без реализации, потому что я всё же плохо понимаю, какие ещё нестандартные исключаеня могу предусмотреть
}

internal class Program
{
    static void Main(string[] args)
    {
        Exception[] excpts = new Exception[]
        {
            new DivideByZeroException(),
            new ArgumentNullException("Argument is null"),
            new IndexOutOfRangeException(),
            new CustomException("This is a custom exception"),
            new InvalidOperationException()
        };

        foreach (var expt in excpts)
        {
            try
            {
                throw expt;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Seems like you try to divide by zero");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Аrgument is null: {ex}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of bounds");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестное исключение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally, some good f**king food");
            }
        }

    }

}
