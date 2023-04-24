using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{
    public class EFWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public Writer WriterLogin(Writer w)
        {
            using (var c = new Context())
            {
                return c.Writers.FirstOrDefault(b => b.WriterMail == w.WriterMail && b.WriterPassword == w.WriterPassword);
            }
        }
    }
}
