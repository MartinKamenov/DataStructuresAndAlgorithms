using DSA_CSharp.Linear_Structures.List;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(5);
            list.Add(15);
            list.Add(19);
            list.Add(25);
            list.Add(27);
            list.Insert(3, 20);
            list.Remove(27);
            list.Remove(15);
            list.Add(5);
            list.Remove(5);
            list.RemoveAt(0);

            printList(list);
        }

        private static void printList(IList<int> list)
        {
            // Console.WriteLine(String.Join(" ", list));
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
