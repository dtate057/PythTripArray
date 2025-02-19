/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

class program {

	static bool pythagoreanTriplet(int[]arr)
	{
		// Taking Square of each element
int n = arr.Length;
for(int i = 0; i < n; i++)
{
    arr[i] = arr[i] * arr[i];
}
Array.Sort(arr);
		// Fix the largest element of Pythagorean triplet
for(int i = n - 1; i > 1; i--)
			// Two pointer technique to find remaining two elements
{			// such that a^2 + b^2 = c^2
	int l =0;
	int r = i - 1;
	
	while (l < r)
	{		
	    // A Pythagorean triplet is found
	    if(arr[l] + arr[r] == arr[i])
	    return true;
	    if(arr[l] + arr[r] < arr[i])
	    l++;
	    if(arr[l] + arr[r] > arr[i])
	    r--;
	}
}
	return false;


}
static void Main()
{
	int[] arr = {10, 4, 6, 12, 5};
	Console.WriteLine(pythagoreanTriplet(arr));
}
}