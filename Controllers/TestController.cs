using Microsoft.AspNetCore.Mvc;
using System;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int count)
        {
            // Создание массива случайных чисел указанной размерности
            var random = new Random();
            var numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next();
            }

            return Ok(numbers);
        }
    }
}