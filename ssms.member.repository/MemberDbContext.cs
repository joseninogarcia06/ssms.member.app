using Microsoft.EntityFrameworkCore;

public class MemberDbContext : DbContext
{
    public DbSet<UserEntity> User { get; set; }

    public MemberDbContext(DbContextOptions<MemberDbContext> options): base(options){}
}