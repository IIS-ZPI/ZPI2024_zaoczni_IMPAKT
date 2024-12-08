﻿using IMPAKT.Math.Interfaces;
using IMPAKT.Settings;
using Microsoft.Extensions.Options;

namespace IMPAKT.Labs
{
    public class Lab1
    {
        private readonly MainSettings _mainSettings;
        private readonly IMathService _mathService;

        public Lab1(IOptions<MainSettings> options, IMathService mathService)
        {
            _mainSettings = options.Value;
            _mathService = mathService;
        }
        
        public void Execute()
        {
            DescribeGroup();
            // Below operands will be used for arithmetics operations
            var firstOperand = 10;
            var secondOperand = 5;
            Console.WriteLine("** Arithmetic operations **");
            ExecuteAdditionOperations(firstOperand, secondOperand);
            ExecuteDifferenceOperations(firstOperand, secondOperand);
            ExecuteMultiplicationOperations(firstOperand, secondOperand);
            ExecuteDivisionOperations(firstOperand, secondOperand);
        }
        //feature_Lab1_Zad6_dev1
        private void DescribeGroup()
        {
            Console.WriteLine("Nazwa grupy: Impakt. Scrum master: tirey93.");
            Console.WriteLine("DevOps Engineer: hubert-cywka");
            Console.WriteLine("Dev1: tirey93");
            Console.WriteLine("Dev2: lukasz-kkk");
            Console.WriteLine("Tester: BeastRacid");
            //dev3 comment b1
        }

        private void ExecuteAdditionOperations(double a, double b)
        {
            var additionResult = _mathService.Addition(a, b);
            
            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, additionResult);
        }
        private void ExecuteDifferenceOperations(double a, double b)
        {
            var differenceResult = _mathService.Difference(a, b);
            Console.WriteLine("Difference: {0} - {1} = {2}", a, b, differenceResult);
        }

        private void ExecuteMultiplicationOperations(double a, double b)
        {
            var multiplicationResult = _mathService.Multiplication(a, b);
            Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, multiplicationResult);
        }

        private void ExecuteDivisionOperations(double a, double b)
        {
            var divisionResult = _mathService.Division(a, b);
            Console.WriteLine("Division: {0} * {1} = {2}", a, b, divisionResult);
        }
    }
}
