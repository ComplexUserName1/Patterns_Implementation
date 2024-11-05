using Implementation.BehavioralPatterns.ChainOfResponsibility;
using Implementation.BehavioralPatterns.Command;
using Implementation.BehavioralPatterns.Interpreter;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample;
using Implementation.BehavioralPatterns.Iterator.FusionOfIsDoneAndMoveNext;
using Implementation.BehavioralPatterns.Iterator.MostBasicExample;
using Implementation.BehavioralPatterns.Mediator;
using Implementation.BehavioralPatterns.Memento;
using Implementation.BehavioralPatterns.Observer;
using Implementation.BehavioralPatterns.State.BLClasses;
using Implementation.BehavioralPatterns.Strategy;
using Implementation.BehavioralPatterns.TemplateMethod;
using Implementation.BehavioralPatterns.Visitor.BasicExample;
using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext;
using Implementation.Creational_Patterns.Abstract_Factory;
using Implementation.Creational_Patterns.Builder;
using Implementation.Creational_Patterns.Factory_Method;
using Implementation.Creational_Patterns.Prototype;
using Implementation.Creational_Patterns.Singletone.Non_Thread_Safe;
using Implementation.Creational_Patterns.Singletone.Thread_Safe;
using Implementation.StartupEntryPoint.Interfaces;
using Implementation.Structural_Patterns.Adapter;
using Implementation.Structural_Patterns.Bridge;
using Implementation.StructuralPatterns.Composite;
using Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces;
using Implementation.StructuralPatterns.Facade;
using Implementation.StructuralPatterns.Flyweight;
using Implementation.StructuralPatterns.Proxy;

namespace Implementation.StartupEntryPoint.BLClasses
{
    internal class StrategyFactory
    {
        public static Dictionary<string, IPatternImplementationStrategy> CreateStrategies()
        {
            return new Dictionary<string, IPatternImplementationStrategy>
            {
                { "1", new AbstractFactoryImplementation() },
                { "2", new BuilderImplementation() },
                { "3", new FactoryMethodImplementation() },
                { "4", new PrototypeImplementation() },
                { "5.1", new NonThreadSafeSingletonImplementation() },
                { "5.2", new ThreadSafeSingletonImplementation() },
                { "6", new AdapterImplementation() },
                { "7", new BridgeImplementation() },
                { "8", new CompositeImplementation() },
                { "9.1", new BadDecoratorImplementationWithAttributes() },
                { "9.2", new GoodDecoratorImplementationWithClasses() },
                { "9.3", new GoodDecoratorImplementationWithClassesAndInterfaces() },
                { "10", new FacadeImplementation() },
                { "11", new FlyweightImplementation() },
                { "12", new ProxyImplementation() },
                { "13", new ChainOfResponsobilityImplementation() },
                { "14", new CommandImplementation() },
                { "15", new InterpreterImplementation() },
                { "16.1", new IteratorMostBasicExampleImplementation() },
                { "16.2", new IteratorConcreteBasicExampleImplementation() },
                { "16.3", new IteratorFusionOfIsDoneAndMoveNextImplementation() },
                { "17", new MediatorImplementation() },
                { "18", new MementoImplementation() },
                { "19", new ObserverImplementation() },
                { "20", new StateImplementation() },
                { "21", new StrategyImplementation() },
                { "22", new TemplateMethodImplementation() },
                { "23.1", new VisitorBasicExampleImplementation() },
                { "23.2", new VisitorExampleWithSpecificContextImplementation() },
            };
        }
    }
}
