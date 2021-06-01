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
            List<int> arrayList = new List<int>(array);
            int max = length - 1;
            int min = 0;
            int middle;
            Boolean notFoundLeave = !arrayList.Contains(target);
            long starttime = Stopwatch.GetTimestamp();

            
            
            while (!isfound && !notFoundLeave) {
                middle = (max + min) / 2;
                BinarySearch.updater.consoleOutput.Text +="Looped and set middle to the average of the Max and Min\r\n";
                
                
                if (array[middle] < target)
                {
                    min = middle;
                    BinarySearch.updater.consoleOutput.Text +="Set Middle to Min\r\n";
                    
                    

                }
                else if (array[middle] > target) {

                    max = middle+1;
                    BinarySearch.updater.consoleOutput.Text +="Set Middle to Max\r\n";
                    
                
                
                }
                if (array[max] == target)
                {

                    targetIndex = max;
                    isfound = true;
                    BinarySearch.updater.consoleOutput.Text +="Found Index is the Max";
                    
                }
                else if (array[min] == target)
                {

                    targetIndex = min;
                    isfound = true;
                    BinarySearch.updater.consoleOutput.Text +="Found Index is Min";
                    

                }
                else if (array[middle] == target) {

                    targetIndex = middle;
                    isfound = true;
                    BinarySearch.updater.consoleOutput.Text +="Found Index is Middle";
                    
                        }
                if (array[min] == array[min + 1] + 1) {

                    isfound = false;
                    notFoundLeave = true;
                    BinarySearch.updater.consoleOutput.Text +="Middle was set to zero due to there being no middle";
                    
                    
                    
                
                
                }
                long endtime = Stopwatch.GetTimestamp();
                runtime = ((endtime - starttime) / 100);

            
            
            }
            


        
        
        }
        public int returnIndex() {


            return targetIndex;
        
        
        }
        public Boolean returnBoolean() {

            return isfound;
        
        }
        public String returnRuntime() {
            return runtime.ToString();
        }
        public String returnDebugStatements() {

            return debugString;
        
        }





    }
}
