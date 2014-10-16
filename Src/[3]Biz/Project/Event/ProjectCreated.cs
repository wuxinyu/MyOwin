
namespace Biz.Project.Event
{
    using Infrastructure.Messaging;

    public class ProjectCreated : Message<ProjectCreated>
    {
        public string Name { get; set; }
    }
}
