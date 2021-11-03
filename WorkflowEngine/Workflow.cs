using System.Collections.Generic;

namespace LearningC_.WorkflowEngine
{
    public class Workflow
    {

        public IEnumerable<IActivity> Activities { get; }
        public Workflow(IEnumerable<IActivity> activities)
        {
            Activities = activities;
        }

    }
}