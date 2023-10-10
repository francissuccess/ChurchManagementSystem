using ChurchManagementSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ChurchManagementSystem.DataAccess
{
    public interface IApplicationDbContext
    {
        DbSet<Pastor> Pastors { get; set; }
        DbSet<ChurchWorker> ChurchWorkers { get; set; }
        DbSet<ChurchMember> ChurchMembers { get; set; }
        DbSet<Choir> Choirs { get; set; }
        DbSet<Counselling> Counsellings { get; set; }
        DbSet<Media> Medias { get; set; }
        DbSet<Security> Securities { get; set; }
        DbSet<SourceofIncome> SourceofIncomes { get; set; }
        DbSet<Ushering> Usherings { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}