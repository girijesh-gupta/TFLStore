namespace HRWebAPI.DAL;
using HRWebAPI.Models;

public static class HRDBManager{
   public static  List<Employee> GetAll(){
    List<Employee> employees=new List<Employee>();
    employees.Add(new Employee{Id=1, FirstName="Manisha", LastName="Nene", Email="manish.nene@hotmail.com", ContactNumber="983454567"});
    employees.Add(new Employee{Id=2, FirstName="Rajesh", LastName="Sharma", Email="rajesh.sharma@hotmail.com", ContactNumber="983454545"});
    employees.Add(new Employee{Id=3, FirstName="Kavita", LastName="Shukla", Email="kavita.shukla@hotmail.com", ContactNumber="983476567"});  
    return employees;

}

public  static Employee GetById(int id){
   Employee emp= new Employee{Id=id, FirstName="Manisha",
                    LastName="Nene", Email="manish.nene@hotmail.com",
                    ContactNumber="983454567"};

    return emp;

}
}