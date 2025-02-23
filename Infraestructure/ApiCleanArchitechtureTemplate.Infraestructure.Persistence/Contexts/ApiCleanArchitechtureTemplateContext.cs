using System;
using Microsoft.EntityFrameworkCore;

namespace ApiCleanArchitechtureTemplate.Infraestructure.Persistence.Contexts;

public class ApiCleanArchitechtureTemplateContext : DbContext
{
    public ApiCleanArchitechtureTemplateContext(DbContextOptions<ApiCleanArchitechtureTemplateContext> options) : base(options)
    {

    }
}
