using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL4.Methods.DeleteMethods
{
    public class DeleteCategory
    {
        private static async Task<string> DeleteCategoryApi(int categoryId)
        {
            string apiUrl = $"https://localhost:44370/api/Category/categories/{categoryId}";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        return "Category deleted successfully.";
                    }
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error in the request: {ex.Message}");
                throw;
            }
        }

        public static async Task DeleteCategoryWithId()
        {
            Console.WriteLine("Give category ID:\n");
            int categoryId = int.Parse(Console.ReadLine());
            string response = await DeleteCategoryApi(categoryId);
            Console.WriteLine(response);
        }
    }
}
