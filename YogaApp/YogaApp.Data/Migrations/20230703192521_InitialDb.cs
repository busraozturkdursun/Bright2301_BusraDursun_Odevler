using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YogaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5496), "Hatha yoga ismini Sanskritçe’de güneş ve ay anlamına gelen kelimelerden alır. Karşıt güçleri dengelemek için uygulanır. Bu yoga türünde denge, güç ve esneklikten, fiziksel ve zihinsel enerjiden veya nefes ve bedenden gelebilir. Hatha farklı stiller ve okullar için kapsayıcı bir kavramdır. Yani tüm yoga fiziksel hareketlerini kapsayan bir yoga türüdür. Fiziksel uygulamaya dayanan diğer ashtanga, iyengar gibi yoga stillerini içerir. Ancak fiziksel temelli kriya, raja ve karma yogadan ayrışır. Hatha, ‘güç’ anlamına gelir. Ancak bu güçlülük, vücuda daha fazla yüklenmek anlamına gelmez. Daha çok konsantrasyon ve uygulamaya işaret eder. Daha dengeli ve nazik hareketler içeren bir yogadır. Vücutta enerji noktalarının yoğunlaştığı ve 7 noktada yer alan çakra ve enerji noktaları arasındaki uyum üzerine çalışır. Araştırmalar, hatha yoga, stresin azaltılması, fiziksel olarak zindelik hissi ve daha genç bir görünüme sahip olmasını destekler. Sürekli yapıldığı takdirde kilo kaybına ve sıkı kaslara kavuşulmasını sağlar.", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5517), "Hatha Yoga", "hatha-yoga" },
                    { 2, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5523), "Ashtanga yoga daha çok kilo kaybı için uygulanan bir yoga türüdür. Sanskritçe ‘sekiz’ kelimesinden türetilmiştir. Ashtanga yoganın 8 ayağı vardır. Bu ayaklar; ilkeler, kişisel disiplin, asana ve duruşlar, pranayama, geri çekilme, konsantrasyon, meditasyon ve kurtuluştur. Vinyasa yoga ile bazı unsurları taşır", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5524), "Ashtanga Yoga", "ashtanga-yoga" },
                    { 3, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5527), "Vinyasa yoga bir tür akış yogası olarak da adlandırılır. Vinyasa kelime olarak Vi (vasyasyon) ve nyasa (öngörülen sınırlar) kelimelerinin birleştirilmesiyle oluşturulmuştur. Vinyasa yoga da hareket ve nefes alma tekniklerini birleştirir. Kontrollü nefes alma ile birlikte bir duruş akışı yaratır. Örneğin; akış bir çocuğun duruşu ile başlatılır ve savasana denen ölüm duruşuyla sonlandırılır. Her duruştaki geçişler ise yaşam boyunca süren hareketi temsil eder. Meditasyon ise ileri seviye vinyasa yoganın bir parçasıdır. Aerobik egzersiz gibi kalbe iyi gelir.", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5528), "Vinyasa Yoga", "vinyasa-yoga" },
                    { 4, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5530), "Iyengar yoga Bellur Krishnamachar Sundararaja Iyengar tarafından bulunmuş bir yoga türüdür. Hizalama, ayrıntılı ve hassas hareketlere odaklanırken nefes çeşitli duruşlarla kontrol edilir. Bu yoga türü vinyasa yogaya benzerdir. Duruş, vücut hizalaması ve vücudun açılması bu yoganın önceliğidir. Kusursuz duruşlar için yoga blokları ve kemerler kullanılabilir. ", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5531), "Iyengar Yoga", "iyengar-yoga" },
                    { 5, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5533), "Yin yoga, yoga ve dövüş sanatlarının karışımı olan bir yoga türüdür. Bu yoga ile eklemlerdeki kan dolaşımı artar, esneklik ve kas yoğunluğu gelişir. Yin yoga uzun süreli oturma duruşları içerir ve yavaş tempoludur. Dinginlik ve iç huzur için genellikle bu yoga türü tercih edilir. Kaliteli bir uyku için de yapılır.", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5534), "Yin Yoga", "yin-yoga" },
                    { 6, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5536), "Farkındalık yogası olarak da bilinen bu yoga türü, tekrarlayan pozisyonları içerir. Omurganın alt kısmında sıkışık şekilde bulunan spritüel Kundalini enerjisinin, yukarı doğru hareket ederek serbest kaldığı, böylece ruhsal iyileşmeye destek verdiğine inanılır. Bu nedenle de stres, kaygı, depresyon ve daha iyi bilişsel işlevler için iyi olduğu söylenir. Ruhsal ve fiziksel olarak eşit bir bütünlük sunar. ", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5537), "Kundalini Yoga", "kundalini-yoga" },
                    { 7, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5539), "Çeşitli duruşlarla rahatlama sağlamayı amaçlayan restoratif yogada vücuda destek sağlamak için aksesuarlar kullanılır. Rehber eşliğindeki meditasyon bu yoganın vazgeçilmez bir parçasıdır. Sinir sisteminin gevşemesini sağlayan bu yoga, sakinleşmek için tercih edilir. Uzun günün ardından özellikle dinlenmek için yapılan restoratif yoga, zihnin özgürleşmesine de yardımcı olur.", true, false, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(5539), "Restoratif Yoga", "restoratif-yoga" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "Age", "CategoryId", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Price", "Url" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 29, 1, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9239), "Büşra", true, false, "Öztürk", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9242), "busra-ozturk.jpeg", 500m, "busra-ozturk" },
                    { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.  ", 19, 2, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9255), "Nazlı", true, false, "Öztürk", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9256), "nazli-ozturk.jpeg", 300m, "nazli-ozturk" },
                    { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 35, 3, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9262), "Arzu", true, false, "Topaloglu", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9262), "busra-ozturk.jpeg", 450m, "arzu-topaloglu" },
                    { 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 20, 4, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9267), "Ayşe", true, false, "Doğan", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9267), "ayse-dogan.jpeg", 800m, "ayse-dogan" },
                    { 5, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 27, 5, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9272), "Zeynep", true, false, "Dursun", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9273), "zeynep-dursun.jpeg", 575m, "zeynep-dursun" },
                    { 6, " Hakkında kısmı", 32, 6, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9277), "Ülkü", true, false, "Boz", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9278), "ulku-boz.jpeg", 280m, "ulku-boz" },
                    { 7, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 28, 7, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9282), "Betül", true, false, "Çalık", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9283), "betul-calik.jpeg", 760m, "betul-calik" },
                    { 8, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 29, 6, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9287), "Erdinc", true, false, "Dursun", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9288), "erdinc-dursun.jpeg", 500m, "erdinc-dursun" },
                    { 9, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 42, 5, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9370), "Ceren", true, false, "Özkök", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9372), "ceren-ozkok.jpeg", 800m, "ceren-ozkok" },
                    { 10, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 25, 4, new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9377), "Zehra", true, false, "Yılmaz", new DateTime(2023, 7, 3, 22, 25, 21, 840, DateTimeKind.Local).AddTicks(9378), "zehra-yilmaz.jpeg", 300m, "zehra-yilmaz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CategoryId",
                table: "Instructors",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
