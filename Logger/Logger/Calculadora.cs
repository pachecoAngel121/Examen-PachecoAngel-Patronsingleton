using System;

namespace Logger
{
    public class Calculadora
    {
        private readonly Logger _logger;

        public Calculadora()
        {
            _logger = Logger.GetLogger();
        }

        public void Divide(int a, int b)
        {
            try
            {
                var result = a / b;
                Console.WriteLine(result);
            }
            catch (Exception exception)
            {
                _logger.Log(exception.Message);
            }
        }
    }
}
