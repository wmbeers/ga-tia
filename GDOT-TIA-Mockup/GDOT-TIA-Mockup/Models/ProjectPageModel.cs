using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GDOT_TIA.Models
{
	public class ProjectPage
	{
		public List<Project> AllProjects { get; set; }
		public List<County> AllCounties { get; set; }
		public List<Band> AllBands { get; set; }
		public List<ProjectTypes> AllProjectTypes { get; set; }
		public List<ProjectStatus> AllProjectStatuses { get; set; }
		public RegionTotals totals { get; set; }

		public ProjectPage()
		{
			AllProjects= new List<Project>();
			AllCounties = new List<County>();
			AllBands = new List<Band>();
			AllProjectStatuses = new List<ProjectStatus>();
			AllProjectTypes = new List<ProjectTypes>();
		}
	}
}