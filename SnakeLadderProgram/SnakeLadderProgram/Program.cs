using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.RollingDice();
        }
    }
}
