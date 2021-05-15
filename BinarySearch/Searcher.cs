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
            
            
            while (isfound || notFoundLeave) {
                middle = (max - min) / 2;

                if (array[middle] < target)
                {
                    min = middle;

                }
                else if (array[middle] > target) {

                    max = middle;
                
                
                }
                if (array[max] == target)
                {

                    targetIndex = max;
                    isfound = true;
                }
                else if (array[min] == target)
                {

                    targetIndex = min;
                    isfound = true;

                }
                else if (array[middle] == target) {

                    targetIndex = middle;
                    isfound = true;
                }
                if (middle == 0) {

                    isfound = false;
                    notFoundLeave = true;
                
                
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





    }
}
