# HittaHem – Backend API

This is the backend for **HittaHem**, a fullstack web application where users can submit dogs for rehoming or adoption.
This backend is built using the latest version of **.NET 8 / ASP.NET Core Web API** and is connected to the Angular frontend via RESTful endpoints. 
The project is hosted both locally and on **Azure App Service**.

---

## 🚀 Features

- REST API built with ASP.NET Core
- Upload dogs with image and metadata (form + file)
- Serve images as base64 or from static folder
- Register interest for a dog (counter)
- Input validation and file size/type checking
- CORS policy configured for both local and Azure frontend
- Deployable to Azure with environment switching

---

## 🔧 Technologies Used

- ASP.NET Core Web API (.NET 8 or later)
- C#
- In-memory data storage (List<Dog>)
- Controllers and DTOs
- File upload with `IFormFile`
- Image encoding (Base64)
- CORS configuration
- Hosted on Azure App Service

---

## 🌐 Live Deployment

The backend is hosted at:

```
hitta-hem-backend-fdg3h7g0gpfpfpc9.swedencentral-01.azurewebsites.net
```

---

## 📦 Local Setup

### 1. Clone the repository

```bash
git clone https://github.com/MikaelaJohansson/hitta-hem-backend.git
cd hittahem-backend
```

### 2. Run the application

```bash
dotnet run
```

By default, it runs on:

```
http://localhost:5171/
```

### 3. Test in browser or via frontend

- `GET /api/dogs` – Get all dogs
- `POST /api/dogs/upload` – Add a new dog with image
- `PUT /api/dogs/{id}` – Update a dog
- `DELETE /api/dogs/{id}` – Delete a dog
- `POST /api/dogs/interest/{id}` – Register adoption interest

---

## 📁 Folder Structure

```
HittaHem/
├── Controllers/
│   └── DogsController.cs        → All API routes
├── Models/
│   └── Dog.cs                   → Dog model
│   └── DogUploadDto.cs          → DTO for form uploads
├── Services/
│   └── DogService.cs            → In-memory data logic
├── Program.cs                   → CORS + pipeline setup
```

---

## 🔒 CORS Configuration

The backend accepts requests from:

- `http://localhost:4200` (local frontend)
- `https://hitta-hem-frontend-ftcfgmgkbbctdkgb.swedencentral-01.azurewebsites.net` (Azure frontend)

CORS is configured like this in `Program.cs`:

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins(
            "https://hitta-hem-frontend-ftcfgmgkbbctdkgb.swedencentral-01.azurewebsites.net",
            "http://localhost:4200"
        )
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

app.UseCors("AllowFrontend");
```

---

## 🧪 Example: Add Dog with Image (using Postman or frontend)

- **Method:** `POST`
- **URL:** `/api/dogs/upload`
- **Content-Type:** `multipart/form-data`
- **Body:**
  - `name`: "Hilda"
  - `age`: 9
  - `sex`: "Female"
  - `breed`: "Beagle"
  - `description`: "A gentle and curious dog..."
  - `imageFile`: (upload .jpg or .png)

---

## 🧠 Data Example

```json
{
  "id": 13,
  "name": "Hilda",
  "age": 9,
  "sex": "Hona",
  "breed": "Beagle",
  "description": "Hilda is a calm and curious dog...",
  "imageUrl": "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQE..."
}
```

---

## 👩‍💻 Developer

Backend developed by **Mikaela Johansson**

---

## 📎 Related Repositories

- 🔗 Frontend (Angular): [hittahem-frontend](https://github.com/MikaelaJohansson/hitta-hem.git)

