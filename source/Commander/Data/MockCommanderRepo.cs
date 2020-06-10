using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
	public class MockCommanderRepo : ICommanderRepo
	{
		public Command GetCommandById(int id)
		{
			return new Command{Id=0, HowTo="Boil ab egg", Line="Boil Water", Platform= "Kettle & pan"};
		}

		public IEnumerable<Command> GetAllCommands()
		{
			var commads = new List<Command> 
			{
				new Command{Id=0, HowTo="Boil ab egg", Line="Boil Water", Platform= "Kettle & pan"},
				new Command{Id=2, HowTo="Boil ab egg", Line="Boil Water", Platform= "Kettle & pan"},
				new Command{Id=3, HowTo="Boil ab egg", Line="Boil Water", Platform= "Kettle & pan"},
				new Command{Id=4, HowTo="Boil ab egg", Line="Boil Water", Platform= "Kettle & pan"},
				new Command{Id=5, HowTo="Boil ab egg", Line="Boil Water", Platform= "Kettle & pan"},
			};
			
			return commads;
		}
	}
}