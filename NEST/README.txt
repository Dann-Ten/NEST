Program Setup:

1) Download the NEST back end.
2) Download the VUE front end.
3) Place the VUE section inside of the back end, at the same file level as the Data, Migrations and Controllers.
4) Inside of Visual Studio, go to Developer Powershell. Type in "VUE UI".
5) Within the VUE UI interface, go to VUE Project Manager and import the Vue front end from where it is saved inside the project.
6) Run the VUE front end.
7) Provided the Vue front end is on port 8080, ignore this step. If it is for some reason
on a different port number, go to the Startup CS file in the back end and scroll to the bottom.
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:8080");
You will need to change the above line of code to reflect the appropriate port.
8) Open SQL Server Object Explorer. Find the LocalDBMSQL or whatever your choice of SQL database is.
 Click on it and inside of Properties, grab the Connection string. You will then need to go to 
the appsettings.json file and copy paste this string into defaultConnection.
9) Migrate the project. Inside of PackageManagerConsole, type in"Add-Migration InitialCreate"(You may not need to do this if the Migration carries over).
Following this, type in "Update-Database". This will seed your MSQL with the necessary tables.
10) Run the application. Everything should boot.

At some point I will need to create a script that will do this component of the setup.