using Microsoft.EntityFrameworkCore;

namespace КП.Infrastructure
{
    //------Не тестил, но в теории работает--------
    public static class DIContainer
    {
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();
        private static readonly Dictionary<Type, DbContext> _dbContexts = new Dictionary<Type, DbContext>();

        /// <summary>
        /// Регистрация конкретного экземпляра сервиса.
        /// </summary>
        /// <typeparam name="TService">Тип сервиса.</typeparam>
        /// <param name="service">Экземпляр сервиса.</param>
        public static void AddService<TService>(TService service)
        {
            _services[typeof(TService)] = service;
            Logger.Info($"Сервис {typeof(TService).Name} зарегистрирован.");
        }

        /// <summary>
        /// Регистрация сервиса по интерфейсу.
        /// Контейнер создаст экземпляр сервиса и автоматически внедрит зависимости.
        /// </summary>
        /// <typeparam name="TInterface">Интерфейс сервиса.</typeparam>
        /// <typeparam name="TImplementation">Класс, реализующий интерфейс.</typeparam>
        public static void AddService<TInterface, TImplementation>()
            where TImplementation : TInterface
        {
            _services[typeof(TInterface)] = CreateInstance(typeof(TImplementation));
            Logger.Info($"Сервис {typeof(TImplementation).Name} зарегистрирован как {typeof(TInterface).Name}.");
        }

        /// <summary>
        /// Регистрация базы данных.
        /// </summary>
        /// <typeparam name="TContext">Тип DbContext.</typeparam>
        /// <param name="connectionString">Строка подключения.</param>
        public static void AddDbContext<TContext>(string connectionString) where TContext : DbContext
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<TContext>();
                optionsBuilder.UseNpgsql(connectionString);

                var dbContext = (TContext)Activator.CreateInstance(typeof(TContext), optionsBuilder.Options);
                _dbContexts[typeof(TContext)] = dbContext;
                AddService(dbContext);

                Logger.Info($"База данных {typeof(TContext).Name} зарегистрирована.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Ошибка регистрации БД {typeof(TContext).Name}: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Получение зарегистрированного сервиса.
        /// </summary>
        /// <typeparam name="TService">Тип сервиса.</typeparam>
        /// <returns>Экземпляр сервиса.</returns>
        public static TService GetService<TService>()
        {
            return (TService)Resolve(typeof(TService));
        }

        /// <summary>
        /// Получение экземпляра базы данных.
        /// </summary>
        /// <typeparam name="TContext">Тип DbContext.</typeparam>
        /// <returns>Экземпляр контекста базы данных.</returns>
        public static TContext GetDbContext<TContext>() where TContext : DbContext
        {
            if (_dbContexts.TryGetValue(typeof(TContext), out var dbContext))
            {
                return (TContext)dbContext;
            }

            Logger.Error($"Ошибка: БД {typeof(TContext).Name} не зарегистрирована.");
            throw new InvalidOperationException($"База данных {typeof(TContext).Name} не зарегистрирована в DIContainer.");
        }

        /// <summary>
        /// Создаёт экземпляр класса, автоматически внедряя зарегистрированные зависимости.
        /// </summary>
        public static T CreateInstance<T>()
        {
            return (T)CreateInstance(typeof(T));
        }

        /// <summary>
        /// Создание экземпляра с автоматическим внедрением зависимостей.
        /// </summary>
        private static object CreateInstance(Type type)
        {
            try
        {
            var constructor = type.GetConstructors()
                .OrderBy(c => c.GetParameters().Length)
                .FirstOrDefault();

            if (constructor == null)
                throw new InvalidOperationException($"Не найден публичный конструктор для {type.FullName}");

            var parameters = constructor.GetParameters()
                .Select(p => Resolve(p.ParameterType))
                .ToArray();

            Logger.Info($"Создан экземпляр {type.Name}.");
            return Activator.CreateInstance(type, parameters);
        }
        catch (Exception ex)
        {
            Logger.Error($"Ошибка создания экземпляра {type.Name}: {ex.Message}");
            throw;
        }
        }

        /// <summary>
        /// Разрешение зависимостей (с проверкой зарегистрированных сервисов).
        /// </summary>
        private static object Resolve(Type type)
        {
            if (_services.ContainsKey(type))
                return _services[type];

            if (_dbContexts.ContainsKey(type))
                return _dbContexts[type];

            Logger.Error($"Ошибка: Сервис или БД {type.Name} не зарегистрированы в DIContainer.");
            throw new InvalidOperationException($"Сервис или БД {type.Name} не зарегистрированы в DIContainer.");
        }
    }
}
