
namespace Implementation.BehavioralPatterns.Interpreter.BLClasses
{
    internal class Context
    {
        Dictionary<string, int> variables;
        public Context()
        {
            variables = new Dictionary<string, int>();
        }
        // получаем значение переменной по ее имени
        public int GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }
}
