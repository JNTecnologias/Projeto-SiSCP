using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siscp.DAL
{
    public class DataContextFactory
    {
        private static siscpDataContext dataContext;
        public static siscpDataContext DataContext{
            get{
                 if (dataContext == null) 
                     dataContext = new siscpDataContext();
                return dataContext;
            }
        }

    }
}
