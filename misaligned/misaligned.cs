using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }
            return i * j;
        }

        static void Main(string[] args) {
            int result = printColorMap();
            // returning anything apart from formatted string does not make sense
            Debug.Assert(result is string);
            // The real test must be to check if a particular color pair and number match!

            Console.WriteLine("All is well (maybe!)");
        }
    }
}
