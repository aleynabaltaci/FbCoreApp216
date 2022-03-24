******************************** 1.Gün ********************************
-Blank Solution oluþturduk
-Katmanlý mimari için ilgili projeleri solutiona ekleme(Api(Asp .Net Core Api) - Core(Class Library) - Data(Class Library) - Mvc(Asp .Net Core Mvc)-Service(Class Library)


-Core katmaný-
	-Model Klasörü olusturduk.Icýnde BaseEntity Category ve Product classlarýný yazdýk.
	-Category ve product classlarýna BaseEntity classýný miras verdik.
	-Bu classlar ayný zamanda Db de tablolara dönüþeceði için propertylerle doldurduk.
	-Product ve Category arasýndaki foreign key baðlantýsýný navigation propertylerle saðladýk.

	-Repository klasörünü oluþturduk(Interface yapýlarý inþaa etmek için.)
	-IRepository de Crud iþlerimlerini tanýmladik.
	-ICategoryRepository de Category sýnýfý için ihtiyacýmýz olan db islemleri icin ayrýca interface oluþturduk.
	-IProductRepository de Product sýnýfý için ihtiyacýmýz olan db islemleri icin ayrýca interface oluþturduk.

	-Service klasörü ekledik amacýmýz Api ve Mvc katmanlarýnýn Repository üzerinden deðil de service katmaný üzerinden haberleþtirmek için.

	-UnitOfWork klasörü db de nihai kayýt komutu olan SaveChange() komutunu Repositoryden ayýrarak crud iþlemleri ile kayýt arasýnda ihtiyacýmýz
	olmasý durumunda kod ekleme için kullanacaðýz.



-Data Katmaný-
	**Kullanýlan Kütüphaneler
	**Microsoft.EntityFrameworkCore
	**Microsoft.EntityFrameworkCore.Design
	**Microsoft.EntityFrameworkCore.SqlServer
	**Microsoft.EntityFrameworkCore.Tools


	-Projenin Context sýnýfýný burada oluþturduk(AppDbContext) bu sýnýfa entityframeworkdeki DbContext() sýnýfýný miras verdil

	-AppDbContext içinde DbSet<> iþlemlerini gerçekleþtirdik. Migration iþlemi baþladýðýnda classlarýmýz db'de Tablellara dönüþtürülürken
	gerekli olan property ayarlarýný onModelCreating metoduyla FluentApi kullanarak tablolarýmýzýn propertylerini düzenledik
	
	-Dbde tablolarýmýz oluþtuktan sonra Seed metodunu kullanarak oluþan tablolara test datalarý yükledik.

	-Context ile Db arasýndaki baðlantýyý Api katmaný üzerindeki appsetting.json dosyasýný kullanrak connectionstring ifadesini ekledik.


******************************** 2.Gün ********************************
-Api Katmaný-
	**AutoMapper.Extensions.Microsoft.DependencyInjection

	-Dto dosyasýnda CategoryDto,ProductDto sýnýflarý eklenerek propertyler ve requiredlar yazýldý. CategoryWithProduct ve ProductWithCategory arasýnda navigasyon yazýldý.

	-Mapping Klasöründeki MapProfile sýnýfý ile Dtolarýn Mapping iþlemi yapýldý.

	-CategoryController eklenerek HttpGet(GetAll,GetById) metodlarý yazýldý.
	-Constructorda category service ve mapperlara atama yapýldý.

-Data Katmaný-

	-UnitOfWork classý eklenerek SaveChanges ve SaveChangesAsync eklendi.
	
-Service Katmaný-

	-CategoryService classýnda Service<Category> ve ICategoryService'den miras aldýk.







