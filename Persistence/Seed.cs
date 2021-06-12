using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Басктебол",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "В субботу на Немиге собираем команды для локального турнира.",
                    Category = "culture",
                    City = "Минск",
                    Venue = "Дворец Спорта",
                },
                new Activity
                {
                    Title = "Первый концерт новой группы 'Говорят крыши'",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Вход бесплатный.",
                    Category = "music",
                    City = "Минск",
                    Venue = "Брюгге",
                },
                new Activity
                {
                    Title = "Сходка художников-импрессионистов",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Главное выглядеть впечатляюще",
                    Category = "culture",
                    City = "Минск",
                    Venue = "Парк Горького",
                },
                new Activity
                {
                    Title = "Игра на гитаре",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Ищу напарника для обучения игре на гитаре",
                    Category = "music",
                    City = "Минск",
                    Venue = "Hotfix",
                },
                new Activity
                {
                    Title = "Открытие бара",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Скидки на пиво 50%",
                    Category = "drinks",
                    City = "Минск",
                    Venue = "Бар 'Новый бар'",
                },
                new Activity
                {
                    Title = "Закрытие бара",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Закрываемся, скидка на всё 70%",
                    Category = "drinks",
                    City = "Минск",
                    Venue = "Бар 'Закрытый бар'",
                },
                new Activity
                {
                    Title = "Прогулки на велосипеде",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Маршрут планируется длиной в 100км",
                    Category = "travel",
                    City = "Минск",
                    Venue = "33 студенческая поликлиника",
                },
                new Activity
                {
                    Title = "Вечер любительских фильмов",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Собственные работы приветствуются",
                    Category = "film",
                    City = "Минск",
                    Venue = "Дворец культуры",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}