using System;
namespace PropertyInspecor.Services
{
	public class AuthService
	{
		public async Task<bool> IsAuthenticatedAsync()
		{
			await Task.Delay(2000);
            return false;
		}
	}
}

