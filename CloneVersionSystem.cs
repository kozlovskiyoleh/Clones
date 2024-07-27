using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clones;

public class CloneVersionSystem : ICloneVersionSystem
{
	private Dictionary<int, Clone> _armyClones = new();
	private int _cuurentID = 0;

	public CloneVersionSystem()
	{
		_cuurentID = 1;
		_armyClones.Add(_cuurentID, new Clone());
	}

	public void CreateNewClone()
	{
		var clone = _armyClones[_cuurentID];
		_cuurentID = _armyClones.Keys.Last() + 1;
		var lastClonesLearnedPrograms = clone.GetLearnedPrograms();
		var lastClonesRollbackPrograms = clone.GetRollBackPrograms();
		_armyClones.Add(_cuurentID, new Clone(lastClonesLearnedPrograms.GetHead(), lastClonesRollbackPrograms.GetHead()));
	}

	public string Execute(string query)
	{
		var request = new Request(query);
		var command = CreateCommand(request);
		return command.Execute();
	}

    public ICommand CreateCommand(Request request)
    {
        switch (request.Command)
        {
            case CommandTypes.Learn:
                return new LearnCommand(_armyClones, request);
            case CommandTypes.Relearn:
                return new RelearnCommand(_armyClones[request.Receiver]);
            case CommandTypes.Rollback:
                return new RollBackCommand(_armyClones[request.Receiver]);
            case CommandTypes.Check:
                return new CheckCommand(_armyClones[request.Receiver]);
            case CommandTypes.Clone:
                return new CloneCommand(this);
            default:
                throw new InvalidOperationException();
        }
    }
}