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
        public Searcher(int[] array, int target) {
            Stopwatch watch = new Stopwatch();

            //declaring variables
            Array.Sort(array);
            int length = array.Length;
            int max = length - 1;
            int min = 0;
            int middle;
            Boolean notFoundLeave = false;
            watch.Start();
            
            
            while (!isfound && !notFoundLeave) {
                middle = (max + min) / 2;
                debugString += "Looped and set middle to the average of the Max and Min\n";
                Console.WriteLine("Looped and set middle to the average of the Max and Min");

                if (array[middle] < target)
                {
                    min = middle;
                    debugString += "Set Middle to Min\n";
                    Console.WriteLine("Set Middle to Min");
                    

                }
                else if (array[middle] > target) {

                    max = middle+1;
                    debugString += "Set Middle to Max\n";
                    Console.WriteLine("Set Middle to Max");
                
                
                }
                if (array[max] == target)
                {

                    targetIndex = max;
                    isfound = true;
                    debugString += "Found Index is the Max";
                    Console.WriteLine("Found Index is the Max");
                }
                else if (array[min] == target)
                {

                    targetIndex = min;
                    isfound = true;
                    debugString += "Found Index is Min";
                    Console.WriteLine("Found Index is Min");

                }
                else if (array[middle] == target) {

                    targetIndex = middle;
                    isfound = true;
                    debugString += "Found Index is Middle";
                    Console.WriteLine("Found Index is Middle");
                        }
                if (middle == 0) {

                    isfound = false;
                    notFoundLeave = true;
                    debugString += "Middle was set to zero due to there being no middle";
                    Console.WriteLine("Middle was set to zero due to their being no middle");
                    
                
                
                }
                
            
            
            }
            watch.Stop();
            runtime = watch.ElapsedMilliseconds;



        
        
        }
        public int returnIndex() {


            return targetIndex;
        
        
        }
        public Boolean returnBoolean() {

            return isfound;
        
        }
        public long returnRuntime() {
            return runtime;
        }
        public String returnDebugStatements() {

            return debugString;
        
        }





    }
}
