using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AT20231030_MediaAluno.Models;

namespace AT20231030_MediaAluno.Data
{
    public class AT20231030_MediaAlunoContext : DbContext
    {
        public AT20231030_MediaAlunoContext (DbContextOptions<AT20231030_MediaAlunoContext> options)
            : base(options)
        {
        }

        public DbSet<AT20231030_MediaAluno.Models.Aluno> Aluno { get; set; } = default!;
    }
}
