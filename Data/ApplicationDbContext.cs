using Microsoft.EntityFrameworkCore;

namespace BayNhanhWeb.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{

}
