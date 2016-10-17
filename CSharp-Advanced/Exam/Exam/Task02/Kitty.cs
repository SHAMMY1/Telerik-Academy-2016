using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Kitty
    {
        static void Main()
        {
            var map = Console.ReadLine().ToCharArray();
            var jumps = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int position = 0;
            int souls = 0;
            int food = 0;
            int deadlocks = 0;
            int jumpsCount = 0;

            switch (map[0])
            {
                case '@':
                    souls++;
                    map[position] = ' ';
                    break;
                case '*':
                    food++;
                    map[position] = ' ';
                    break;
                case 'x':
                    Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumpsCount);
                    return;
                default:
                    break;
            }

            for (int i = 0; i < jumps.Length; i++)
            {
                jumpsCount++;
                int jump = jumps[i];
                position = (position + jump) % map.Length;



                if (position < 0)
                {
                    position += map.Length;
                }

                //if (jump > 0)
                //{
                //    for (int j = 0; j < jump; j++)
                //    {
                //        position++;
                //        if (position >= map.Length)
                //        {
                //            position = 0;
                //        }
                //    }
                //}
                //else
                //{
                //    jump = jump * -1;
                //    for (int j = 0; j < jump; j++)
                //    {
                //        position--;
                //        if (position < 0)
                //        {
                //            position = map.Length - 1;
                //        }
                //    }
                //}

                switch (map[position])
                {
                    case '@':
                        souls++;
                        map[position] = ' ';
                        break;
                    case '*':
                        food++;
                        map[position] = ' ';
                        break;
                    case 'x':
                        {
                            if (position % 2 == 0)
                            {
                                souls--;
                                map[position] = '@';
                            }
                            else
                            {
                                food--;
                                map[position] = '*';
                            }
                            deadlocks++;


                        }
                        break;
                    default:
                        break;
                }

                if (food < 0 || souls < 0)
                {
                    Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumpsCount);
                    return;

                }
            }

            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);


        }
    }
}

