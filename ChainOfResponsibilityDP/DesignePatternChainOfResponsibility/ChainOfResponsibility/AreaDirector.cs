using DesignePatternChainOfResponsibility.DAL;
using DesignePatternChainOfResponsibility.Models;

namespace DesignePatternChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
                Context context = new Context();
                if (req.Amount <= 400000)
                {
                    CustomerProcess customerProcess = new CustomerProcess();
                    customerProcess.Amount = req.Amount.ToString();
                    customerProcess.Description = "Para çekme işlemi onaylandı";
                    customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Kadircan Kelebek - Area Director";
                    context.CustomerProcesses.Add(customerProcess);
                    context.SaveChanges();

                }
                else 
                {
                    CustomerProcess customerProcess = new CustomerProcess();
                    customerProcess.Amount = req.Amount.ToString();
                    customerProcess.Description = "400.000 LİRADAN FAZLA PARAYI 1 GÜN İÇİNDE ÇEKEMEZSİNİZ İYİ GÜNLER.";
                    customerProcess.Name = req.Name;
                    customerProcess.EmployeeName = "Kadircan Kelebek - Area Director";
                    context.CustomerProcesses.Add(customerProcess);
                    context.SaveChanges();
                }
        }
    }
}
