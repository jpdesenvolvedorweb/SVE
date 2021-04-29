using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Exceptions
{
    public class Message
    {
        private static string Erro;

        public static void Take(string message)
        {
            Erro = message;
        }

        public static string Show()
        {
            return Erro;
        }
    }
}
