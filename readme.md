# Автосервисная система

## Описание проекта

"Автосервисная система" — это веб-приложение для управления автосервисом, позволяющее пользователям добавлять автомобили в очередь на обслуживание, администраторам изменять статус машин, а супер-администратору управлять администраторами. Проект включает две части: админ-панель и клиентскую часть.

## Стек технологий

- **Backend**: ASP.NET Core Web API
- **Frontend**: React, Tailwind CSS
- **База данных**: Entity Framework Core, SQL Server
- **Автоматизация**: Swagger UI для документирования API

## Основные функциональности

### Для пользователя:

- Регистрация и авторизация.
- Добавление автомобиля для обслуживания.
- Просмотр статуса своего автомобиля.

### Для администратора:

- Управление статусом автомобилей в очереди.
- Поиск автомобилей по номеру или VIN-коду.

### Для супер-администратора:

- Добавление, удаление и редактирование администраторов.
- Управление ролями пользователей.

## Структура проекта

- **Backend**:
  - `Controllers/` - содержит контроллеры для управления запросами к API.
  - `Models/` - содержит модели данных, такие как `User`, `Car`, `Role`.
  - `Services/` - бизнес-логика приложения.
  - `Data/` - настройка базы данных и миграции.
- **Frontend**:
  - `src/components/` - содержит компоненты для пользовательского интерфейса (например, навбар, карусели).
  - `src/pages/` - страницы проекта (например, домашняя страница, страница регистрации, страница авто).
- **Database**:
  - Миграции настроены с помощью Entity Framework Core.
  - База данных включает следующие сущности: Пользователь, Автомобиль, Роли, Статус автомобиля, Типы сервисов.

## API Эндпоинты

### Автомобили

- `GET /api/Cars` - получить список автомобилей.
- `POST /api/Cars` - добавить новый автомобиль.
- `GET /api/Cars/{id}` - получить информацию об автомобиле.
- `PUT /api/Cars/{id}` - обновить информацию об автомобиле.
- `PATCH /api/Cars/{id}/status` - изменить статус автомобиля.
- `DELETE /api/Cars/{id}` - удалить автомобиль.

### Пользователи

- `GET /api/Users` - получить список пользователей.
- `POST /api/Users` - создать нового пользователя.
- `GET /api/Users/{id}` - получить информацию о пользователе.
- `PUT /api/Users/{id}` - обновить информацию о пользователе.
- `DELETE /api/Users/{id}` - удалить пользователя.

### Роли

- `GET /api/Roles` - получить список ролей.
- `POST /api/Roles` - создать новую роль.
- `GET /api/Roles/{id}` - получить информацию о роли.
- `PUT /api/Roles/{id}` - обновить информацию о роли.
- `DELETE /api/Roles/{id}` - удалить роль.

## Установка и настройка

### Backend

1. Убедитесь, что у вас установлен .NET SDK.
2. Перейдите в папку backend проекта:
   ```bash
   cd backend
   ```
3. Установите зависимости и выполните миграции базы данных:
   ```bash
   dotnet restore
   dotnet ef database update
   ```
4. Запустите сервер
   ```bash
   dotnet run
   ```

### Frontend

1. Перейдите в папку frontend проекта
   ```bash
   cd frontend
   ```
2. Установите зависимости
   ```bash
   npm install
   ```
3. Запустите фронтенд-приложение
   ```bash
   npm start
   ```
