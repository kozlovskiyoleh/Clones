using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Clone
    {
        private string _currentProgram = string.Empty;
        private Stack<string> _learnedPrograms = new();
        private Stack<string> _rollBackPrograms = new();

        public Clone()
        {
            _currentProgram = "basic";
            _learnedPrograms.Push(_currentProgram);
        }

        public Clone(Stack<string> learnedPrograms, Stack<string> rollBackPrograms)
        {
            _currentProgram = learnedPrograms.Peek();
            _learnedPrograms =  new Stack<string>(learnedPrograms.Reverse());
            _rollBackPrograms = new Stack<string>(rollBackPrograms.Reverse());
        }

        public Stack<string> GetLearnedPrograms() => _learnedPrograms;

        public Stack<string> GetRollBackPrograms() => _rollBackPrograms;

        public string Check() => _currentProgram;

        public void Learn(string program)
        {
            _currentProgram = program;
            _learnedPrograms.Push(program);
        }

        public void RollBack()
        {
            var rollBackProgram = _learnedPrograms.Pop();
            _currentProgram = _learnedPrograms.Peek();
            _rollBackPrograms.Push(rollBackProgram);
        }

        public void Relearn()
        {
            var programToLearn = _rollBackPrograms.Pop();
            _learnedPrograms.Push(programToLearn);
            _currentProgram = _learnedPrograms.Peek();
        }
    }
}
