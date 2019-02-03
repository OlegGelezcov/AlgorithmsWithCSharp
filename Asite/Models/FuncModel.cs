using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asite.Models {
    public class FuncModel {

        public double Interval { get; }
        public string IntervalName { get; }
        private readonly Dictionary<FuncType, Func<double, double>> taskSizeMap = new Dictionary<FuncType, Func<double, double>>();


        public FuncModel(double interval, string intervalName) {
            this.Interval = interval * 1e6;
            this.IntervalName = intervalName;
            taskSizeMap.Add(FuncType.Log2N, N => Math.Pow(2.0, N));
            taskSizeMap.Add(FuncType.N, N => N);
            taskSizeMap.Add(FuncType.N2, N => Math.Sqrt(N));
            taskSizeMap.Add(FuncType.NFact, N => TaskSizeFactorial(N));
            taskSizeMap.Add(FuncType.SqrtN, N => N * N);
            taskSizeMap.Add(FuncType._2PN, N => Math.Log(N, 2));
        }

        public double Log2N => TaskSize(FuncType.Log2N);
        public double N => TaskSize(FuncType.N);
        public double N2 => TaskSize(FuncType.N2);
        public double NFact => TaskSize(FuncType.NFact);
        public double SqrtN => TaskSize(FuncType.SqrtN);
        public double _2PN => TaskSize(FuncType._2PN);


        public double TaskSize(FuncType type)
            => taskSizeMap.ContainsKey(type) ? taskSizeMap[type](Interval) : 0;


        private double Factorial(int N) {
            double result = 1;
            for(int i = 1; i < N; i++ ) {
                result *= i;
            }
            return result;
        }

        private double TaskSizeFactorial(double value) {
            int testVal = 1;
            while(Factorial(testVal) <= value ) {
                testVal++;
            }
            if(testVal > 1 ) {
                testVal--;
            }
            return testVal;
        }

    }
}
