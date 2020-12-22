using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace chess
{
    //Стратегія
    public interface IComputerPlayer
    {
        void MakeMove();
    }
    //Конкретна стратегія
    public class EasyComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer choose easy strategy for beginner");
        }
    }
    public class MediumComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer choose medium strategy for amateur");
        }
    }
    public class AdvancedComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer choose advanced strategy for pro");
        }
    }
    
    public class Game
    {
        public IComputerPlayer computerPlayer;
        public void Move()
        {
            computerPlayer.MakeMove(); //exhibit the behavior
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.computerPlayer = new EasyComputerPlayer();
            g.Move();
            g.computerPlayer = new MediumComputerPlayer();
            g.Move();
            g.computerPlayer = new AdvancedComputerPlayer();
            g.Move();
            Console.ReadKey();
        }
    }
}