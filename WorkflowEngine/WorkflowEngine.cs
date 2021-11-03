using System.Collections.Generic;

namespace LearningC_.WorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly Workflow _workflow;
        public WorkflowEngine(Workflow workflow)
        {
            _workflow = workflow;

        }

        public void Run()
        {
            IEnumerable<IActivity> list = _workflow.Activities; 
            
            foreach(var activity in list){
                
                activity.Execute();
            }
        }


    }
}