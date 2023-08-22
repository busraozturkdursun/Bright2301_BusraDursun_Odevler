using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Entity.Concrete;

namespace YogaApp.Data.Concrete.EfCore.Configs
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData
                (
                new Instructor
                {
                    Id = 1,
                    FirstName = "Büşra",
                    LastName = "Öztürk",
                    Age = 29,
                    About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Url = "busra-ozturk",
                    PhotoUrl = "busra-ozturk.jpeg",
                    CategoryId = 1,
                    Price = 500

                },
                 new Instructor
                 {
                     Id = 2,
                     FirstName = "Nazlı",
                     LastName = "Öztürk",
                     Age = 19,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.  ",
                     Url = "nazli-ozturk",
                     PhotoUrl = "nazli-ozturk.jpeg",
                     CategoryId = 2,
                     Price = 300

                 }, new Instructor
                 {
                     Id = 3,
                     FirstName = "Arzu",
                     LastName = "Topaloglu",
                     Age = 35,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "arzu-topaloglu",
                     PhotoUrl = "busra-ozturk.jpeg",
                     CategoryId = 3,
                     Price = 450

                 }, new Instructor
                 {
                     Id = 4,
                     FirstName = "Ayşe",
                     LastName = "Doğan",
                     Age = 20,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "ayse-dogan",
                     PhotoUrl = "ayse-dogan.jpeg",
                     CategoryId = 4,
                     Price = 800

                 }, new Instructor
                 {
                     Id = 5,
                     FirstName = "Zeynep",
                     LastName = "Dursun",
                     Age = 27,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "zeynep-dursun",
                     PhotoUrl = "zeynep-dursun.jpeg",
                     CategoryId = 5,
                     Price = 575

                 }, new Instructor
                 {
                     Id = 6,
                     FirstName = "Ülkü",
                     LastName = "Boz",
                     Age = 32,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "ulku-boz",
                     PhotoUrl = "ulku-boz.jpeg",
                     CategoryId = 6,
                     Price = 280

                 }, new Instructor
                 {
                     Id = 7,
                     FirstName = "Betül",
                     LastName = "Çalık",
                     Age = 28,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "betul-calik",
                     PhotoUrl = "betul-calik.jpeg",
                     CategoryId = 7,
                     Price = 760

                 }, new Instructor
                 {
                     Id = 8,
                     FirstName = "Erdinc",
                     LastName = "Dursun",
                     Age = 29,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "erdinc-dursun",
                     PhotoUrl = "erdinc-dursun.jpeg",
                     CategoryId = 6,
                     Price = 500

                 }, new Instructor
                 {
                     Id = 9,
                     FirstName = "Ceren",
                     LastName = "Özkök",
                     Age = 42,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "ceren-ozkok",
                     PhotoUrl = "ceren-ozkok.jpeg",
                     CategoryId = 5,
                     Price = 800

                 }, new Instructor
                 {
                     Id = 10,
                     FirstName = "Zehra",
                     LastName = "Yılmaz",
                     Age = 25,
                     About = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Url = "zehra-yilmaz",
                     PhotoUrl = "zehra-yilmaz.jpeg",
                     CategoryId = 4,
                     Price = 300

                 }

                );



        }
    }
}