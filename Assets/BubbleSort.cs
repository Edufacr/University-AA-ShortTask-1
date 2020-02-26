using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Diagnostics;

// C# program for implementation 
// of Bubble Sort
// From GeeksforGeeks.com
public class BubbleSort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	    int []arr = {64, 34, 25, 12, 22, 11, 90}; 
	    Stopwatch s = Stopwatch.StartNew();
	    bubbleSort(arr); 
	    Console.WriteLine("Time taken: " + s.ElapsedMilliseconds + "ms");
	    printArray(arr); 
    }
	
	void runTimes(int startN, int endN, int increaseVal){
		Stopwatch s;
		for(int n = startN; n < endN; n + increaseVal){
			s = Stopwatch.StartNew();
			//Create array based on N
			int []array;
			bubbleSort(array):


		}
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
