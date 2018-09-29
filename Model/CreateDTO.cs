using System.Collections.Generic;

using Model.Interface;

namespace Model
{
    public class CreateDTO : ICreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<CreateTaskDTO> Tasks { get; set; }
    }
}
