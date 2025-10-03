//Console.WriteLine("Hello World");
//Console.WriteLine("Press any key to exit...");

//int[] numbers;
//int[] nums = new int[4];
//int[] nums2 = new int[4] { 1, 2, 3, 5 };
//int[] nums3 = new int[] { 1, 2, 3, 5 };
//int[] nums4 = new[] { 1, 2, 3, 5 };
//int[] nums5 = { 1, 2, 3, 5 };
//int[] nums6 = [1, 2, 3, 5];

//int[] numbers = [1, 2, 3, 5];
//Console.WriteLine(numbers[3]);
//var n = numbers[1];
//Console.WriteLine(n);
//numbers[1] = 505;
//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers[6]);

//int[] numbers = [1, 2, 3, 5];
//Console.WriteLine(numbers.Length);
//Console.WriteLine(numbers[numbers.Length - 1]);
//Console.WriteLine(numbers[numbers.Length - 2]);
//Console.WriteLine(numbers[numbers.Length - 3]);
//Console.WriteLine(numbers[^1]);
//Console.WriteLine(numbers[^2]);
//Console.WriteLine(numbers[^3]);

//int[] numbers = [1, 2, 3, 5];
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * 2;
//    Console.WriteLine(numbers[i]);
//}
//int[] numbers = [1, 2, 3, 5];
//int i = 0;
//while (i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}

//int[] nums1 = [0, 1, 2, 3, 4, 5];
//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
//object[] student = ["Иван", "Игорь", 4, 4.6, 'c'];
//student[4] = 4;
//dynamic[] student2 = ["Иван", "Игорь", 4, 4.6, 'c'];
//student2[4] = 4;
//Console.WriteLine(student[4].GetType());
//Console.WriteLine(student2[4].GetType());

//int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45];
//int result = 0;
//int result2 = 0;
//int result3 = 0;
//foreach (int number in numbers)
//{
//    if (number > 0)
//        result++;
//}
//Console.WriteLine($"Число элементов больше нуля: {result}");
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//        result2++;
//}
//    Console.WriteLine($"Число элементов больше нуля: {result2}");
//int i = 0;
//while (i < numbers.Length)
//{
//    if (numbers[i] > 0)
//        result3++;
//        i++;
//}
//    Console.WriteLine($"Число элементов больше нуля: {result3}");

//int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45];
//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for (int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach (int i in numbers)
//{
//    Console.Write($"{i} \t");
//}
//int[] nums = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45];
//int temp;
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    for (int j = 1 + 1; j < nums.Length; j++)
//    {
//        if (nums[i] == nums[j])
//        {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//List<string> people = [];
//List<string> student = ["Иван", "Игорь", "Александр"];
//var yourStudent = new List<string>(student);
//List<string> student = new(10);
//List<string> student = ["Билли", "Игорь", "Степан"];
//string firstStudent = student[0];
//Console.WriteLine(firstStudent);
//student[0] = "Богдан";
//Console.WriteLine(student[0]);
//Console.WriteLine(student.Count);
//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}
//List<string> student = ["Билли", "Игорь", "Степан"];
//student.Add("Van");
//student.AddRange(["Антон", "Денис"]);
//student.Insert(1, "Кирилл");
//student.InsertRange(1, ["Mike", "Kate"]);
//student.Insert(7, "Михаил");
//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}
//var people = new List<string> { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice"};
//people.RemoveAt(1);
//people.Remove("Tom");
//people.RemoveRange(1, 2);
//people.Clear();
//foreach (var person in people)
//{
//    Console.WriteLine(person);
//}