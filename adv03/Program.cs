namespace adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           List<int> numbers = new List<int> { 85, 92, 78, 95,88,70,100,65 };
            Console.WriteLine("Original List: " + string.Join(", ", numbers));


            Console.WriteLine($"Count: {numbers.Count}");


            Console.WriteLine($"First: {numbers.First()}");


            Console.WriteLine($"Last: {numbers.Last()}");


            numbers.Sort();
            Console.WriteLine($"Sorted List: {string.Join(", ", numbers)}");


            Console.WriteLine($"the first grade above 90: {numbers.First(n => n > 90)}");


            Console.WriteLine($"the last grade below 75: {string.Join(", ", numbers.FindAll(n => n < 75))}");


            Console.WriteLine(numbers.Find(n => n == 100));


            List<string> result = new List<string> { };
            foreach (var item in numbers) {
                result.Add($"Grade:{ item}");
                
                }
            Console.WriteLine(string.Join(",", result));
            */

            /*
            Dictionary<int, string> leadership = new Dictionary<int, string>();
            leadership.Add(500, "ahmed");
            leadership.Add(200, "sara");
            leadership.Add(800, "ali");
            leadership.Add(350, "mona");
            foreach(var item in leadership)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine($"the first key: {leadership.First().Key}");
            Console.WriteLine($"the first value: {leadership.First().Value}");


            Console.WriteLine(leadership.ContainsKey(500));
            Console.WriteLine(leadership.ContainsKey(900));


            Console.WriteLine(leadership.Remove(200));


            Console.WriteLine($"updated leadership:");
            foreach(var item in leadership)
            {
                Console.WriteLine(item);
            }

            */
            /*
            Dictionary<string,int> phonebookapplication = new Dictionary<string,int>();
            phonebookapplication["ahmed"] = 123456789;
            phonebookapplication["sara"] = 987654321;
            phonebookapplication["ali"] = 456789123;
            phonebookapplication["mona"] = 789123456;
            try
            {
                phonebookapplication.Add("ahmed", 123456789);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            bool res= phonebookapplication.TryAdd("sara", 987654321);
            Console.WriteLine(res);


          var result= phonebookapplication.Where(n=>n.Key=="amr"&&n.Value==555555555);
            Console.WriteLine(result.Any());


           var r=phonebookapplication.TryGetValue("amr",out int phone)?phone.ToString():"not found";
            Console.WriteLine(r);


            Console.WriteLine(string.Join(",", phonebookapplication.Keys)); 
            Console.WriteLine(string.Join(",", phonebookapplication.Values));
            */
            /*
            HashSet<string> diffrentemails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            diffrentemails.Add("ahmed@test.com");
            diffrentemails.Add("AHMED@test.com");
            diffrentemails.Add("sara@test.com");
            diffrentemails.Add("Sara@test.com");
            Console.WriteLine($"the count of diffrent emails: {diffrentemails.Count}");
            HashSet<int>A=new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int>B=new HashSet<int> { 4, 5, 6, 7, 8 };
            Console.WriteLine($"the union of A and B: {string.Join(",",A.Union(B))}");
            Console.WriteLine($"the intersection of A and B: {string.Join(",",A.Intersect(B))}");
            Console.WriteLine($"the difference of A and B: {string.Join(",",A.Except(B))}");
            Console.WriteLine($"{{1,2}}is a subset of A: {new HashSet<int> { 1, 2 }.IsSubsetOf(A)}");

            */
            /*
            Queue<string> queuesimulator = new Queue<string>();
            queuesimulator.Enqueue("Report.pdf");
            queuesimulator.Enqueue("Invoice.pdf");
            queuesimulator.Enqueue("Letter.docx");
            queuesimulator.Enqueue("Resume.pdf");
            queuesimulator.Enqueue("Photo.jpg");
            foreach(var item in queuesimulator)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine(queuesimulator.Count);
           Console.WriteLine (queuesimulator.Peek());
            while (queuesimulator.Count > 0)
            {
                string s = queuesimulator.Dequeue();
                Console.WriteLine($"printing:{s}");
            }
                var res = queuesimulator.TryDequeue(out var v);
                Console.WriteLine(res);

            */
            /*
            Stack<string> browserhistory = new Stack<string>();
            browserhistory.Push("google.com");
            browserhistory.Push("github.com");
            browserhistory.Push("stackoverflow.com");
            browserhistory.Push("yt.com");
            browserhistory.Push("claude ai.com");

            Console.WriteLine($"the current page: {browserhistory.Peek()}");

            for(int i=0;i<3;i++)
            {
                string s = browserhistory.Pop();
                Console.WriteLine($"going back to: {s}");
            }

            Console.WriteLine($"the current page:{browserhistory.Peek()}");

            while (browserhistory.Count > 0)
            {
                browserhistory.Pop();
            }
            var res = browserhistory.TryPop(out string? v);
            Console.WriteLine(res);
            Console.WriteLine(v);
            */


        }
    }
}
