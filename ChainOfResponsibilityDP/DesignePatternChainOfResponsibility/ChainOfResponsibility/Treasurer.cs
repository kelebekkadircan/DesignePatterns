using DesignePatternChainOfResponsibility.DAL;
using DesignePatternChainOfResponsibility.Models;

namespace DesignePatternChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Description = "Para çekme işlemi onaylandı";
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Yelizcan - Treasurer";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else if ( NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Description = "Tutar veznedarın günlük ödeyebileceği limiti aştığı için yönlendirildi";
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Yelizcan - Treasurer";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }

    }
}
