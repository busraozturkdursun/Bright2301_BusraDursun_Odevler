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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData
                (
                new Category
                {
                    Id = 1,
                    Name = "Hatha Yoga",
                    Description = "Hatha yoga ismini Sanskritçe’de güneş ve ay anlamına gelen kelimelerden alır. Karşıt güçleri dengelemek için uygulanır. Bu yoga türünde denge, güç ve esneklikten, fiziksel ve zihinsel enerjiden veya nefes ve bedenden gelebilir. Hatha farklı stiller ve okullar için kapsayıcı bir kavramdır. Yani tüm yoga fiziksel hareketlerini kapsayan bir yoga türüdür. Fiziksel uygulamaya dayanan diğer ashtanga, iyengar gibi yoga stillerini içerir. Ancak fiziksel temelli kriya, raja ve karma yogadan ayrışır. Hatha, ‘güç’ anlamına gelir. Ancak bu güçlülük, vücuda daha fazla yüklenmek anlamına gelmez. Daha çok konsantrasyon ve uygulamaya işaret eder. Daha dengeli ve nazik hareketler içeren bir yogadır. Vücutta enerji noktalarının yoğunlaştığı ve 7 noktada yer alan çakra ve enerji noktaları arasındaki uyum üzerine çalışır. Araştırmalar, hatha yoga, stresin azaltılması, fiziksel olarak zindelik hissi ve daha genç bir görünüme sahip olmasını destekler. Sürekli yapıldığı takdirde kilo kaybına ve sıkı kaslara kavuşulmasını sağlar.",
                    Url = "hatha-yoga"
                },

                 new Category
                 {
                     Id = 2,
                     Name = "Ashtanga Yoga",
                     Description = "Ashtanga yoga daha çok kilo kaybı için uygulanan bir yoga türüdür. Sanskritçe ‘sekiz’ kelimesinden türetilmiştir. Ashtanga yoganın 8 ayağı vardır. Bu ayaklar; ilkeler, kişisel disiplin, asana ve duruşlar, pranayama, geri çekilme, konsantrasyon, meditasyon ve kurtuluştur. Vinyasa yoga ile bazı unsurları taşır",
                     Url = "ashtanga-yoga"
                 },
                 new Category
                 {
                     Id = 3,
                     Name = "Vinyasa Yoga",
                     Description = "Vinyasa yoga bir tür akış yogası olarak da adlandırılır. Vinyasa kelime olarak Vi (vasyasyon) ve nyasa (öngörülen sınırlar) kelimelerinin birleştirilmesiyle oluşturulmuştur. Vinyasa yoga da hareket ve nefes alma tekniklerini birleştirir. Kontrollü nefes alma ile birlikte bir duruş akışı yaratır. Örneğin; akış bir çocuğun duruşu ile başlatılır ve savasana denen ölüm duruşuyla sonlandırılır. Her duruştaki geçişler ise yaşam boyunca süren hareketi temsil eder. Meditasyon ise ileri seviye vinyasa yoganın bir parçasıdır. Aerobik egzersiz gibi kalbe iyi gelir.",
                     Url = "vinyasa-yoga"
                 }, new Category
                 {
                     Id = 4,
                     Name = "Iyengar Yoga",
                     Description = "Iyengar yoga Bellur Krishnamachar Sundararaja Iyengar tarafından bulunmuş bir yoga türüdür. Hizalama, ayrıntılı ve hassas hareketlere odaklanırken nefes çeşitli duruşlarla kontrol edilir. Bu yoga türü vinyasa yogaya benzerdir. Duruş, vücut hizalaması ve vücudun açılması bu yoganın önceliğidir. Kusursuz duruşlar için yoga blokları ve kemerler kullanılabilir. ",
                     Url = "iyengar-yoga"
                 },
                new Category
                {
                    Id = 5,
                    Name = "Yin Yoga",
                    Description = "Yin yoga, yoga ve dövüş sanatlarının karışımı olan bir yoga türüdür. Bu yoga ile eklemlerdeki kan dolaşımı artar, esneklik ve kas yoğunluğu gelişir. Yin yoga uzun süreli oturma duruşları içerir ve yavaş tempoludur. Dinginlik ve iç huzur için genellikle bu yoga türü tercih edilir. Kaliteli bir uyku için de yapılır.",
                    Url = "yin-yoga"
                },
                new Category
                {
                    Id = 6,
                    Name = "Kundalini Yoga",
                    Description = "Farkındalık yogası olarak da bilinen bu yoga türü, tekrarlayan pozisyonları içerir. Omurganın alt kısmında sıkışık şekilde bulunan spritüel Kundalini enerjisinin, yukarı doğru hareket ederek serbest kaldığı, böylece ruhsal iyileşmeye destek verdiğine inanılır. Bu nedenle de stres, kaygı, depresyon ve daha iyi bilişsel işlevler için iyi olduğu söylenir. Ruhsal ve fiziksel olarak eşit bir bütünlük sunar. ",
                    Url = "kundalini-yoga"
                },
                new Category
                {
                    Id = 7,
                    Name = "Restoratif Yoga",
                    Description = "Çeşitli duruşlarla rahatlama sağlamayı amaçlayan restoratif yogada vücuda destek sağlamak için aksesuarlar kullanılır. Rehber eşliğindeki meditasyon bu yoganın vazgeçilmez bir parçasıdır. Sinir sisteminin gevşemesini sağlayan bu yoga, sakinleşmek için tercih edilir. Uzun günün ardından özellikle dinlenmek için yapılan restoratif yoga, zihnin özgürleşmesine de yardımcı olur.",
                    Url = "restoratif-yoga"
                }

                );
        }
    }
}