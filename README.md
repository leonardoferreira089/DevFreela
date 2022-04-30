<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/leonardoferreira089/DevFreela?color=%2304D361">
  <img alt="Repository size" src="https://img.shields.io/github/repo-size/leonardoferreira089/DevFreela">  
  <a href="https://github.com/lucianfiocello/devfreela/tree/main">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/leonardoferreira089/DevFreela">
  </a>    
</p>

<h1 align="center">
    DevFreela
</h1>

## 🖥️ About the project

DevFreela - Web platform for registering and hiring freelance developers

Project was developed during the course <b>'Formação ASP.NET Core'</b> from <i>Método .NET Direto ao Ponto.</i>

---
<br />

## ⚙️ Tools and Technologies

- Swagger
- Clean Architecture
- Layers -> Core, Infrastructure, Application, API
- Entity Framework Core
- Dapper
- CQRS
- MediatR
- JWT -> Json Web Token
- xUnit -> For unit tests

---
<br />

## 🎛️ Functionalities

- Freelance Service Creation, Update, Delete and service persistence;
- User registration and Freelancer and Client profiles;
- Add Comments for a Freelancer Service
- Define, Start and Finish Project

---
<br />

## Swagger
Swagger is a framework witch has several tools that, regardless of language, helps the description, consumption and visualization of REST API services.
Swagger allows you to describe the structure of your APIs so that machines can read them.
Through this tool it is possible to execute the methods implemented in the API controllers as well as obtain a complete documentation of the API.

![01-Swagger](https://user-images.githubusercontent.com/61693671/166118587-4f3ac45f-ee99-4c85-b38d-f007c2e92c14.png)

---
<br />

## Clean Architecture
<b><i>Clean Architecture</i></b> is a software architecture proposed by Robert Cecil Martin (or Uncle Bob, as he is better known) that aims to standardize and organize the developed code, favoring its reusability, as well as technology independence. Also known as Onion Architecture, this architecture works well with DDD, due to being domain-centric, where its directed coupling emphasizes that the core does not depend on anything, so that we can even test it in isolation.
Clean Architecture tries to provide a methodology to be used in coding in order to make code development easier, allow for better maintenance, updating and fewer dependencies.
An important goal of Clean Architecture is to provide developers with a way to organize code in a way that encapsulates business logic but keeps it separate from the delivery mechanism.
![02-Clean-Architecture-graph](https://user-images.githubusercontent.com/61693671/166118705-6beddfb3-25ca-411d-bd4c-c233d85e17e2.png)

---
<br />

## Entity Framework Core
The Entity Framework is an ORM (Object-relational mapping) tool that allows the developer to work with relational data in the form of domain-specific objects. Entity allows us to map the elements of our database to the elements of our object-oriented application. The use of ORMs (Object-Relational Mappers) helps in productivity and the Entity Framework is one of the best frameworks in this topic.
![03-EntityFrameworkCore01](https://user-images.githubusercontent.com/61693671/166118771-1e06d4f9-07a4-4ac7-b630-c98cbc10045c.png)

---
<br />

## Dapper
Dapper is an ORM (Object Relational Mapping) aimed at .NET development, where its main objective is to improve the performance of database queries. It doesn't have the full range of an ORM but it makes it much easier to develop better performing applications. Dapper works with the concept of Extension methods, where it implements an extension method of the database connection class, where when querying the database, it will map the return from the Data Reader to the Data Model.

![04-Dapper](https://user-images.githubusercontent.com/61693671/166118820-cef23d54-6a7e-4297-8920-109835f22e09.jpg)

---
<br />

## CQRS
Command Query Responsibility Segregation, ou CQRS, is a software development architecture pattern that summarizes the separation of reading and writing into two models: query and command, one for reading and one for writing data, respectively.
![05-CQRS](https://user-images.githubusercontent.com/61693671/166118851-d3116c6c-20f5-4dfb-b59c-8da40d0020b7.jpg)

---
<br />

## MediatR
Mediator is a Behavioral design pattern created by GoF, which helps us ensure low coupling between the objects in our application. It allows an object to communicate with others without knowing their structures. 
The essence of the Mediator Pattern is to “define an object that encapsulates how a set of objects interact”. It promotes loose coupling by keeping objects from referring to each other explicitly, and it allows their interaction to be varied independently.
In other words, we can say that the Mediator Pattern manages the interactions of different objects. Through a mediator class, it centralizes all interactions between objects, aiming to reduce coupling and dependence between them. Thus, in this pattern, objects do not talk directly to each other, all communication must go through the mediator class.
![06-Microservice](https://user-images.githubusercontent.com/61693671/166118886-8bc223ae-624e-4931-8306-8f42b85f0f6e.png)
851-d3116c6c-20f5-4dfb-b59c-8da40d0020b7.jpg)

---
<br />

## Json Web Token - JWT
JWT (JSON Web Token) is an industry standard RCT 7519 method for performing authentication between two parties via a signed token that authenticates a web request. This token is a Base64 code that stores JSON objects with the data that allows authentication of the request.
![07-JWT](https://user-images.githubusercontent.com/61693671/166118950-468386a2-d12f-4f93-b72e-e2e910bbfb35.jpg)

---
<br />

Messaging with RabbitMQ
Messaging enables software applications to connect and scale. Applications can connect to each other, as components of a larger application, or to user devices and data. Messaging is asynchronous, decoupling applications by separating sending and receiving data. In messaging, a message can be defined as a data structure composed of metadata such as source/destination host, destination queue, etc., in addition to data provided by the application, for example the data of a customer to be registered.

RabbitMQ is a messaging broker - an intermediary for messaging. It gives your applications a common platform to send and receive messages, and your messages a safe place to live until received.
With RabbitMQ it is possible to handle message traffic quickly and reliably, in addition to being compatible with several programming languages, having a native administration interface and being cross-platform.
![08-RabbitMQ](https://user-images.githubusercontent.com/61693671/166119073-f38224d5-3de4-4f0f-aab2-c71c569e874e.png)
![08-RabbitMQ02](https://user-images.githubusercontent.com/61693671/166119127-c8ed4db1-64b9-404d-a634-0a5f5e4bc45f.png)


---
<br />

## xUnit
Free and open-source tool for unit testing, being the main option currently along with NUnit. Works with .NET Core, .NET Framework, Universal Windows Apps and Xamarin. It has its own template for .NET Core, both via the command line and through Visual Studio 2019. In an xUnit test project, just create a class and insert the method with the annotation [Fact].
![10-xUnit](https://user-images.githubusercontent.com/61693671/166120408-90189ccf-2505-470b-857a-b4533fc2dc70.png)



---

### Autor

 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/leonardoferreira089" width="100px;" alt=""/>
 
 <br />
 <sub><b>Leonardo Ferreira</b></sub>
 
[![Linkedin Badge](https://img.shields.io/badge/-Leonardo-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/leonardoferreira089/)](https://www.linkedin.com/in/leonardoferreira089/)
[![Gmail Badge](https://img.shields.io/badge/-leonardo.ferreira089%40gmail.com-red?style=flat-square&logo=Gmail&logoColor=white&link=mailto:leonardoferreira089@gmail.com)](mailto:leonardoferreira089@gmail.com)

---
