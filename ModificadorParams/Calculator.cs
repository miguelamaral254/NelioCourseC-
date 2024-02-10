using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams {
     class Calculator {
        public static int Sum(params int[] number) {
            int sum = 0;
            for (int i = 0; i < number.Length; i++) {
                sum += number[i];
            }
            return sum;

             
        }
        
    }
}
