using SallesWebMvc.Data;
using SallesWebMvc.Models;

namespace SallesWebMvc.Services
{
    public class DepartmentsService
    {
        private readonly SallesWebMvcContext _context;

        public DepartmentsService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public List<Departments> FindAll()
        {
            return _context.Departments.OrderBy(d => d.Name).ToList();
        }

        public void Insert(Departments obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
