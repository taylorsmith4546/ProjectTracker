using System;

namespace ProjectTracker
{
	public class Project: BindableObjectBase{ 

		public string Name { get; }
		public Project(string name)
		{
			Name = name;
		}
		private bool isActive = false;
		public bool IsActive {
			get { return isActive; }
			set {
				isActive = value;
				RaisePropertyChanged (nameof (IsActive));
		}
		}
		public void StartTracking(DateTime startTimeUtc){
			IsActive = true;
	}
		public void StopTracking(DateTime startTimeUtc){
			IsActive = false;
	}
	}
}





