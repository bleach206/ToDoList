using System;

using Model.Interface;

namespace Model
{
    [Serializable]
    public class CreateTaskDTO : ICreateTaskDTO
    {        
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
