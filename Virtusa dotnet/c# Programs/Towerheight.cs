/*
Given an array arr[] denoting heights of N towers and a positive integer K, you have to modify
the height of each tower either by increasing or decreasing them by K only once. After modifying 
height should be a non-negative integer.

find out the minimum possible difference of the height of shortest and longest towers after you have 
modified each tower.

NOTE: It is compulsory to increase or decrease(if possible) by K to each tower.

ex1:
K=2
N=4
arr[] = {1,5,8,10}

op:
Array can be modified as {3,3,6,8}.
The difference b/w largest and smallest is 8-3=5. 
*/
using System;
class Ken{
    public static void Main()
    {
        string k=Console.ReadLine();
        int n=Convert.ToInt32(k);
        string str=Console.ReadLine();
        string[] rts=str.Split(" ");
        int[] arr = new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i]=Convert.ToInt32(rts[i]);
        }
        int s=0;
        for(int i=0;i<n;i++)
        {
          if(arr[i]-k>=0)
           {
             arr[i]=arr[i]-k;
            }
          else
             {
              arr[i]=arr[i]+k;
              }
          }
          Array.Sort(arr);
         Console.WriteLine(arr[n-1]-arr[0]);
     }
}
