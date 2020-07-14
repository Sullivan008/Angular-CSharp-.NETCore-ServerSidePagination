# Angular - C# .NET Core Web API - How to use Server-Side Pagination with Angular AgGrid Component. [Year of Development: 2020]

About the application technologies and operation:

### Technologies:

- Programming Language: C# - TypeScript
- FrontEnd Side: Angular CLI 9.1.1 (Node: 14.5.0)
- BackEnd Side: .NET Core 3.1 (Web API)
- Descriptive Language: HTML5
- Style Description Language: SCSS (Bootstrap 4.5)
- Other used modul FrontEnd Side:
  - rxjs (^6.5.5)
  - ag-grid-angular (^23.2.1)
  - ag-grid-community (^23.2.1)
- Other used modul BackEnd Side:
  - AutoMapper (v8.0.0)

### BackEnd Application solution structure:

- **Angular-ServerSidePagination-BackEnd**:
  - Includes Controllers.
  - Includes IoC DI Registers, with separate configuration files.
  - Includes Request and Response Models.
  - Includes AutoMapper Profiles.
- **Core.Extensions**:
  - Includes the core extensions (e.g.: QueryableExtension).
- **Core.Common**:
  - Includes the DTOs used for the application.
- **Business.Engine**:
  - Includes the necessary classes and interfaces to implement Business Logic.
  - Each Controller has it's own BL interface and class.
- **Business.Service**:
  - Includes the necessary classes and interfaces to implement internal business logic.
  - Each Business Engine has it's own BL interface and class.

### FrontEnd Application solution structure:

- **./src/Footer**:
  - Includes the Footer on the page.
- **./src/Header**:
  - Includes the Navigation Bar on the page.
- **./src/PageNotFound**:
  - Contains an item that the application loads if you navigate to the wrong URL.
- **./src/Dashboard**:
  - Contains the table of Users (AgGrid) on the page.
  - Includes the Service that implements HTTP Calls on the BackEnd side.
  - Includes ResponseModels for Server Side Responses.

### Installation/ Configuration:

1. **[BackEnd]** Restore necessary Packages on the selected project, run the following command in **PM Console**

   ```
   Update-Package -reinstall
   ```

2. **[FrontEnd]** If you do not already have the Angular CLI installed on your computer, so run the following command in CMD

   ```
   npm install -g @angular/cli
   ```

3. **[FrontEnd]** Restore necessary node_modules, so run the following command in GIT Bash Console in the application Angular-ServerSidePagination-FrontEnd root directory

   ```
   npm install
   ```

4. **[FrontEnd]** Start the application client side, so run the following command in GIT Bash Console in the application Angular-ServerSidePagination-FrontEnd root directory

   ```
   ng serve
   ```

### About the application:

The purpose of the web application is to list users in an **_AgGrid_** _table_ that can be operated by server-side pagination. User data is read from a MOCK.json file.

#### The application shows the following:

- How to implement **Generic Queryable OrderBy Extension**.
- How to use **IoC Container** in **ASP.NET Core**.
- How to separate **IoC Container Configurations** in **ASP.NET Core**.
- How to implement and register and using **AutoMapper** in **ASP.NET Core**.
- How to implement and use **HttpServices** in **Angular Component**.
- How to implement and use **AppRouting** in **Angular Component**.
- How to implement and use **AgGrid** in **Angular Component**.
- How to define **DefaultColDef**, **ColumnDefs**, **CacheOverflowSize**, **Components** and how to add this elements for **GridOptions**.
- How to define **FirstDataRendered**, **GridReady** events and how to connect this events to the **AgGrid**.
