using System;
using Xunit;

namespace ProjectTracker.Tests
{
	public class ProjectTests
	{
		[Fact]
		public void MustBeTrue(){
			Assert.Equal (1, 1);
		}
		[Fact]
		public void StartTrackingSetsActive(){
			var project = new Project ("Name");
			Assert.False (project.IsActive);
			project.StartTracking (DateTime.UtcNow);
			Assert.True (project.IsActive);
	}
		[Fact]
		public void StopTrackingSetsInactive(){
			var project = new Project ("Name");
			project.StartTracking (DateTime.UtcNow);
			project.StopTracking (DateTime.UtcNow);
			Assert.False (project.IsActive);
}
}
}
