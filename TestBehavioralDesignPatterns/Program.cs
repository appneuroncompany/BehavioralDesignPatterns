using ChainOfResponsibilityDesignPattern;
using CommandDesignPattern;
using MediatorDesignPattern;
using ObserverDesignPattern;
using StateDesignPattern;
using StrategyDesignPattern;
using System;
using TemplateMethodDesignPattern;

namespace TestBehavioralDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibilityDesign.TestChainResponsibilityDesign();
            CommandDesign.TestCommandDesign();
            MediatorDesign.TestMediatorDesign();
            ObserverDesign.TestObserverDesgn();
            TemplateMethod.TestTemplateMethod();
            StateDesign.TestStateDesign();
            StrategyPattern.TestStrategyPattern();
        }
    }
}
