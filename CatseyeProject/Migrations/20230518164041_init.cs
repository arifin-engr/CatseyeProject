using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblBrowserCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountNumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBrowserCount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCollection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCollection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Mobile = table.Column<long>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblHomBanner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    HomeImage = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHomBanner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ColorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblreasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblreasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblReturnReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    FlatDamageFee = table.Column<float>(nullable: false),
                    PerDamageFee = table.Column<float>(nullable: false),
                    RefundShippingFeee = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblReturnReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblsearch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Search = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblsearch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblToken",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TokenName = table.Column<string>(nullable: true),
                    Amountflat = table.Column<int>(nullable: false),
                    AmountPercentage = table.Column<float>(nullable: false),
                    validationToDate = table.Column<DateTime>(nullable: false),
                    validationFromDate = table.Column<DateTime>(nullable: false),
                    IsRange = table.Column<bool>(nullable: false),
                    RangeAmount = table.Column<float>(nullable: false),
                    ValidatePerson = table.Column<int>(nullable: false),
                    Isactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblBilling",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBilling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBilling_tblCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblShipping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblShipping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblShipping_tblCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    SubName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSubCategory_tblProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tblProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblcontractus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ReasonId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblcontractus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblcontractus_tblreasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "tblreasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    ShippingId = table.Column<int>(nullable: false),
                    BillingId = table.Column<int>(nullable: false),
                    shipCharage = table.Column<float>(nullable: false),
                    ShippingLabel = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<float>(nullable: false),
                    PaymentToken = table.Column<string>(nullable: true),
                    ReturnAmount = table.Column<float>(nullable: false),
                    IsDelivered = table.Column<bool>(nullable: false),
                    Islabelprint = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblBilling_BillingId",
                        column: x => x.BillingId,
                        principalTable: "tblBilling",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblShipping_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "tblShipping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "tblproductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    SubcategoryId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    catsProductSubCategoriesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblproductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblproductTypes_tblSubCategory_catsProductSubCategoriesId",
                        column: x => x.catsProductSubCategoriesId,
                        principalTable: "tblSubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CollectionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Islive = table.Column<bool>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    NameTag = table.Column<string>(nullable: true),
                    Discription = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Sizechart = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOrderDetails_tblCollection_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "tblCollection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrderDetails_tblproductTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "tblproductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbldescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbldescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbldescription_tblOrderDetails_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblOrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProductdetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    sizeId = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    Newprice = table.Column<float>(nullable: false),
                    Cost = table.Column<float>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discount = table.Column<float>(nullable: false),
                    vat = table.Column<float>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true),
                    barcodeImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductdetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProductdetails_tblOrderDetails_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblOrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblProductdetails_ProductSizes_sizeId",
                        column: x => x.sizeId,
                        principalTable: "ProductSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    catsProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblRating_tblOrderDetails_catsProductId",
                        column: x => x.catsProductId,
                        principalTable: "tblOrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCatsCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    isProcess = table.Column<bool>(nullable: false),
                    Isinvoice = table.Column<bool>(nullable: false),
                    CatsProductdetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCatsCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCatsCart_tblProductdetails_CatsProductdetailsId",
                        column: x => x.CatsProductdetailsId,
                        principalTable: "tblProductdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCatsCart_tblCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCatsSelseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    SalesAmount = table.Column<double>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    CatsProductdetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCatsSelseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCatsSelseDetails_tblProductdetails_CatsProductdetailsId",
                        column: x => x.CatsProductdetailsId,
                        principalTable: "tblProductdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCatsSelseDetails_tblOrderDetails_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblOrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    ReasonId = table.Column<int>(nullable: true),
                    ProductdetailsId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ReturnQuantity = table.Column<int>(nullable: false),
                    IsReturned = table.Column<bool>(nullable: false),
                    DamageFee = table.Column<float>(nullable: false),
                    ReturnSubmitDate = table.Column<DateTime>(nullable: false),
                    Subtotal = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "tblOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblProductdetails_ProductdetailsId",
                        column: x => x.ProductdetailsId,
                        principalTable: "tblProductdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblReturnReasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "tblReturnReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblStockInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ProductdetailsId = table.Column<int>(nullable: false),
                    CurrentStock = table.Column<int>(nullable: false),
                    ProductPurchase = table.Column<int>(nullable: false),
                    SaleProduct = table.Column<int>(nullable: false),
                    TotalStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStockInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblStockInformation_tblProductdetails_ProductdetailsId",
                        column: x => x.ProductdetailsId,
                        principalTable: "tblProductdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCatsCartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    productdetailsId = table.Column<int>(nullable: false),
                    CartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCatsCartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCatsCartDetails_tblCatsCart_CartId",
                        column: x => x.CartId,
                        principalTable: "tblCatsCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCatsCartDetails_tblProductdetails_productdetailsId",
                        column: x => x.productdetailsId,
                        principalTable: "tblProductdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblBilling_CustomerId",
                table: "tblBilling",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCatsCart_CatsProductdetailsId",
                table: "tblCatsCart",
                column: "CatsProductdetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCatsCart_CustomerId",
                table: "tblCatsCart",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCatsCartDetails_CartId",
                table: "tblCatsCartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCatsCartDetails_productdetailsId",
                table: "tblCatsCartDetails",
                column: "productdetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCatsSelseDetails_CatsProductdetailsId",
                table: "tblCatsSelseDetails",
                column: "CatsProductdetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCatsSelseDetails_ProductId",
                table: "tblCatsSelseDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tblcontractus_ReasonId",
                table: "tblcontractus",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_tbldescription_ProductId",
                table: "tbldescription",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_BillingId",
                table: "tblOrder",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_CustomerId",
                table: "tblOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_ShippingId",
                table: "tblOrder",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetails_CollectionId",
                table: "tblOrderDetails",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetails_TypeId",
                table: "tblOrderDetails",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_OrderId",
                table: "tblProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_ProductdetailsId",
                table: "tblProduct",
                column: "ProductdetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_ReasonId",
                table: "tblProduct",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductdetails_ProductId",
                table: "tblProductdetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductdetails_sizeId",
                table: "tblProductdetails",
                column: "sizeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblproductTypes_catsProductSubCategoriesId",
                table: "tblproductTypes",
                column: "catsProductSubCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRating_catsProductId",
                table: "tblRating",
                column: "catsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tblShipping_CustomerId",
                table: "tblShipping",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStockInformation_ProductdetailsId",
                table: "tblStockInformation",
                column: "ProductdetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSubCategory_CategoryId",
                table: "tblSubCategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tblBrowserCount");

            migrationBuilder.DropTable(
                name: "tblCatsCartDetails");

            migrationBuilder.DropTable(
                name: "tblCatsSelseDetails");

            migrationBuilder.DropTable(
                name: "tblcontractus");

            migrationBuilder.DropTable(
                name: "tbldescription");

            migrationBuilder.DropTable(
                name: "tblHomBanner");

            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblProductColors");

            migrationBuilder.DropTable(
                name: "tblRating");

            migrationBuilder.DropTable(
                name: "tblsearch");

            migrationBuilder.DropTable(
                name: "tblStockInformation");

            migrationBuilder.DropTable(
                name: "tblToken");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tblCatsCart");

            migrationBuilder.DropTable(
                name: "tblreasons");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblReturnReasons");

            migrationBuilder.DropTable(
                name: "tblProductdetails");

            migrationBuilder.DropTable(
                name: "tblBilling");

            migrationBuilder.DropTable(
                name: "tblShipping");

            migrationBuilder.DropTable(
                name: "tblOrderDetails");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.DropTable(
                name: "tblCustomers");

            migrationBuilder.DropTable(
                name: "tblCollection");

            migrationBuilder.DropTable(
                name: "tblproductTypes");

            migrationBuilder.DropTable(
                name: "tblSubCategory");

            migrationBuilder.DropTable(
                name: "tblProductCategory");
        }
    }
}
