using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Impl
{
    class Repository : IRepository
    {
        public List<Album> GetAllAlbums()
        {
            using (var db = new DBConnection())
            {
                return db.Albums.ToList();
            }
        }
    }
}
