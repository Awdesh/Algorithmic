using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   public class Program
    {
        // find missing number from an AP. AP is a series in which difference between consecutive numbers are same.
        public static int findMissingNumber(int[] series)
        {
            int num = 0;
            int pattern = 0;
            int temp = 0;
            int length = series.Length;
            // return if length is lesser or equal to 2.
            if (length <= 2)
            {
                return num;
            }
            // traverse over the array in order to find the pattern.
            for (int i = 0; i < length; i++)
            {
                pattern = series[i + 1] - series[i];
                if (pattern == temp)
                {
                    break;
                }
                temp = pattern;
                
            }
            for (int i = 0; i + 1 < length; i++)
            {
                // here have to take care of arrya out of bound since we doing "i + 1" operation, that's why we have i + 1 in loop.
                if (series[i + 1] == series[i] + pattern)
                {
                    continue;
                }
                else
                {
                    num = series[i + 1] - pattern;
                    break;
                }
            }
            return num;
        }

        

        static void Main(string[] args)
        {
            //int[] arr = new int[7];
            //arr[0] = -1;
            //arr[1] = -3;
            //arr[2] = 1;
            //arr[3] = 5;
            //arr[4] = 100;
            //arr[5] = 17;
            //arr[6] = 100;


            //int[] arr1 = new int[5];
            //arr1[0] = 5;
            //arr1[1] = 3;
            //arr1[2] = 5;
            //arr1[3] = 3;
            //arr1[4] = 3;

            //SievePrime p = new SievePrime();
            //bool[] bArr = p.Sieve(25);
            //Console.WriteLine("length of array is-: {0}", bArr.Length);

            //Yahtzee dice = new Yahtzee();
            //int val = dice.maxPointsArr(arr1);
            //Console.WriteLine("max value can be-: {0}", val);

            //DecimalToBinary db = new DecimalToBinary();
            //char[] ar = db.Convert(156, 2);
            //Console.WriteLine("Binary value is-: {0}", ar);

            //List<int> ll = PrintDuplicateValues.PrintDuplicateValue(arr1);
            //Console.WriteLine("items ins lists are-:{0}", ll.Count);

            //string s = "This is Awesome";
            //string reversedString = StringReversal.ReverseStringInPlace(s);
            //Console.WriteLine("Reversed string is-: {0}", reversedString);

            //int[] ar = MoveZeroAtEnd.MoveZeroAtEndOfArray(arr1);
            //Console.WriteLine("New array is-: {0}", ar);

            //string binary = HexadecimalToBinary.ConvertHexaDecimalToBinray("A57E");
            //Console.WriteLine("Binary equivalent is-: {0}", binary);
            ////string s = LongestSubSequenceString.FindLongestSubSequence("ababcab");
            //Console.WriteLine("Longest subsequence is-: {0}", s);

            //Dictionary<int, int> d = new Dictionary<int, int>();
            //d = PrintDuplicateCount.PrintDuplicateValue(arr1);
           
            //bool val = FindSumNumbers.IsSumExists(arr);
            //Console.WriteLine("Sum exists-: {0}", val);


            //DuplicateElementArray.FindDuplicateElementFromArrayConstantSpace(arr);

            double res = SquareRoot.findSquareRootPrecision(4);
            Console.WriteLine("Square root is -: {0}", res);
            

            //FindClosesPairFromArray fc = new FindClosesPairFromArray();
            //int[] ar  = fc.FindPair(arr, arr1, 36);
            //Console.WriteLine(ar);

            //int n = factorial.FactorialUsingRecursion(6);
            //Console.WriteLine(n);
            //Node queueNode1 = new Node(5);
            //Node queueNode2 = new Node(10);
            //Node queueNode3 = new Node(15);
            //Node queueNode4 = new Node(20);
            //Node queueNode5 = new Node(25);

            //QueueUsingArray qA = new QueueUsingArray();
            //qA.Enqueue(queueNode1);
            //qA.Enqueue(queueNode2);
            //qA.Enqueue(queueNode3);
            //qA.Enqueue(queueNode4);
            //qA.Enqueue(queueNode5);

            //int c = qA.Count();
            //Console.WriteLine("No. of items in queue are-: {0}", c);

            //Node n = qA.Dequeue();
            //int val = n.Data;
            //Console.WriteLine("Value of item that's been dequeued is-: {0}", val);

            //int c1 = qA.Count();
            //Console.WriteLine("No. of items in queue are-: {0}", c1);

            //StackNode stackNode1 = new StackNode(5);
            //StackNode stackNode2 = new StackNode(10);
            //StackNode stackNode3 = new StackNode(15);
            //StackNode stackNode4 = new StackNode(20);
            //StackNode stackNode5 = new StackNode(25);

            //StackUsingArray sA = new StackUsingArray();
            //sA.Push(stackNode1);
            //sA.Push(stackNode2);
            //sA.Push(stackNode3);
            //sA.Push(stackNode4);
            //sA.Push(stackNode5);

            //int count = sA.Count();
            //Console.WriteLine("No. of items in queue are-: {0}", count);

            //StackNode n1 = sA.Pop();
            //int val1 = n1.Data;
            //Console.WriteLine("Value of item that's been dequeued is-: {0}", val1);

            //int count1 = sA.Count();
            //Console.WriteLine("No. of items in queue are-: {0}", count1);

            
            //FindCommonIntegersFromArray fca = new FindCommonIntegersFromArray();
            //List<int> list = new List<int>();
            ////list = fca.FindCommonIntegers(arr, arr1);
            //list = fca.FindCommonIntegerMethod1Improvement(arr, arr1);

            //int n = Program.findMissingNumber(arr);
            //if (n > 0)
            //{
            //    Console.WriteLine("misssing number is -: {0}", n);
            //}
            //else
            //{
            //    Console.WriteLine("No number is missing");
            //}

            //int occurance = BinaryString.numberOfSubstrings("0010010101001");
            //Console.WriteLine("Occurance is -: {0}", occurance);

            //char c = NonRepeatedChars.NonRepeatedChar("total");
            //Console.WriteLine("first non repeated char is-: {0}");

            //int num = LargestThreeDigitPalindrome.LargestPalindrome();
            //Console.WriteLine("number is- : {0}", num);

            //bool b = Palindrome.IsPalindrome(906609);
            //if (b)
            //{
            //    Console.WriteLine("number is palindrome");
            //}

            //string s = StringReversal.ReverseStringUsingRecursion("user");
            //Console.WriteLine("After reversing string is-: {0}", s);

            //double d = EulerProblem6.findDifference();
            //Console.WriteLine("Diff. is-: {0}", d);

            //int f = factorial.FindFactorial(13);
            //Console.WriteLine("factorial is-: {0}", f);

            //TreeNode node = new TreeNode();
            //TreeNode Tree = node.CreateBinaryTree();

            //// PreOrder traversal.
            //Traversal tr = new Traversal();
            //tr.PreOrderTraversalWithoutRecusrion(Tree);

            //tr.InorderTraversalWithoutRecursion(Tree);

            //tr.BFSTraversal(Tree);

        }
    }
}





