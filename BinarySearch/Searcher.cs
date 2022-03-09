using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace BinarySearch
{
    class Searcher
    {
        int targetIndex;
        Boolean isfound = false;
        long runtime;
        /*private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);*/
        String debugString;
        public static (int?, long?) Search(int[] array, int target) {
            Stopwatch watch = new Stopwatch();

            //declaring variables
            
            Array.Sort(array);
            int length = array.Length;
            List<int> arrayList = new List<int>(array);
            int max = length - 1;
            int min = 0;
            int middle;
            Boolean notFoundLeave = !arrayList.Contains(target);
            long starttime = Stopwatch.GetTimestamp();

            
            
            while (min <= max) {
                middle = (max + min) / 2;
                BinarySearch.updater.consoleOutput.Text +="Looped and set middle to the average of the Max and Min\r\n";

                if (array[middle].Equals(target))
                {
                    long time = (Stopwatch.GetTimestamp() - starttime)/100;
                    return (middle, time);

                }
                else if(target < array[middle])
                {
                    max = middle - 1;
                }else if(target > array[middle])
                {
                    min = middle + 1;
                }
               
                

            
            
            }

            return (null, null);

        
        
        }
       





    }
}
