# Gulomova

Лабораторная работа: авторизация пользователей и переход на форму по роли (Entity Framework Code First, Windows Forms, .NET Framework 4.7.2).

- БД `User_Data` (таблицы `Users`, `Roles`) — скрипт `Database/User_Data.sql`
- `FormAutorization` — вход по логину/паролю; в зависимости от роли открывается `FormManager` (1), `FormSeller` (2) или `FormDirector` (3)
- `FormParent` — родительская форма (имя, роль, фото); три формы ролей наследуются от неё

Тестовые пользователи: log1/pas1 (менеджер), log2/pas2 (продавец), log3/pas3 (директор), log4/pas4 (продавец), log5/pas5 (менеджер).

## Запуск
1. В SSMS выполнить `Database/User_Data.sql`.
2. Открыть `Gulomova.sln` в Visual Studio, восстановить NuGet (EntityFramework 6.4.4).
3. При необходимости поправить сервер в `Gulomova/App.config` (по умолчанию `.\SQLEXPRESS`).
4. Собрать и запустить. Папка `Photo` копируется в `bin\Debug` автоматически.
