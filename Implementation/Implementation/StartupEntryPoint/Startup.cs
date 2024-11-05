using Implementation.StartupEntryPoint.BLClasses;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.StartupEntryPoint
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            var context = new StartupContext();

            var strategies = StrategyFactory.CreateStrategies();

            Console.WriteLine("Choose which pattern implementation you want to see:");

            foreach (var item in strategies)
            {
                string key = item.Key;
                string value = InsertSpacesBeforeUppercase(item.Value.GetType().Name);
                Console.WriteLine($"{key} - {value}");
            }

            ProcessUserInput(strategies, context);
        }

        private static void ProcessUserInput(Dictionary<string, IPatternImplementationStrategy> strategies, StartupContext context)
        {
            string choice;

            while (true)
            {
                choice = Console.ReadLine();

                if (strategies.TryGetValue(choice, out IPatternImplementationStrategy selectedStrategy))
                {
                    // Не вижу смысла иметь возможность возвращаться из примера каждого паттерна назад к окну выбора,
                    // так как в любом случае по коду понятно что выведется в окно cmd.
                    Console.Clear();
                    context.SetStrategy(selectedStrategy);
                    context.RunPatternImplementationExample();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        // Если бы у нас была неимоверное количество строковых данных с которыми
        // производилось куча операций, то имело бы смысл использовать StringBuilder,
        // а так я не вижу смысла к нему прибегать(потому что это будет намного затратнее).
        private static string InsertSpacesBeforeUppercase(string input)
        {
            //return Regex.Replace(input, "([A-Z])", " $1").Trim();

            //С LINQ и операциями над строками думаю форматирование будет более понятно для другого пользователя
            return string.Concat(input.Select(c => char.IsUpper(c) ? " " + c : c.ToString())).Trim();
        }
    }
}
