using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Random = System.Random;

// C# program for implementation 
// of Bubble Sort
// From GeeksforGeeks.com
public class BubbleSort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola");
        int currentN = 0;
        Stopwatch s;
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            currentN += 10000;
            for (int j = 0; j < 3; j++)
            {
                int[] array = getRanArray(currentN,rand);
                s = Stopwatch.StartNew();
                bubbleSort(array);
                Debug.Log("X = "+currentN+" run: "+j+" time: "+s.ElapsedMilliseconds);
                s.Stop();
            }
        }
    }
	
    int[] getRanArray(int pCurrentN, System.Random pRand){
		
        int[] randArr = new int[pCurrentN];
        int n = randArr.Length;
        for (int i=0; i<n; i++){
            randArr[i] = pRand.Next(1,101);
        } 
        return randArr;
    }

    static void bubbleSort(int []arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n - 1; i++) 
        for (int j = 0; j < n - i - 1; j++) 
            if (arr[j] > arr[j + 1]) 
            { 
                // swap temp and arr[i] 
                int temp = arr[j]; 
                arr[j] = arr[j + 1]; 
                arr[j + 1] = temp; 
            } 
    } 
    
    /* Prints the array */
    static void printArray(int []arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n; ++i) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
    }

} 
    
// This code is contributed by Sam007 