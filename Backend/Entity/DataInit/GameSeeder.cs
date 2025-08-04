using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.DataInit
{
    public class GameSeeder : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(

                new Game
                {
                    Id = 1,
                    CreateAt = new DateTime(25, 1, 1)
                }
            );
        }

    }
}