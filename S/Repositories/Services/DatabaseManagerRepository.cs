using S.Repositories.Interfaces;
using S.Tools;

namespace S.Repositories.Services;

public class DatabaseManagerRepository : IDatabaseManager
{
    public void Add(object item)
    {
		//try
		//{
		//	// Add item to Database
		//}
		//catch (Exception ex)
		//{
		//    File.WriteAllText(@"D:\Errors.txt", ex.ToString());
		//}

		try
		{
            // Add item to Database
        }
        catch (Exception ex)
		{
			FileLogger.Log(ex.ToString());
		}
    }
}
