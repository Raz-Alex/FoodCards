using FoodCards.Shared;
using System.Net;
using System.Net.Http.Json;

namespace FoodCards.Client.Services
{
    public class AuthorizeHttpClient
    {
        readonly LocalStorage storage;
        readonly HttpClient httpClient;
        readonly AuthorizeMonitorService monitor;

        public AuthorizeHttpClient(LocalStorage storage, HttpClient httpClient, AuthorizeMonitorService monitor)
        {
            this.storage = storage;
            this.httpClient = httpClient;
            this.monitor = monitor;
        }

        public async Task<T?> GetAsync<T>(string requestUri)
        {
            var httpResponse = await httpClient.GetAsync(requestUri);

            try
            {
                var result = await httpResponse.Content.ReadFromJsonAsync<T>();
                if (result != null)
                    return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return default;
        }

        public async Task<T?> PostAsync<T>(string requestUri)
        {
            var token = await storage.GetAsync<Guid>(ConstValues.UserToken);
            return await MainPostAsync<T, UserToken<T>>(requestUri, new UserToken<T>(token));
        }

        public async Task<T?> PostAsync<T, P>(string requestUri, P content)
        {
            var token = await storage.GetAsync<Guid>(ConstValues.UserToken);
            var userToken = new UserToken<P>(token) { Obj = content };
            return await MainPostAsync<T, UserToken<P>>(requestUri, userToken);
        }

        private async Task<T?> MainPostAsync<T, P>(string requestUri, P content)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var httpResponse = await httpClient.PostAsJsonAsync<object>(requestUri, content, token);

            await storage.RemoveAsync(ConstValues.UserToken);

            if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
            {
                monitor.RecheckAuthorization();
                return default;
            }

            try
            {
                var result = await httpResponse.Content.ReadFromJsonAsync<UserToken<T>>();
                if (result != null)
                {
                    await storage.SetAsync(ConstValues.UserToken, result.Token);
                    return result.Obj;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return default;
        }
    }
}
