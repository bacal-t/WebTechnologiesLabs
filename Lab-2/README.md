# Report

## Laboratory Work Nr.2:

### Objecticves: 

- Get familiar with MVC pattern.

### Framework: ASP.NET:

 The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication. The MVC framework is defined in the System.Web.Mvc assembly.
 
 The MVC framework includes the following components:
 
- Models. Model objects are the parts of the application that implement the logic for the application's data domain. Often, model objects retrieve and store model state in a database. For example, a Product object might retrieve information from a database, operate on it, and then write updated information back to a Products table in a SQL Server database.

- Views. Views are the components that display the application's user interface (UI). Typically, this UI is created from the model data. An example would be an edit view of a Products table that displays text boxes, drop-down lists, and check boxes based on the current state of a Product object.

- Controllers. Controllers are the components that handle user interaction, work with the model, and ultimately select a view to render that displays UI. In an MVC application, the view only displays information; the controller handles and responds to user input and interaction. For example, the controller handles query-string values, and passes these values to the model, which in turn might use these values to query the database.

##### Advantages of an MVC - Based Web Application:

- It makes it easier to manage complexity by dividing an application into the model, the view, and the controller.
- It does not use view state or server-based forms. This makes the MVC framework ideal for developers who want full control over the behavior of an application.

- It uses a Front Controller pattern that processes Web application requests through a single controller. This enables you to design an application that supports a rich routing infrastructure. For more information, see Front Controller.

#### Conclusion: 

During this laboratory work, I have learned how to work with MVC. I have used files from laboratory work nr.1 to integrate them in my project in Visual Studio. So in Content folder I have loaded all .css files. In Scripts I have added .js. And I have aslo used BundleConfig.cs (is nothing more than bundle configuration moved to separate file. It used to be part of app startup code (filters, bundles, routes used to be configured in one class)). And the main step was to understand how to configure layouts, so I have used _Layout.cshtml file, that contains the common elements of the page.





