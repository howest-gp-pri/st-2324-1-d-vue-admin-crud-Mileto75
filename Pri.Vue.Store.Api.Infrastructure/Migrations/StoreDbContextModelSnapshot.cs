﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pri.Vue.Store.Api.Infrastructure.Data;

#nullable disable

namespace Pri.Vue.Store.Api.Infrastructure.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "Admin",
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Pri.Vue.Store.Api.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Birthday = new DateTime(1982, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "e834f602-f9e4-4914-b4ea-e884c28f546f",
                            Email = "admin@bull.com",
                            EmailConfirmed = true,
                            ImageUrl = "images/users/1.jpg",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@BULL.COM",
                            NormalizedUserName = "ADMIN@BULL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEN4Y1NW4OubpNTrgzcDi7BNi/7Zyv1a1YTkvkystAUXQiq6K0r/WpN1NFHYuhv/oOw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "df7fa394-ce00-468f-8d16-81b5b2930aa4",
                            TwoFactorEnabled = false,
                            UserName = "admin@bull.com"
                        });
                });

            modelBuilder.Entity("Pri.Vue.Store.Api.Core.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ImageUrl = "images/categories/books.jpg",
                            Name = "Boeken"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            ImageUrl = "images/categories/games.jpg",
                            Name = "Games"
                        });
                });

            modelBuilder.Entity("Pri.Vue.Store.Api.Core.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PegiRating")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "<p>Even bad code can function. But if code isn't clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn't have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code on the fly into a book that will instill within you the values of a software craftsman and make you a better programmer-but only if you work at it. What kind of work will you be doing? You'll be reading code-lots of code. And you will be challenged to think about what's right about that code, and what's wrong with it. More importantly, you will be challenged to reassess your professional values and your commitment to your craft. Clean Code is divided into three parts. The first describes the principles, patterns, and practices of writing clean code. The second part consists of several case studies of increasing complexity. Each case study is an exercise in cleaning up code-of transforming a code base that has some problems into one that is sound and efficient. The third part is the payoff: a single chapter containing a list of heuristics and smells gathered while creating the case studies. The result is a knowledge base that describes the way we think when we write, read, and clean code. Readers will come away from this book understanding How to tell the difference between good and bad code How to write good code and how to transform bad code into good code How to create good names, good functions, good objects, and good classes How to format code for maximum readability How to implement complete error handling without obscuring code logic How to unit test and practice test-driven development This book is a must for any developer, software engineer, project manager, team lead, or systems analyst with an interest in producing better code.</p>",
                            ImageUrl = "images/products/00000000-0000-0000-0000-000000000001.jpg",
                            Name = "Clean Code",
                            Price = 28.789999999999999
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "<p>Building upon the success of best-sellers The Clean Coder and Clean Code, legendary software craftsman Robert C. Uncle Bob Martin shows how to bring greater professionalism and discipline to application architecture and design. As with his other books, Martin's Clean Architecture doesn't merely present multiple choices and options, and say use your best judgment : it tells you what choices to make, and why those choices are critical to your success. Martin offers direct, no-nonsense answers to key architecture and design questions like: What are the best high level structures for different kinds of applications, including web, database, thick-client, console, and embedded apps? What are the core principles of software architecture? What is the role of the architect, and what is he/she really trying to achieve? What are the core principles of software design? How do designs and architectures go wrong, and what can you do about it? What are the disciplines and practices of professional architects and designers? Clean Architecture is essential reading for every software architect, systems analyst, system designer, and software manager -- and for any programmer who aspires to these roles or is impacted by their work.</p>",
                            ImageUrl = "images/products/00000000-0000-0000-0000-000000000002.jpg",
                            Name = "Clean Architecture",
                            Price = 21.489999999999998
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "<p>Welkom in het nieuwe tijdperk van Call of Duty. Met de terugkeer van de iconische kapitein John Price, de onverschrokken John \"Soap\" MacTavish, de veteraan sergeant Kyle \"Gaz\" Garrick en de eenzame wolf zelf, de fan-favoriete operator Simon \"Ghost\" Riley. Spelers zullen ontdekken wat Task Force 141 tot de legendarische eenheid maakt die het nu is. Call of Duty: Modern Warfare II is het vervolg op de kaskraker van 2019, Modern Warfare.</p><p><strong>Vorm je team en vecht aan de zijde van de Task Force 141</strong></p><p>CoD: Modern Warfare II zal vanaf dag één een grote hoeveelheid content bevatten: vorm je team en vecht aan de zijde van de TF141 in een singleplayer-campagne over de hele wereld, speel alleen of als team in meeslepende multiplayer-gevechten met nieuwe locaties en manieren om te spelen, en ervaar een geavanceerder, verhaalgedreven speltype Special Operations met coöperatief tactisch spel.</p><p>Van kleinschalige infiltratietactieken tot zeer geheime missies, spelers zullen nieuwe wapens, voertuigen en uitrusting moeten gebruiken om het op te nemen tegen hun vijanden. Rust jezelf uit en ga de strijd aan op zee door vijanden onder water te belegeren, een sterk versterkte vijandelijke basis binnen te dringen, langs kanalen te infiltreren en belangrijke bondgenoten te bevrijden op een clandestiene plek die in de bergen verborgen ligt.</p><p><strongAansluiting met Warzone</strong></p>Bovendien sluit Modern Warfare II aan op de nieuwe Warzone-ervaring die dit jaar uitkomt, en daarmee op de evolutie van de Battle Pass met een volledig nieuwe speelruimte en sandbox-modus. Verwacht een schema vol gratis content na de lancering, waarin de gameplay evolueert met nieuwe maps, nieuwe modes, seizoensevents, community-feesten en meer.</p>",
                            ImageUrl = "images/products/00000000-0000-0000-0000-000000000003.jpg",
                            Name = "Call of Duty: Modern Warfare II - C.O.D.E. Editie – PS5",
                            PegiRating = 18,
                            Price = 74.790000000000006
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "<p>Dit is Far Cry 6 - Yara Edition op de Playstation 5 (PS5). Welkom in Yara, een tropisch paradijs dat vastzit in het verleden. Anton Castillo is de dictator van Yara en wil zijn natie koste wat kost terugbrengen naar zijn oude glorie. Zijn zoon Diego volgt in zijn bloederige voetstappen. Hun meedogenloze onderdrukking heeft een revolutie ontketend. Hou deze productpagina in de gaten voor het laatste nieuws omtrent Far Cry 6.</p><p><strong>Vecht voor vrijheid</strong></p><p>Speel als Dani Rojas, een inwoner van Yara, en word een guerrillastrijder die de natie wil bevrijden</p><p><strong>Een verscheurd Yara</strong></p><p>Vecht tegen Antons troepen in het grootste speelveld ooit in een Far Cry-game, met jungles, stranden en hoofdstad Esperanza</p><p><strong>Guerrilla-vuurkracht</strong></p><p>Gebruik geïmproviseerde wapens, voertuigen en de nieuwe huurlingen Amigos om het tirannieke regime omver te werpen</p>",
                            ImageUrl = "images/products/00000000-0000-0000-0000-000000000004.jpg",
                            Name = "Far Cry 6 Yara Edition - PS5",
                            PegiRating = 18,
                            Price = 24.789999999999999
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "<p>Spring in de gigantische multiplayer speeltuin van RIDERS REPUBLIC™! Ontmoet andere spelers en neem het tegen hen op. Rijd hard met een spannend scala aan activiteiten zoals fietsen, skiën, snowboarden, wingsuit en rocket wingsuit.</p><p>Beleef de fantasie van een extreme sporter terwijl je je vrij verplaatst in een enorme, levendige open wereld die altijd bruist van andere spelers om je heen. Dompel je onder in de iconische Amerikaanse nationale parken zoals Bryce Canyon, Yosemite Valley, Mammoth Mountain... allemaal voor je klaargezet om te overwinnen!</p><p>Ga samen met je vrienden de strijd aan in een breed scala aan multiplayer-modi: voel de rush van downhill races, domineer de tracks in team- vs teamcompetities, of laat zien wat je kunt in epische massa PvP-races met meer dan 50 andere spelers(1).</p><p>Ga er helemaal voor. Doe mee aan de waanzin!</p><p><strong>Belangrijkste kenmerken</strong></p><p>SPRING IN EEN GIGANTISCHE SOCIALE SPEELTUIN – Waar en wanneer je ook rijdt, je bevindt je altijd tussen andere spelers. Van besneeuwde bergen tot diepe ravijnen, rijd door de meest mooie bestemmingen op aarde: de Amerikaanse Nationale Parken. Bryce Canyon, Yosemite Valley, Sequoia Park, Zion, Canyonlands, Mammoth Mountain en Grand Teton worden allemaal trouw weergegeven en zijn samengebracht tot de meest unieke en levendige speeltuin. Verzamel in een levendige sociale hub en ontmoet een wilde community aan medesporters. Check hun vaardigheden en uiterlijk, zeg hallo of kom gewoon even langs, het is aan jou.</p><p>SPEEL MET OF TEGEN JE VRIENDEN IN KRANKZINNIGE MULTIPLAYER-MODI – Geniet van een volwaardige multiplayer-ervaring met een grote verscheidenheid aan modi:</p><ul><li>Competitieve wedstrijden en trick-uitdagingen: speelbaar in PvP / Co-op / Solo</li><li>Massastart: hectische races met meer dan 50 spelers waarin niets verboden is(1)</li><li>Multiplayer-arena's: 6x6 team PvP-matchups</li><li>Online Cups: alleen voor de allerbeste, werk je een weg naar boven in het klassement.</li></ul><p>WERK AAN JE CARRIÈRE EN BAAN JE EEN WEG NAAR DE TOP – Creëer en vorm je eigen sporter door middel van innovatieve, progressieve uitrusting en bepaal elk aspect van je avatar. Of je nu de beste snowboarder ter wereld wilt zijn of de snelste op twee wielen, alles is mogelijk. Maak naam in verschillende sporten, baan je een weg naar de top van de ranglijsten in de carrièremodus en teken bij legendarische sponsors uit een breed scala aan outdoor-actiesporten.</p><p>HAAL HET MEESTE UIT DE NEXT GEN GAMEPLAY – RIDERS REPUBLIC™ is speelbaar aan 60 FPS op de next gen consoles en zal meer dan 50 spelers tegelijkertijd live op het scherm weergeven. Dankzij het zeer intuïtieve karakter van de game en de camerabesturing in combinatie met een innovatief trucsysteem, krijgen alle spelers, zowel casual als hardcore, de kans om vanaf het allereerste begin ongekende vreugde te ervaren.</p><p>(1) Riders Republic™ zal meer dan 50 spelers weergeven op de volgende generatie consoles & PC, en meer dan 20 spelers op de huidige generatie consoles.</p>",
                            ImageUrl = "images/products/00000000-0000-0000-0000-000000000005.jpg",
                            Name = "Riders Republic - PS5",
                            PegiRating = 12,
                            Price = 23.789999999999999
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Pri.Vue.Store.Api.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pri.Vue.Store.Api.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pri.Vue.Store.Api.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pri.Vue.Store.Api.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pri.Vue.Store.Api.Core.Entities.Product", b =>
                {
                    b.HasOne("Pri.Vue.Store.Api.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
