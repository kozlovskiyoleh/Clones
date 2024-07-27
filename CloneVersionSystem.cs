using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Clones;

/*Refactoring Execute using CommandPattern*/
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
		switch (request.Command)
		{
			case CommandTypes.Learn:
				if(!_armyClones.ContainsKey(request.Receiver))
                    _armyClones.Add(request.Receiver, new Clone());
				_armyClones[request.Receiver].Learn(request.Program);
                break;
			case CommandTypes.Relearn:		//Done
				_armyClones[request.Receiver].Relearn();
				break;
			case CommandTypes.Rollback:		//Done
				_armyClones[request.Receiver].RollBack();
				break;
			case CommandTypes.Check:		//Done
				return _armyClones[request.Receiver].Check();
			case CommandTypes.Clone:
				CreateNewClone();			//Done
				break;
			default:
				return null;
		}
		return null;
	}
}