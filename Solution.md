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
