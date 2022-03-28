using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IUnitOfWork
    {
         DbSet<Product> Products { get; set; }

         DbSet<Category> Categories { get; set; }

        Task SaveChangesAsync();
    }
}
