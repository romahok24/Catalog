namespace ProductCatalog.Constants
{
    public static class Constants
    {
        public static class Roles
        {
            public const string Guest = nameof(Guest);
            public const string User = nameof(User);
            public const string SuperUser = nameof(SuperUser);
            public const string Admin = nameof(Admin);
        }

        public static class ErrorMessages
        {
            public const string CreateFailed = "Ошибка при создании: ";
            public const string AddingRoleFailed = "Ошибка добавления роли к пользователю: ";
            public const string NotFound = "Не найдено.";
            public const string DeleteFailed = "Ошибка при удалении данных: ";
            public const string ReadFailed = "Ошибка при получении данных: ";
            public const string BlockingUserFailed = "Ошибка при блокировке пользователя: ";
            public const string UpdateFailed = "Ошибка при обновлении данных: ";
            public const string UserWithEmailNotFound = "Пользователь с таким email не найден.";
            public const string InvalidPassword = "Неверный пароль";
            public const string UserBlocked = "Пользователь заблокирован";
            public const string NoRoles = "У пользователя нет ролей";
            public const string UserNameExists = "Пользователь с таким именем существует.";

            public const string ErrorMessage = nameof(ErrorMessage);
            public const string Unauthorized = nameof(Unauthorized);
        }

        public static class SuccessMessages
        {
            public const string Created = "Успешно созданно.";
            public const string Deleted = "Успешно удалено.";
            public const string Retrived = "Успешно получено.";
            public const string Updated = "Успешно обновленно.";
            public const string Blocked = "Пользователь успешно заблокирован.";
            public const string Logined = "Вход успешно произведен.";
            public const string Registred = "Регистрация успешно завершена.";

            public const string SuccessMessage = nameof(SuccessMessage);
        }

        public static class RoutingValues
        {
            public const string Id = "{id}";
            public const string Block = "block";
            public const string UpdatePassword = "update-password";
            public const string Roles = "roles";
            public const string Login = "login";
            public const string Register = "register";
            public const string Filter = "filter";
        }

        public static class BelarusBank
        {
            public const string Url = "https://api.nbrb.by/exrates/rates/USD?parammode=2";
            public const string ExchangeRateField = "Cur_OfficialRate";
        }

        public static class Log
        {
            public const string DateFormat = "dd.MM.yyyy HH:mm";
            public const string Header = "Authorization";
            public const string SuccessStatus = "Success";
            public const string FailedStatus = "Failed";
            public const string ExceptionStatus = "Exception";

            public const string LogInfoPattern = "Status: {0}|Date: {1}|Path: {2}|User: {3}";
            public const string LogExceptionPattern = "Status: {0}|Date: {1}|Path: {2}|User: {3}\nMessage: {4}";
        }

        public static class Views
        {
            public const string Index = nameof(Index);
            public const string Login = nameof(Login);
        }

        public static class Controllers
        {
            public const string Product = nameof(Product);
            public const string Account = nameof(Account);
            public const string Admin = nameof(Admin);
        }

        public static class Cookie
        {
            public const string AccessToken = nameof(AccessToken);
        }
    }
}
