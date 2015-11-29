using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webDrevo.Models;
using System.Configuration;

namespace webDrevo
{
    public class EFTreesRepository
    {
        private TreeContext context;

        public EFTreesRepository()
        {
            context = new TreeContext(@"Data Source=LENOVO-PC\SQL2014EXPRESS;Initial Catalog=Trees;User ID=marat;Password=000000");
        }

        public IEnumerable<Folder> GetFolders()
        {
            return context.Folders;
        }
    }
}