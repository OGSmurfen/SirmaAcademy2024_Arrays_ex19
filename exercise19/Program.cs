using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Enter the array to start modifications on:");

        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int input = 0;

        

        while (input != 6)
        {
            Console.WriteLine($"1. Add Element (to end of array)");
            Console.WriteLine("2. Remove {number} from array");
            Console.WriteLine("3. Remove number at {index}");
            Console.WriteLine("4. Insert {number} at {index}");
            Console.WriteLine($"5. Display array");
            Console.WriteLine($"6. Exit");

            
            input = int.Parse( Console.ReadLine() );


            switch( input )
            {
                case 1:
                    {
                        int[] newArr = new int[arr.Length + 1];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            newArr[i] = arr[i];
                        }
                        Console.WriteLine("Write element to be added:");
                        int el = int.Parse( Console.ReadLine() );
                        newArr[newArr.Length - 1] = el;


                        // Populate global array and display
                        arr = new int[newArr.Length];

                        Console.Write("New Array: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = newArr[i];
                            Console.Write($"{arr[i]} ");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Write number to be removed:");
                        int el = int.Parse(Console.ReadLine());
                        int[] newArr = new int[arr.Length - 1];

                        for(int i = 0, j = 0; i < arr.Length; i++)
                        {
                            if (arr[i] != el)
                            {
                                newArr[j] = arr[i];
                                j++;
                            }
                        }

                        // Populate global array and display
                        arr = new int[newArr.Length];

                        Console.Write("New Array: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = newArr[i];
                            Console.Write($"{arr[i]} ");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Write index of number to be removed:");
                        int ind = int.Parse(Console.ReadLine());
                        int[] newArr = new int[arr.Length - 1];

                        for (int i = 0, j = 0; i < arr.Length; i++)
                        {
                            if (i != ind)
                            {
                                newArr[j] = arr[i];
                                j++;
                            }
                        }

                        // Populate global array and display
                        arr = new int[newArr.Length];

                        Console.Write("New Array: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = newArr[i];
                            Console.Write($"{arr[i]} ");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Write number and index to be added at:");
                        int[] numAndIndex = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                        int[] newArr = new int[arr.Length + 1];

                        for(int i = 0, j = 0; i < newArr.Length; i++)
                        {
                            if(i < numAndIndex[1])
                            {
                                newArr[j] = arr[i];
                                j++;
                            }
                            else if(i == numAndIndex[1])
                            {
                                newArr[j] = numAndIndex[0];
                                j++;
                            }
                            else
                            {
                                newArr[j] = arr[i - 1];
                                j++;
                            }

                        }

                        // Populate global array and display
                        arr = new int[newArr.Length];

                        Console.Write("New Array: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = newArr[i];
                            Console.Write($"{arr[i]} ");
                        }
                        break;

                        break;
                    }
                case 5:
                    {
                        Console.Write("Current Array: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            
                            Console.Write($"{arr[i]} ");
                        }

                        break;
                    }
            }

            Console.WriteLine();
            Console.WriteLine();

        }

       
    }
}