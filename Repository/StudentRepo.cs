using WebApp5BySaugat.Models;
using WebApp5BySaugat.Repository;

namespace WebApp5BySaugat.Repository
{
    public class StudentRepo : IRepository<Student>
    {
        StudentdbContext _context;

        public StudentRepo(StudentdbContext context)
        {
            _context = context;
        }
        public void AddRecord(Student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();
        }

        public void DeleteRecord(Student std)
        {
            _context.Students.Remove(std);
            _context.SaveChanges();
        }


        public IEnumerable<Student> GetAllRecords()
        {

            IEnumerable<Student> stdList = _context.Students.ToList();
            return stdList;
        }

        public Student UpdateRecord(Student std)
        {
            _context.Update(std);
            _context.SaveChanges();
            return std;

        }

        public Student GetSingleRecord(int id)
        {
            Student std = _context.Students.Find(id);
            return std;
        }

    }
}
