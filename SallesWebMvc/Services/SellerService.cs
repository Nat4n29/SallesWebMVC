using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Data;
using SallesWebMvc.Models;

namespace SallesWebMvc.Services
{
    public class SellerService
    {
        private readonly SallesWebMvcContext _context;

        public SellerService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //obj.Departments = _context.Departments.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(s => s.Departments).FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
