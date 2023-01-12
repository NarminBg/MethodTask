
namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //var arrayTasks=new ArrayTasks();
            //int[] arr = arrayTasks.EnterArray();
            //arrayTasks.Print(arr);
            //int[] sqrtArr = arrayTasks.GetSqrtElements(arr);
            //arrayTasks.Print(sqrtArr); 
            #endregion

            var numberTask = new NumberTask();
            int number=numberTask.EnterNumber();
            int reverseNumber = numberTask.GetReverseNumber(number);
            Console.WriteLine($"{number}=>{reverseNumber}");
        }
    }
}