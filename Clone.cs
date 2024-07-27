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
        private CustomStack<string> _learnedPrograms = new();
        private CustomStack<string> _rollBackPrograms = new();

        public Clone(string program = "basic")
        {
            _currentProgram = program;
            _learnedPrograms.Push(program);
        }

        public Clone(Node<string> learnedPrograms, Node<string> rollBackPrograms) 
        {
            _learnedPrograms = new CustomStack<string>(learnedPrograms);
            _rollBackPrograms = new CustomStack<string>(rollBackPrograms);
            _currentProgram = _learnedPrograms.Peek();
        }

        public CustomStack<string> GetLearnedPrograms() => _learnedPrograms;

        public CustomStack<string> GetRollBackPrograms() => _rollBackPrograms;

        public string Check() => _currentProgram;

        public void Learn(string program)
        {
            _currentProgram = program;
            _learnedPrograms.Push(program);
        }

        public void RollBack()
        {
            _rollBackPrograms.Push(_currentProgram);
            _learnedPrograms.Pop();
            _currentProgram = _learnedPrograms.Peek();
        }

        public void Relearn()
        {
            _currentProgram = _rollBackPrograms.Peek();
            _learnedPrograms.Push(_currentProgram);
            _rollBackPrograms.Pop();
        }
    }
}
