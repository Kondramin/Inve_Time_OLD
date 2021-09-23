﻿// <auto-generated />
using System;
using Inve_Time.DataBase.dll.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inve_Time.DataBase.dll.Migrations
{
    [DbContext(typeof(InveTimeDB))]
    [Migration("20210923113231_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Внешние аккумуляторы"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ноутбуки"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Рюкзаки/сумки/чемоданы"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Мобильные телефоны"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Чехлы/бампера/книги для телефона"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Защитные стёкла/плёнки"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Умные часы/браслеты"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ремешки для часов/браслетов"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Видеорегистраторы"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Карты памяти"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Батарейки"
                        },
                        new
                        {
                            Id = 12,
                            Name = "IP-камеры"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Мыши компьютерные"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Портативная аккустика"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Гарнитуры"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Сетевое оборудование"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Телевизоры"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Медиаплееры"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Умный дом"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Техника для уборки"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Транспорт"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Освещение"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Кабели"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Прочее"
                        });
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.CategorySearchWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategorySearchWords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "внешний"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "ноутбук"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "рюкзак"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Name = "сумка"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Name = "чемодан"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Name = "телефон"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            Name = "чехол"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            Name = "бампер"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            Name = "книга"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            Name = "стекло"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 6,
                            Name = "пленка"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 7,
                            Name = "браслет"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 7,
                            Name = "часы"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 8,
                            Name = "ремешок"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 9,
                            Name = "видеорегистратор"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 10,
                            Name = "памяти"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 11,
                            Name = "батар"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 12,
                            Name = "IP"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 13,
                            Name = "мышь"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 14,
                            Name = "колонка"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 15,
                            Name = "гарнитура"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 16,
                            Name = "Wi-Fi"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 17,
                            Name = "телевизор"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 18,
                            Name = "TV"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 19,
                            Name = "блок"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 19,
                            Name = "кнопка"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 19,
                            Name = "датчик"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 20,
                            Name = "пылесос"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 20,
                            Name = "швабра"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 21,
                            Name = "самокат"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 21,
                            Name = "велосипед"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 21,
                            Name = "гироскутер"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 22,
                            Name = "лампа"
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 23,
                            Name = "кабель"
                        });
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PasswodrId")
                        .HasColumnType("int");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "Admin",
                            Name = "Admin",
                            PasswodrId = 1,
                            PositionId = 1,
                            SecondName = "Admin"
                        });
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.InventarisationEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfEvent")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("InventarisationEvents");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Password", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[EmployeeId] IS NOT NULL");

                    b.ToTable("Passwords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            Name = "admin"
                        });
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessLevel = 10,
                            Name = "Администратор"
                        },
                        new
                        {
                            Id = 2,
                            AccessLevel = 5,
                            Name = "Менеджер магазина"
                        },
                        new
                        {
                            Id = 3,
                            AccessLevel = 1,
                            Name = "Продавец"
                        });
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.ProductBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductsBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductBase");
                });

            modelBuilder.Entity("InventarisationEventProductInvented", b =>
                {
                    b.Property<int>("InventarisationEventsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInventedsId")
                        .HasColumnType("int");

                    b.HasKey("InventarisationEventsId", "ProductInventedsId");

                    b.HasIndex("ProductInventedsId");

                    b.ToTable("InventarisationEventProductInvented");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.ProductInvented", b =>
                {
                    b.HasBaseType("Inve_Time.DataBase.dll.Entities.ProductBase");

                    b.Property<int>("AmountData")
                        .HasColumnType("int");

                    b.Property<int>("AmountFact")
                        .HasColumnType("int");

                    b.Property<int>("AmountResult")
                        .HasColumnType("int");

                    b.Property<bool>("Peresort")
                        .HasColumnType("bit");

                    b.Property<int?>("ProductBaseId")
                        .HasColumnType("int");

                    b.HasIndex("ProductBaseId");

                    b.HasDiscriminator().HasValue("ProductInvented");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.CategorySearchWord", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.Category", "Category")
                        .WithMany("CategorySearchWords")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Employee", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.InventarisationEvent", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.Employee", "ResponsibleForEvent")
                        .WithMany("InventarisationEvents")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("ResponsibleForEvent");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Password", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.Employee", "Employee")
                        .WithOne("Password")
                        .HasForeignKey("Inve_Time.DataBase.dll.Entities.Password", "EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.ProductBase", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("InventarisationEventProductInvented", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.InventarisationEvent", null)
                        .WithMany()
                        .HasForeignKey("InventarisationEventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inve_Time.DataBase.dll.Entities.ProductInvented", null)
                        .WithMany()
                        .HasForeignKey("ProductInventedsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.ProductInvented", b =>
                {
                    b.HasOne("Inve_Time.DataBase.dll.Entities.ProductBase", "ProductBase")
                        .WithMany("ProductInventeds")
                        .HasForeignKey("ProductBaseId");

                    b.Navigation("ProductBase");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Category", b =>
                {
                    b.Navigation("CategorySearchWords");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Employee", b =>
                {
                    b.Navigation("InventarisationEvents");

                    b.Navigation("Password");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Inve_Time.DataBase.dll.Entities.ProductBase", b =>
                {
                    b.Navigation("ProductInventeds");
                });
#pragma warning restore 612, 618
        }
    }
}
