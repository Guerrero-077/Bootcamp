using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.DataInit
{
    internal class CardSeeder : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
                new Card { Id = 1, Url = "https://guerrero-077.github.io/imagenes/img/img1.png", Force = 52, Speed = 45, Popularity = 46, Appearances = 33, IQ = 59, Resistance = 53 },
                new Card { Id = 2, Url = "https://guerrero-077.github.io/imagenes/img/img2.png", Force = 59, Speed = 50, Popularity = 52, Appearances = 36, IQ = 63, Resistance = 56 },
                new Card { Id = 3, Url = "https://guerrero-077.github.io/imagenes/img/img3.png", Force = 66, Speed = 55, Popularity = 58, Appearances = 39, IQ = 67, Resistance = 60 },
                new Card { Id = 4, Url = "https://guerrero-077.github.io/imagenes/img/img4.png", Force = 73, Speed = 60, Popularity = 64, Appearances = 42, IQ = 71, Resistance = 64 },
                new Card { Id = 5, Url = "https://guerrero-077.github.io/imagenes/img/img5.png", Force = 80, Speed = 65, Popularity = 70, Appearances = 45, IQ = 75, Resistance = 68 },
                new Card { Id = 6, Url = "https://guerrero-077.github.io/imagenes/img/img6.png", Force = 87, Speed = 70, Popularity = 76, Appearances = 48, IQ = 79, Resistance = 72 },
                new Card { Id = 7, Url = "https://guerrero-077.github.io/imagenes/img/img7.png", Force = 94, Speed = 75, Popularity = 82, Appearances = 51, IQ = 83, Resistance = 76 },
                new Card { Id = 8, Url = "https://guerrero-077.github.io/imagenes/img/img8.png", Force = 45, Speed = 80, Popularity = 88, Appearances = 54, IQ = 87, Resistance = 62 },
                new Card { Id = 9, Url = "https://guerrero-077.github.io/imagenes/img/img9.png", Force = 52, Speed = 85, Popularity = 94, Appearances = 57, IQ = 56, Resistance = 57 },
                new Card { Id = 10, Url = "https://guerrero-077.github.io/imagenes/img/img10.png", Force = 59, Speed = 40, Popularity = 40, Appearances = 60, IQ = 60, Resistance = 60 },
                new Card { Id = 11, Url = "https://guerrero-077.github.io/imagenes/img/img11.png", Force = 66, Speed = 45, Popularity = 46, Appearances = 63, IQ = 64, Resistance = 62 },
                new Card { Id = 12, Url = "https://guerrero-077.github.io/imagenes/img/img12.png", Force = 73, Speed = 50, Popularity = 52, Appearances = 66, IQ = 68, Resistance = 65 },
                new Card { Id = 13, Url = "https://guerrero-077.github.io/imagenes/img/img13.png", Force = 80, Speed = 55, Popularity = 58, Appearances = 69, IQ = 72, Resistance = 68 },
                new Card { Id = 14, Url = "https://guerrero-077.github.io/imagenes/img/img14.png", Force = 87, Speed = 60, Popularity = 64, Appearances = 72, IQ = 76, Resistance = 71 },
                new Card { Id = 15, Url = "https://guerrero-077.github.io/imagenes/img/img15.png", Force = 94, Speed = 65, Popularity = 70, Appearances = 30, IQ = 80, Resistance = 74 },
                new Card { Id = 16, Url = "https://guerrero-077.github.io/imagenes/img/img16.png", Force = 45, Speed = 70, Popularity = 76, Appearances = 33, IQ = 84, Resistance = 60 },
                new Card { Id = 17, Url = "https://guerrero-077.github.io/imagenes/img/img17.png", Force = 52, Speed = 75, Popularity = 82, Appearances = 36, IQ = 88, Resistance = 63 },
                new Card { Id = 18, Url = "https://guerrero-077.github.io/imagenes/img/img18.png", Force = 59, Speed = 80, Popularity = 88, Appearances = 39, IQ = 57, Resistance = 59 },
                new Card { Id = 19, Url = "https://guerrero-077.github.io/imagenes/img/img19.png", Force = 66, Speed = 85, Popularity = 94, Appearances = 42, IQ = 61, Resistance = 61 },
                new Card { Id = 20, Url = "https://guerrero-077.github.io/imagenes/img/img20.png", Force = 73, Speed = 40, Popularity = 40, Appearances = 45, IQ = 65, Resistance = 69 },
                new Card { Id = 21, Url = "https://guerrero-077.github.io/imagenes/img/img21.png", Force = 80, Speed = 45, Popularity = 46, Appearances = 48, IQ = 69, Resistance = 65 },
                new Card { Id = 22, Url = "https://guerrero-077.github.io/imagenes/img/img22.png", Force = 87, Speed = 50, Popularity = 52, Appearances = 51, IQ = 73, Resistance = 68 },
                new Card { Id = 23, Url = "https://guerrero-077.github.io/imagenes/img/img23.png", Force = 94, Speed = 55, Popularity = 58, Appearances = 54, IQ = 77, Resistance = 71 },
                new Card { Id = 24, Url = "https://guerrero-077.github.io/imagenes/img/img24.png", Force = 45, Speed = 60, Popularity = 64, Appearances = 57, IQ = 81, Resistance = 64 },
                new Card { Id = 25, Url = "https://guerrero-077.github.io/imagenes/img/img25.png", Force = 52, Speed = 65, Popularity = 70, Appearances = 60, IQ = 85, Resistance = 67 },
                new Card { Id = 26, Url = "https://guerrero-077.github.io/imagenes/img/img26.png", Force = 59, Speed = 70, Popularity = 76, Appearances = 63, IQ = 66, Resistance = 60 },
                new Card { Id = 27, Url = "https://guerrero-077.github.io/imagenes/img/img27.png", Force = 66, Speed = 75, Popularity = 82, Appearances = 66, IQ = 70, Resistance = 63 },
                new Card { Id = 28, Url = "https://guerrero-077.github.io/imagenes/img/img28.png", Force = 73, Speed = 80, Popularity = 88, Appearances = 69, IQ = 74, Resistance = 66 },
                new Card { Id = 29, Url = "https://guerrero-077.github.io/imagenes/img/img29.png", Force = 80, Speed = 85, Popularity = 94, Appearances = 72, IQ = 78, Resistance = 69 },
                new Card { Id = 30, Url = "https://guerrero-077.github.io/imagenes/img/img30.png", Force = 87, Speed = 40, Popularity = 40, Appearances = 30, IQ = 82, Resistance = 72 },
                new Card { Id = 31, Url = "https://guerrero-077.github.io/imagenes/img/img31.png", Force = 94, Speed = 45, Popularity = 46, Appearances = 33, IQ = 86, Resistance = 75 },
                new Card { Id = 32, Url = "https://guerrero-077.github.io/imagenes/img/img32.png", Force = 45, Speed = 50, Popularity = 52, Appearances = 36, IQ = 90, Resistance = 62 },
                new Card { Id = 33, Url = "https://guerrero-077.github.io/imagenes/img/img33.png", Force = 52, Speed = 55, Popularity = 58, Appearances = 39, IQ = 61, Resistance = 65 },
                new Card { Id = 34, Url = "https://guerrero-077.github.io/imagenes/img/img34.png", Force = 59, Speed = 60, Popularity = 64, Appearances = 42, IQ = 65, Resistance = 68 },
                new Card { Id = 35, Url = "https://guerrero-077.github.io/imagenes/img/img35.png", Force = 66, Speed = 65, Popularity = 70, Appearances = 45, IQ = 69, Resistance = 71 },
                new Card { Id = 36, Url = "https://guerrero-077.github.io/imagenes/img/img36.png", Force = 73, Speed = 70, Popularity = 76, Appearances = 48, IQ = 73, Resistance = 74 },
                new Card { Id = 37, Url = "https://guerrero-077.github.io/imagenes/img/img37.png", Force = 80, Speed = 75, Popularity = 82, Appearances = 51, IQ = 77, Resistance = 77 },
                new Card { Id = 38, Url = "https://guerrero-077.github.io/imagenes/img/img38.png", Force = 87, Speed = 80, Popularity = 88, Appearances = 54, IQ = 81, Resistance = 80 },
                new Card { Id = 39, Url = "https://guerrero-077.github.io/imagenes/img/img39.png", Force = 94, Speed = 85, Popularity = 94, Appearances = 57, IQ = 85, Resistance = 83 },
                new Card { Id = 40, Url = "https://guerrero-077.github.io/imagenes/img/img40.png", Force = 45, Speed = 40, Popularity = 40, Appearances = 60, IQ = 89, Resistance = 66 },
                new Card { Id = 41, Url = "https://guerrero-077.github.io/imagenes/img/img41.png", Force = 52, Speed = 45, Popularity = 46, Appearances = 63, IQ = 93, Resistance = 69 },
                new Card { Id = 42, Url = "https://guerrero-077.github.io/imagenes/img/img42.png", Force = 59, Speed = 50, Popularity = 52, Appearances = 66, IQ = 66, Resistance = 72 },
                new Card { Id = 43, Url = "https://guerrero-077.github.io/imagenes/img/img43.png", Force = 66, Speed = 55, Popularity = 58, Appearances = 69, IQ = 70, Resistance = 75 },
                new Card { Id = 44, Url = "https://guerrero-077.github.io/imagenes/img/img44.png", Force = 73, Speed = 60, Popularity = 64, Appearances = 72, IQ = 74, Resistance = 78 },
                new Card { Id = 45, Url = "https://guerrero-077.github.io/imagenes/img/img45.png", Force = 80, Speed = 65, Popularity = 70, Appearances = 30, IQ = 78, Resistance = 81 },
                new Card { Id = 46, Url = "https://guerrero-077.github.io/imagenes/img/img46.png", Force = 87, Speed = 70, Popularity = 76, Appearances = 33, IQ = 82, Resistance = 84 },
                new Card { Id = 47, Url = "https://guerrero-077.github.io/imagenes/img/img47.png", Force = 94, Speed = 75, Popularity = 82, Appearances = 36, IQ = 86, Resistance = 87 },
                new Card { Id = 48, Url = "https://guerrero-077.github.io/imagenes/img/img48.png", Force = 45, Speed = 80, Popularity = 88, Appearances = 39, IQ = 90, Resistance = 70 },
                new Card { Id = 49, Url = "https://guerrero-077.github.io/imagenes/img/img49.png", Force = 52, Speed = 85, Popularity = 94, Appearances = 42, IQ = 62, Resistance = 73 },
                new Card { Id = 50, Url = "https://guerrero-077.github.io/imagenes/img/img50.png", Force = 59, Speed = 40, Popularity = 40, Appearances = 45, IQ = 66, Resistance = 76 },
                new Card { Id = 51, Url = "https://guerrero-077.github.io/imagenes/img/img51.png", Force = 66, Speed = 45, Popularity = 46, Appearances = 48, IQ = 70, Resistance = 79 },
                new Card { Id = 52, Url = "https://guerrero-077.github.io/imagenes/img/img52.png", Force = 73, Speed = 50, Popularity = 52, Appearances = 51, IQ = 74, Resistance = 82 },
                new Card { Id = 53, Url = "https://guerrero-077.github.io/imagenes/img/img53.png", Force = 80, Speed = 55, Popularity = 58, Appearances = 54, IQ = 78, Resistance = 85 },
                new Card { Id = 54, Url = "https://guerrero-077.github.io/imagenes/img/img54.png", Force = 87, Speed = 60, Popularity = 64, Appearances = 57, IQ = 82, Resistance = 88 },
                new Card { Id = 55, Url = "https://guerrero-077.github.io/imagenes/img/img55.png", Force = 94, Speed = 65, Popularity = 70, Appearances = 60, IQ = 86, Resistance = 91 },
                new Card { Id = 56, Url = "https://guerrero-077.github.io/imagenes/img/img56.png", Force = 45, Speed = 70, Popularity = 76, Appearances = 63, IQ = 69, Resistance = 58 }
            );
        }
    }
}
