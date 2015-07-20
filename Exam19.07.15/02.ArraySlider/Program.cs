namespace _02.ArraySlider
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine().Replace('\t', ' ');
            string[] nums = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(nums[i]);
            }
            
            string commands = Console.ReadLine();
            int currentPosition = 0;

            while (!commands.Contains("stop"))
            {
                string[] command = commands.Split(' ');
                int offset = int.Parse(command[0]);
                char operation = Char.Parse(command[1]);
                int operand = int.Parse(command[2]);

                if (offset > 0)
                {
                    if ((currentPosition + offset) >= numbers.Length)
                    {
                        offset -= numbers.Length - currentPosition;
                        currentPosition = offset;
                    }
                    else
                    {
                        currentPosition += offset;
                    }
                }

                if (offset < 0)
                {
                    if ((currentPosition + offset) < 0)
                    {
                        offset = numbers.Length + (currentPosition + offset);
                        currentPosition = offset;
                    }
                    else
                    {
                        currentPosition += offset;
                    }
                }



                if (operand > 0)
                {
                    switch (operation)
                    {
                        case '*':
                            numbers[currentPosition] = numbers[currentPosition] * operand;
                            break;
                        case '/':
                            numbers[currentPosition] = numbers[currentPosition] / operand;
                            break;
                        case '+':
                            numbers[currentPosition] = numbers[currentPosition] + operand;
                            break;
                        case '-':
                            numbers[currentPosition] = numbers[currentPosition] - operand;
                            break;
                        case '&':
                            numbers[currentPosition] = numbers[currentPosition] & operand;
                            break;
                        case '|':
                            numbers[currentPosition] = numbers[currentPosition] | operand;
                            break;
                        case '^':
                            numbers[currentPosition] = numbers[currentPosition] ^ operand;
                            break;
                        default:
                            break;
                    }
                }

                commands = Console.ReadLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }

            //remove negative number
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
