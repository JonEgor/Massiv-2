using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
        int[] numbers = { 4, 1, -13, 83, 31, 58, 1, 9, 16, 72 };
        int temp;
for (int i = 0; i < numbers.Length; i++) {
    for (int j = 0; j < numbers.Length - 1 - i; j++) {
        if (numbers[j] > numbers[j + 1]) {
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;

        }
    }
}
for (int i=0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}