using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary {
    
    public class MathIntLibrary {

        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Sub(int a, int b) {
            return a - b;
        }
        public static int Mult(int a, int b) {
            return a * b;
        }
        public static int Div(int a, int b) {
            return a / b;
        }
        public static int Mod(int a, int b) {
            return a % b;
        }
        public static int Fact(int a) {
            var f = 1;
            for(var idx = a; idx >= 2; idx--) {
                f *= idx;
            }
            return f;
        }
        public static int Zero() {
            return 0;
        }
    }
}
