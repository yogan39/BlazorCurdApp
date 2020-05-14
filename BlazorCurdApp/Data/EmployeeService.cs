using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCurdApp.Data
{
    public class EmployeeService
    {
        public readonly AppDB _db;
         
        public EmployeeService(AppDB  db)
        {
            _db = db;
        }

        //CURD Operation

        //Get All Employee
        public List<Employinfo> GetEmployinfos()
        {
            var emplist = _db.Employees.ToList();
            return emplist;
        }

        //Insert
        public void CreateEmp(Employinfo objemp)
        {
            _db.Employees.Add(objemp);
            _db.SaveChanges();
            //return objemp.Name + "  Added Succesfully";
        }

        //Update
        public void UpdateEmp(Employinfo objemp)
        {
            _db.Employees.Update(objemp);
            _db.SaveChanges();
           // return objemp.Name + "  Updated Succesfully";
        }

        //Delete
        public void DeleteEmp(Employinfo objemp)
        {
            _db.Employees.Remove(objemp);
            _db.SaveChanges();
           // return objemp.Name + "  Deleted Succesfully";
        }

        // get EmployeeBY ID
        public Employinfo GetEmpbyID(int id)
        {
            Employinfo emp = _db.Employees.FirstOrDefault(s => s.EmployeeID == id);
            return emp;
        }





    }
}
