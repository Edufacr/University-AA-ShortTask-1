using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Random = System.Random;
//namespace Application
public class QuickSortAlgorithm : MonoBehaviour
    {
        public QuickSortAlgorithm()
        {
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        // A utility function to print array of size n 
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
 
        public static void Main()
        {
            System.Random rand = new Random();
            int arrSize = 1000000;
            int[] randArr = new int[arrSize];

            for (int i=0; i<arrSize; i++){
                randArr[i] = rand.Next(1,101);
            } 

            /*
            Console.WriteLine("unsorted array: ");
            printArray(randArr, arrSize);
            */

            Stopwatch s = Stopwatch.StartNew();
            quickSort(randArr, 0, arrSize - 1);
            Console.WriteLine("Tiempo ejecución: " + s.ElapsedMilliseconds + "ms");
            s.Stop();

            /*
            Console.WriteLine("sorted array: ");
            printArray(randArr, arrSize);
            */
            
        }
    }

