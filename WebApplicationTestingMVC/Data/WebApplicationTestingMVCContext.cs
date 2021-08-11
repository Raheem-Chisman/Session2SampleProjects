using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationTestingMVC.Models;

namespace WebApplicationTestingMVC.Data
{
    public class WebApplicationTestingMVCContext : DbContext
    {
        public WebApplicationTestingMVCContext (DbContextOptions<WebApplicationTestingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationTestingMVC.Models.TodoItem> TodoItem { get; set; }
    }
}
