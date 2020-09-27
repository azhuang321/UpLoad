using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            JiaJiangEntities m_JiaJiangEntities = new JiaJiangEntities();
            for (int i = 0; i < 100; i++)
            {
                m_JiaJiangEntities.FM_Disease.Add(new FM_Disease() { Disease_Type="",GP_Name=i.ToString(),Id=i.ToString()});
            }
            m_JiaJiangEntities.SaveChanges();
                m_JiaJiangEntities.FM_Disease.FirstOrDefault().GP_Name = "opo";
            m_JiaJiangEntities.SaveChanges();
        }
    }
}
