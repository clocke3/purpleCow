How To Build Solution in Visual Studio

To run purpleCow, you will need the following applications and software to run:
Visual Studio 2019 (https://visualstudio.microsoft.com/downloads/)
.Net 5.0.406 SDK (https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
Docker (https://docs.docker.com/get-docker/)

Please follow each link's directions on how to install.

To attain the repository from Github, you can do two things:
1) download a zip file of the main branch 
	a. I recommend this action if you are a novice with git 
	b. Make sure that after unzipping, place unzipped folder on computer. You will not be able to
	   load the project in Visual Studio otherwise.
2) clone repository 
	a. Due to the structure of the repo, you will need to encapsulate files in a folder 

After you have obtained the files, open Visual Studio and open a project. In the File Explorer. open the accurate solution file (.sln) in Visual Studio. 

Before building the solutions, please make sure all packages used in the code are downloaded as well on the VS IDE. This is just a simple installation that will require acceptation of terms and conditions. These packages are:

Microsoft.EntityFrameworkCore (v. 5.0.15)
Microsoft.EntityFrameworkCore.InMemory (v. 5.0.15)
Newtonsoft.Json (v. 13.0.1)

To build the solution and run the API, you can do also, either do two things:
1) in Visual Studio, press play button at top of window.
	a. This will open the url https://localhost:3000/items in your default browser 
2) in terminal, cd to the file folder where the solution resides and run the following commands in order:

dotnet build 
dotnet run

	a. After the run command, you will be able to navigate to the following url: https://localhost:3000/items. 

On the localhost, you will see an empty array (two brackets). Now you are ready to work with purpleCow!

Future Plans 

In the future, this API could power a lovely website with touches of HTML and CSS. But when it comes 
to near future code updates, I believe this API needs to find a way to display the updates 
without using a REST client to confirm half of the functions. It may be necessary to find a 
way to allow the user to input their changes from the browser itself. Additionally, I think it would be 
a good idea to be able to sort the items, such as depending on the names and the alphabet. Also, it would 
be nice to display the items on the browser outside of the JSON format. 

Assumptions 

Something to assume with utilizing purpleCow in its current state 
is that the user has a slight understanding of what occurs when using the 
REST client. If not, they can follow the wiki page on testing the functions. 
However, I also believe that these types of implementation can be a 
learning curve for some developers not used to web development. 

Implementation Challenges 

The biggest challenge of the purpleCow API currently is the need to use different 
endpoints for certain functions. For example, there are two separate functions for 
adding one item to the database and adding multiple. When coding, I came across an 
error saying that the functions are too similar, hence why we need to use a different 
endpoint. Hopefully in the future the HTTP POST functions can be encapsulated into one 
method. Also, currently the API uses an in memory database. This implementation means 
it's storage capabilities are limited to how much physical memory the system has. Also, this 
database only persists as long as the API is running. Items will be lost after the API stops. 
I would recommend connecting a third party database in order to hold that information for longer 
as well as not risk storage issues. However, for the moment this implementation is great because
we are in the forefront of our project and need it for fast testing. 
