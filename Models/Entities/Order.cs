using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoServiceApp.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int OrderStatusId { get; set; } = 0;
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;}

        public Order(int id, string description,int customerId,int employeeId,int orderStatusId,DateTime createdDate, DateTime updatedDate)
        { this.Id = id;
            this.Description = description;
            this.CustomerId = customerId;
            this.EmployeeId = employeeId;
            this.OrderStatusId = orderStatusId;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }
     



    }
}
