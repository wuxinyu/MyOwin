
namespace Biz.Project.Entity
{
    public class Project : Infrastructure.Domain.Entity
    {
        public Project(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }
    }
}
