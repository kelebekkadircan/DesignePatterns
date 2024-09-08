using DesignePatternChainOfResponsibility.Models;

namespace DesignePatternChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void setNextApprover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel req);

    }
}
