using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagar1_Assignment
{
   
        
    
    internal class Sagar_Ass5
    {
        interface Isalary
        {
            float calchar(float basic);
            float calcda(float basic);
        }
        public class TrainerSal : Isalary
        {
            public float calchar(float basic)
            {
                return basic * 0.1f;
            }
            public float calcda(float basic)
            {
                return basic * 0.2f;
            }
        }
        public class ProjectManager : Isalary
        {
            public float calchar(float basic)
            {
                return basic * 0.1f;
            }
            public float calcda(float basic)
            {
                return basic * 0.12f;
            }
        }
        static void Main(string[] args)
        {
            TrainerSal trainer = new TrainerSal();
            ProjectManager project = new ProjectManager();
            float basicSal = 50000;
            Console.WriteLine("Trainer HRA :" + trainer.calchar(basicSal));
            Console.WriteLine("Trainer DA :" + trainer.calcda(basicSal));

            Console.WriteLine("Project manager HRA: " + project.calchar(basicSal));
            Console.WriteLine("Project manager DA: " + project.calcda(basicSal));
        }
    }
}
