using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Clone
    {
        public int ID { get;}
        private string _currentProgram = string.Empty;
        private Stack<string> _learnedPrograms = new();
        private Stack<string> _rollBackPrograms = new();

        public Clone(int id = 1, string program = "basic")
        {
            ID = id;
            _currentProgram = program;
            _learnedPrograms.Push(program);
        }

        public Stack<string> GetLearnedPrograms() => _learnedPrograms; 

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
            _currentProgram = _learnedPrograms.Peek();
            _learnedPrograms.Push(programToLearn);
        }
    }
}
