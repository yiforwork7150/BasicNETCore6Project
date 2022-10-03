# BasicNETCore6Project
This is a basic .NET Core 6 Project, which is built in 3 layered architecture. Write specification file by Swashbuckle (Swagger + Swagger-ui)  
這是一個使用三層式架構的 .NET Core 6專案。並透過 Swashbuckle (Swagger + Swagger-ui) 來撰寫規格文件

## Enviroment
ASP.NET Core 6.0  
Swashbuckle 6.2.3

## What is 3 layered architecture ?（什麼是三層式架構）
<img src="https://media.geeksforgeeks.org/wp-content/cdn-uploads/20200103194305/NET-3-Tier-Architecture.png" width="450" style="display:block;margin: 0 auto;">  
 
Reference : https://igouist.github.io/post/2021/10/newbie-5-3-layer-architecture/  
 
### Presentation Layer（展示層）
Responsible for the parts that need to interact with users, such as receiving user requests, routing control, call flow control, etc.
The daily work is to actually receive the user's request, and then call the business logic layer to deal with it, and finally present the business logic layer to the user.
Most of the development will be done in Controller, ex. ProductController.  
 
負責搞定需要跟外部使用者互動的部份，例如接收使用者的請求、路由的控制、呼叫的流程控制等等。  
日常工作就是確實地接收使用者的請求，然後叫商業邏輯層去處理，最後把商業邏輯層弄好的東西奉上給使用者。  
大多時候的開發會在 Controller 進行，例如 ProductController。  
 
### Business Layer（商業邏輯層）
Responsible for processing business logic, which are business rules and related logic processing are performed here.  
The daily work is to receive calls from the presentation layer and to get data from the data access layer. In the process of this exchange, the content of the data is processed by business logic
Common suffixes are BLL, Service, etc., ex.  ProductService.  
 
負責處理商業邏輯，也就是商業規則和相關的邏輯處理都在這裡進行。  
日常工作就是接收展示層的呼叫、和資料存取層拿資料。在這個來往的過程中將資料內容進行商業邏輯的處理。  
常見的後綴有 BLL, Service 等等，例如 ProductService。  
 
### Data Layer（資料存取層）
As the name implies, it is responsible for the operations related to accessing data.  
The daily work is to obtain data from the database according to the requirements of the business logic layer.  
Common suffixes are DAL, Repository, etc., ex. ProductRepository.  
 
顧名思義，就是負責存取資料的相關操作。  
日常工作就是根據商業邏輯層的要求，去資料庫存取資料。  
常見的後綴有 DAL, Repository 等等，例如 ProductRepository。  

## What is Swagger & Why use Swagger?
https://swagger.io/
Swagger is a suite of tools for API developers from SmartBear Software and a former specification upon which the OpenAPI Specification is based.  
 
Swagger 是一間名為SmartBear Software 的公司，開發出的REST API 的工具，可以幫助設計、構建、記錄和使用REST API。  
後來貢獻給OpenAPI Initiative，並公開讓所有人都能夠使用。

Reference : https://dev.to/dianamaltseva8/why-use-swagger-for-creating-and-documenting-apis-115l

Swagger provides a set of great tools for designing APIs and improving the work with web services:  
* Swagger Editor – enables to write API documentation, design and describe new APIs, and edit the existing ones. The first open-source editor visually renders OAS/Swagger definition with error handling and real-time feedback.  
* Swagger Codegen – allows developers to generate client library code for different platforms. As the tool helps facilitate the dev process by generating server stubs and client SDKs, software engineers get the ability to faster build your API and better focus on its adoption.  
* Swagger UI – allows engineers to get self-generated documentation for different platforms. Swagger UI is a fully customizable tool that can be hosted in any environment. A great plus is that it enables developers to save a lot of time for API documentation.  
* Swagger Inspector – a tool for testing and auto-generating OpenAPI documentation for any API. Swagger Inspector allows to easily validate and test APIs with no limits on what you test. Tests are automatically saved in the cloud with a simple access.  
  
  
Swagger 提供了一組很棒的工具來設計 API 和改進 Web 服務的工作：  
* Swagger Editor – 能夠編寫 API 文檔、設計和描述新的 API，以及編輯現有的 API。  第一個開源編輯器通過錯誤處理和實時反饋直觀地呈現 OAS/Swagger 定義。  
* Swagger Codegen – 允許開發人員為不同平台生成客戶端庫代碼。  由於該工具通過生成服務器存根和客戶端 SDK 來幫助促進開發過程，因此軟件工程師能夠更快地構建您的 API 並更好地專注於其採用。  
* Swagger UI – 允許工程師為不同平台獲取自行生成的文檔。  Swagger UI 是一個完全可定制的工具，可以託管在任何環境中。  一個很大的優點是它使開發人員能夠為 API 文檔節省大量時間。  
* Swagger Inspector – 用於測試和自動生成任何 API 的 OpenAPI 文檔的工具。  Swagger Inspector 允許輕鬆驗證和測試 API，而對您測試的內容沒有任何限制。  通過簡單的訪問，測試會自動保存在雲中。  





