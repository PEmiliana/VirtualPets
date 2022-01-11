using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

using static System.Console;


namespace VirtualPets
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;

      

        static void WriteAt(string s, int x, int y)
        {
            //setting up for the displayed text and ascii art
            try
            {
                SetCursorPosition(origCol + x, origRow + y);
                Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Clear();
                WriteLine(e.Message);
            }
        }

       


        static void Main(string[] args)


        {

            Mouse mouse = new Mouse();




            ConsoleKey keypressed = ConsoleKey.Escape;

            while (true)
            {
                //update method
                mouse.Hunger += 1;
                mouse.Mood -= 1;
                if (mouse.Hunger>=70)
                {
                    mouse.Health -= 2;
                }
                

                


                if(KeyAvailable)
                {
                    keypressed = ReadKey().Key;
                    if (keypressed == ConsoleKey.D1)
                    {
                        mouse.Hunger -= 10;
                    }
                    if (keypressed == ConsoleKey.D2)
                    {
                        mouse.Mood += 10;
                    }
                    if (keypressed == ConsoleKey.D3)
                    {
                        mouse.Health += 10;
                    }
                }
                mouse.Update();

                //end of update

                ForegroundColor = ConsoleColor.DarkBlue;
                WriteAt(@" ____   __    __  __    __    ___  _____  ____  ___  _   _  ____", 0, 0);
                WriteAt(@"(_  _) /__\  (  \/  )  /__\  / __)(  _  )(_  _)/ __)( )_( )(_  _)",0,1);
                WriteAt(@"  )(  /(__)\  )    (  /(__)\((  _-.)(_)(   )( ( (__  ) _ (  _)(_", 0, 2);
                WriteAt(@" (__)(__)(__)(_/\/\_)(__)(__)\___/(_____) (__) \___)(_) (_)(____)",0,3);
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.DarkRed;
                WriteAt("Inventory", 55, 6);
                ResetColor();
                ForegroundColor = ConsoleColor.DarkRed;
                WriteAt("Toys", 55, 7);
                WriteAt("Medicine", 55, 8);
                WriteAt("Food", 55, 9);

                BackgroundColor = ConsoleColor.Blue;
                ForegroundColor = ConsoleColor.White;
                WriteAt("Stats", 0, 6);
                ResetColor();
                ForegroundColor = ConsoleColor.DarkYellow;
                WriteAt("Room temperature currently at 22°C", 0, 7);
                ForegroundColor = ConsoleColor.Blue;
                WriteAt("Coins", 0, 8);
                WriteAt($"Pet's Moood = {mouse.Mood}   ", 0, 9);
                WriteAt($"Pets Hunger = {mouse.Hunger}   ", 0, 10);
                WriteAt($"Pets Health = {mouse.Health}   ", 0, 11);

                BackgroundColor = ConsoleColor.Green;
                ForegroundColor = ConsoleColor.White;
                WriteAt("Interactions", 0, 13);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                WriteAt("Feed Pet", 0, 14);
                WriteAt("Play with Pet", 0, 15);
                WriteAt("Tend to Pet", 0, 16);

                BackgroundColor = ConsoleColor.DarkCyan;
                ForegroundColor = ConsoleColor.White;
                WriteAt("Shop", 55, 11);
                ResetColor();
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteAt("Ball", 55, 12);
                WriteAt("Laser Pointer", 55, 13);


                ForegroundColor = ConsoleColor.DarkGray;
                ForegroundColor = ConsoleColor.DarkGray;
                 WriteAt(@"  .---.     .-''-.", 25, 9);
                 WriteAt(@" /.'``\\   / /``'.\", 25, 10);
                 WriteAt(@"|    .-=~~~=-.    |", 25, 11);
                 WriteAt(@" \__           __/   (\", 25, 12);
                 WriteAt(@"   |   6_6     |      ))", 25, 13);
                 WriteAt(@"  =/    Y      \=    //", 25, 14);
                 WriteAt(@"   \   'w'     /    ((", 25, 15);
                 WriteAt(@"   .'-..-.__.-';     \\", 25, 16);
                 WriteAt(@"  /     /o.\    \     \\", 25, 17);
                 WriteAt(@" |    ))) O |    |     ))", 25, 18);
                 WriteAt(@" `.__,.'o' o/    /\   //", 25, 19);
                 WriteAt(@"     _{`._o|    /  | //", 25, 20);
                 WriteAt(@"    / {    ((((/   |//", 25, 21);
                 WriteAt(@"    \ {     /       /", 25, 22);
                 WriteAt(@"     > \____\      |", 25, 23);
                 WriteAt(@"  .-'   /--:-'   .'", 25, 24);
                 WriteAt(@"  ((((--'  ((((--`", 25, 25);
                 WriteAt(@"  ", 25, 26);
                ResetColor();
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;

                ResetColor();
                //WriteLine(simulation);
                Thread.Sleep(500);
               


            }
            
           













        }
        
    }
}
