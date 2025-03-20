using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<T> : ControllerBase where T : class, INameable, new()
    {
        [HttpPost]
        public IActionResult CreateEntity(T entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.Name))
                return BadRequest("Invalid data");

            return Ok($"{typeof(T).Name} {entity.Name} created successfully.");
        }
    }

    // Interface to enforce Name property
    public interface INameable
    {
        string Name { get; set; }
    }

    // Student Model
    public class Student : INameable
    {
        public string Name { get; set; }
    }

    // Teacher Model
    public class Teacher : INameable
    {
        public string Name { get; set; }
    }

    // Specific Controllers that inherit GenericController
    [ApiController]
    [Route("api/student")]
    public class StudentController : GenericController<Student>
    {
    }

    [ApiController]
    [Route("api/teacher")]
    public class TeacherController : GenericController<Teacher>
    {
    }

}
