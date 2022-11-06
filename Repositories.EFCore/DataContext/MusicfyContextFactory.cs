using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.DataContext
{
    public class MusicfyContextFactory : IDesignTimeDbContextFactory<MusicfyContext>
    {
        public MusicfyContext CreateDbContext(string[] args)
        {
            var OptionBuilder =
                new DbContextOptionsBuilder<MusicfyContext>();

            OptionBuilder.UseSqlServer("Server=.;Database=MusicfyDB;Trusted_Connection=True;");
            return new MusicfyContext(OptionBuilder.Options);
        }


    }
}
