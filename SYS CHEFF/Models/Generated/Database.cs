using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace SYS_CHEF
{

	public partial class SysChefRepo : Database
	{
        public static string ConnectionString = String.Format("Server={0};Port={1};User id={2};password={3};Database={4};",
            "localhost", 5432, "postgres", "p@ssw0rd", "syschefsolution");
        public static string ProviderName = "Npgsql";
		public SysChefRepo() : base(ConnectionString, ProviderName)
		{
			CommonConstruct();
		}

		public SysChefRepo(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			SysChefRepo GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static SysChefRepo GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new SysChefRepo();
        }

		[ThreadStatic] static SysChefRepo _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static SysChefRepo repo { get { return SysChefRepo.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    
	[TableName("products")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class product : SysChefRepo.Record<product>  
    {



		[Column] public long id { get; set; }





		[Column] public string description { get; set; }





		[Column] public int max_stock { get; set; }





		[Column] public int min_stock { get; set; }





		[Column] public int current_stock { get; set; }





		[Column] public int initial_stock { get; set; }





		[Column] public bool alter_in_sale { get; set; }





		[Column] public decimal value_cost { get; set; }





		[Column] public decimal value_sale { get; set; }





		[Column] public decimal value_gain { get; set; }





		[Column] public bool gain_in_percent { get; set; }





		[Column] public DateTime joined_at { get; set; }





		[Column] public long category_id { get; set; }





		[Column] public long provider_id { get; set; }





		[Column] public bool inactive { get; set; }



	}

    
	[TableName("users")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class user : SysChefRepo.Record<user>  
    {



		[Column] public long id { get; set; }





		[Column] public string full_name { get; set; }



        [Column] public string login { get; set; }





		[Column] public string password { get; set; }





		[Column] public bool admin { get; set; }





		[Column] public bool inactive { get; set; }





		[Column] public DateTime admitted_at { get; set; }





		[Column] public DateTime? dismissed_at { get; set; }





		[Column] public DateTime? last_access_at { get; set; }





		[Column] public string last_access_from { get; set; }

        [Column] public string phone { get; set; }



	}

    
	[TableName("entrance_stock")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class entrance_stock : SysChefRepo.Record<entrance_stock>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime entrance_at { get; set; }





		[Column] public long users_id { get; set; }





		[Column] public long cashier_id { get; set; }



	}

    
	[TableName("category_products")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class category_product : SysChefRepo.Record<category_product>  
    {



		[Column] public long id { get; set; }





		[Column] public string category_name { get; set; }



	}

    
	[TableName("products_entrance")]


	[PrimaryKey("id", autoIncrement=false)]

	[ExplicitColumns]
    public partial class products_entrance : SysChefRepo.Record<products_entrance>  
    {



		[Column] public string id { get; set; }





		[Column] public int quantity { get; set; }





		[Column] public decimal value_unitary { get; set; }





		[Column] public long products_id { get; set; }





		[Column] public long entrance_stock_id { get; set; }



	}

    
	[TableName("contact_clifor")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class contact_clifor : SysChefRepo.Record<contact_clifor>  
    {



		[Column] public long id { get; set; }





		[Column] public string contact { get; set; }





		[Column] public long clifor_id { get; set; }



	}

    
	[TableName("clifor")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class clifor : SysChefRepo.Record<clifor>  
    {



		[Column] public long id { get; set; }





		[Column] public string full_name { get; set; }





		[Column] public string document { get; set; }





		[Column] public string ie_rg { get; set; }





		[Column] public int type { get; set; }





		[Column] public string number { get; set; }





		[Column] public string complement { get; set; }





		[Column] public string state { get; set; }





		[Column] public DateTime joined_at { get; set; }





		[Column] public DateTime last_store { get; set; }



	}

    
	[TableName("outputs_stock")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class outputs_stock : SysChefRepo.Record<outputs_stock>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime output_at { get; set; }





		[Column] public string reason { get; set; }





		[Column] public long users_id { get; set; }



	}

    
	[TableName("products_output")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class products_output : SysChefRepo.Record<products_output>  
    {



		[Column] public long id { get; set; }





		[Column] public int quantity { get; set; }





		[Column] public long products_id { get; set; }





		[Column] public long outputs_stock_id { get; set; }



	}

    
	[TableName("products_sales")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class products_sale : SysChefRepo.Record<products_sale>  
    {



		[Column] public long id { get; set; }





		[Column] public int quantity { get; set; }





		[Column] public decimal value_unitary { get; set; }





		[Column] public long sales_id { get; set; }





		[Column] public long products_id { get; set; }



	}

    
	[TableName("email_clifor")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class email_clifor : SysChefRepo.Record<email_clifor>  
    {



		[Column] public long id { get; set; }





		[Column] public string email { get; set; }





		[Column] public long clifor_id { get; set; }



	}

    
	[TableName("requests")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class request : SysChefRepo.Record<request>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime opened_at { get; set; }





		[Column] public DateTime closed_at { get; set; }





		[Column] public long opened_by { get; set; }





		[Column] public long closed_by { get; set; }





		[Column] public bool closed { get; set; }





		[Column] public string tables_id { get; set; }





		[Column] public long cashier_id { get; set; }



	}

    
	[TableName("tables")]


	[PrimaryKey("id", autoIncrement=false)]

	[ExplicitColumns]
    public partial class table : SysChefRepo.Record<table>  
    {



		[Column] public string table_catalog { get; set; }





		[Column] public string table_schema { get; set; }





		[Column] public string table_name { get; set; }





		[Column] public string table_type { get; set; }





		[Column] public string self_referencing_column_name { get; set; }





		[Column] public string reference_generation { get; set; }





		[Column] public string user_defined_type_catalog { get; set; }





		[Column] public string user_defined_type_schema { get; set; }





		[Column] public string user_defined_type_name { get; set; }





		[Column] public string is_insertable_into { get; set; }





		[Column] public string is_typed { get; set; }





		[Column] public string commit_action { get; set; }





		[Column] public string id { get; set; }





		[Column] public int number { get; set; }





		[Column] public int location { get; set; }



	}

    
	[TableName("products_requests")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class products_request : SysChefRepo.Record<products_request>  
    {



		[Column] public long id { get; set; }





		[Column] public int quantity { get; set; }





		[Column] public decimal value_unitary { get; set; }





		[Column] public long requests_id { get; set; }





		[Column] public long products_id { get; set; }





		[Column] public long added_by { get; set; }



	}

    
	[TableName("properties")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class property : SysChefRepo.Record<property>  
    {



		[Column] public long id { get; set; }





		[Column] public string serial { get; set; }





		[Column] public string windows_id { get; set; }





		[Column] public int type_system { get; set; }





		[Column] public string licensed_to { get; set; }





		[Column] public string licensed_by { get; set; }





		[Column] public DateTime expiration_at { get; set; }



	}

    
	[TableName("cashiers")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cashier : SysChefRepo.Record<cashier>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime opened_at { get; set; }





		[Column] public DateTime closed_at { get; set; }





		[Column] public bool opened { get; set; }





		[Column] public bool locked { get; set; }





		[Column] public long apened_by { get; set; }





		[Column] public long closed_by { get; set; }





		[Column] public decimal value_closing { get; set; }


        [Column] public decimal value_opening { get; set; }        





		[Column] public long responsible { get; set; }



	}

    
	[TableName("sales")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class sale : SysChefRepo.Record<sale>  
    {



		[Column] public long id { get; set; }





		[Column] public DateTime sale_at { get; set; }





		[Column] public string table_id { get; set; }





		[Column] public long customer_id { get; set; }





		[Column] public long users_id { get; set; }





		[Column] public int payment_type { get; set; }





		[Column] public decimal payment_form { get; set; }





		[Column] public long cashier_id { get; set; }



	}

    
	[TableName("access_system")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class access_system : SysChefRepo.Record<access_system>  
    {



		[Column] public long id { get; set; }





		[Column] public long user_id { get; set; }





		[Column] public DateTime access_at { get; set; }





		[Column] public string access_from { get; set; }



	}


}