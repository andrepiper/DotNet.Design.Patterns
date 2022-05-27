using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class EmployeeSingleton : GenericSingleton<EmployeeSingleton>
    {
        private readonly List<Employee> _fakeDb;
        private EmployeeSingleton() 
        {
            _fakeDb = new List<Employee>();
        }

		public new static EmployeeSingleton Instance
		{
			get
			{
				EmployeeSingleton.initializer(() =>
				{
					Console.WriteLine("System: Employee Singleton Initialized");
					return new EmployeeSingleton();
				});
				return GenericSingleton<EmployeeSingleton>.Instance;
			}
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public void Add(Employee employee)
        {
            if (employee != null) _fakeDb.Add(employee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Employee> List()
        {
            return _fakeDb;
        }
    }
}
