namespace WebApplication3.Models
{
	public static class RepositoryHelper
	{
		public static IUnitOfWork GetUnitOfWork()
		{
			return new EFUnitOfWork();
		}		
		
		public static Alphabetical_list_of_productsRepository GetAlphabetical_list_of_productsRepository()
		{
			var repository = new Alphabetical_list_of_productsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Alphabetical_list_of_productsRepository GetAlphabetical_list_of_productsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Alphabetical_list_of_productsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static CategoriesRepository GetCategoriesRepository()
		{
			var repository = new CategoriesRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CategoriesRepository GetCategoriesRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CategoriesRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Category_Sales_for_1997Repository GetCategory_Sales_for_1997Repository()
		{
			var repository = new Category_Sales_for_1997Repository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Category_Sales_for_1997Repository GetCategory_Sales_for_1997Repository(IUnitOfWork unitOfWork)
		{
			var repository = new Category_Sales_for_1997Repository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Current_Product_ListRepository GetCurrent_Product_ListRepository()
		{
			var repository = new Current_Product_ListRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Current_Product_ListRepository GetCurrent_Product_ListRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Current_Product_ListRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Customer_and_Suppliers_by_CityRepository GetCustomer_and_Suppliers_by_CityRepository()
		{
			var repository = new Customer_and_Suppliers_by_CityRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Customer_and_Suppliers_by_CityRepository GetCustomer_and_Suppliers_by_CityRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Customer_and_Suppliers_by_CityRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static CustomerDemographicsRepository GetCustomerDemographicsRepository()
		{
			var repository = new CustomerDemographicsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CustomerDemographicsRepository GetCustomerDemographicsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CustomerDemographicsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static CustomersRepository GetCustomersRepository()
		{
			var repository = new CustomersRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CustomersRepository GetCustomersRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CustomersRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static EmployeesRepository GetEmployeesRepository()
		{
			var repository = new EmployeesRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static EmployeesRepository GetEmployeesRepository(IUnitOfWork unitOfWork)
		{
			var repository = new EmployeesRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static InvoicesRepository GetInvoicesRepository()
		{
			var repository = new InvoicesRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static InvoicesRepository GetInvoicesRepository(IUnitOfWork unitOfWork)
		{
			var repository = new InvoicesRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Order_DetailsRepository GetOrder_DetailsRepository()
		{
			var repository = new Order_DetailsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Order_DetailsRepository GetOrder_DetailsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Order_DetailsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Order_Details_ExtendedRepository GetOrder_Details_ExtendedRepository()
		{
			var repository = new Order_Details_ExtendedRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Order_Details_ExtendedRepository GetOrder_Details_ExtendedRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Order_Details_ExtendedRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Order_SubtotalsRepository GetOrder_SubtotalsRepository()
		{
			var repository = new Order_SubtotalsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Order_SubtotalsRepository GetOrder_SubtotalsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Order_SubtotalsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static OrdersRepository GetOrdersRepository()
		{
			var repository = new OrdersRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static OrdersRepository GetOrdersRepository(IUnitOfWork unitOfWork)
		{
			var repository = new OrdersRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Orders_QryRepository GetOrders_QryRepository()
		{
			var repository = new Orders_QryRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Orders_QryRepository GetOrders_QryRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Orders_QryRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Product_Sales_for_1997Repository GetProduct_Sales_for_1997Repository()
		{
			var repository = new Product_Sales_for_1997Repository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Product_Sales_for_1997Repository GetProduct_Sales_for_1997Repository(IUnitOfWork unitOfWork)
		{
			var repository = new Product_Sales_for_1997Repository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductsRepository GetProductsRepository()
		{
			var repository = new ProductsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductsRepository GetProductsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Products_Above_Average_PriceRepository GetProducts_Above_Average_PriceRepository()
		{
			var repository = new Products_Above_Average_PriceRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Products_Above_Average_PriceRepository GetProducts_Above_Average_PriceRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Products_Above_Average_PriceRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Products_by_CategoryRepository GetProducts_by_CategoryRepository()
		{
			var repository = new Products_by_CategoryRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Products_by_CategoryRepository GetProducts_by_CategoryRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Products_by_CategoryRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static RegionRepository GetRegionRepository()
		{
			var repository = new RegionRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static RegionRepository GetRegionRepository(IUnitOfWork unitOfWork)
		{
			var repository = new RegionRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Sales_by_CategoryRepository GetSales_by_CategoryRepository()
		{
			var repository = new Sales_by_CategoryRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Sales_by_CategoryRepository GetSales_by_CategoryRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Sales_by_CategoryRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Sales_Totals_by_AmountRepository GetSales_Totals_by_AmountRepository()
		{
			var repository = new Sales_Totals_by_AmountRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Sales_Totals_by_AmountRepository GetSales_Totals_by_AmountRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Sales_Totals_by_AmountRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ShippersRepository GetShippersRepository()
		{
			var repository = new ShippersRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ShippersRepository GetShippersRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ShippersRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Summary_of_Sales_by_QuarterRepository GetSummary_of_Sales_by_QuarterRepository()
		{
			var repository = new Summary_of_Sales_by_QuarterRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Summary_of_Sales_by_QuarterRepository GetSummary_of_Sales_by_QuarterRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Summary_of_Sales_by_QuarterRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static Summary_of_Sales_by_YearRepository GetSummary_of_Sales_by_YearRepository()
		{
			var repository = new Summary_of_Sales_by_YearRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static Summary_of_Sales_by_YearRepository GetSummary_of_Sales_by_YearRepository(IUnitOfWork unitOfWork)
		{
			var repository = new Summary_of_Sales_by_YearRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static SuppliersRepository GetSuppliersRepository()
		{
			var repository = new SuppliersRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static SuppliersRepository GetSuppliersRepository(IUnitOfWork unitOfWork)
		{
			var repository = new SuppliersRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static sysdiagramsRepository GetsysdiagramsRepository()
		{
			var repository = new sysdiagramsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static sysdiagramsRepository GetsysdiagramsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new sysdiagramsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static TerritoriesRepository GetTerritoriesRepository()
		{
			var repository = new TerritoriesRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static TerritoriesRepository GetTerritoriesRepository(IUnitOfWork unitOfWork)
		{
			var repository = new TerritoriesRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		
	}
}