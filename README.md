# Streamable.dotNET
.NET API library for streamable.com

Streamable API implementation via C# for .NET applications

Link to official documentation 
https://streamable.com/documentation

## How to
### 0 Install
Use nuget console

            Install-Package Streamable.dotNET

### 1 Create a client class
            var client = new StreamableAPI();

### 2 Your temp variables
            string filePath = "c:\\temp\\zyra.mp4";
            string userName = "YourUserName";
            string password = "YourPass";
            string urlImport = "https://cdn.streamable.com/video/mp4/mjk3.mp4";

### 3 Get oEmbed object
            var res = client.GEToEmbed("https://streamable.com/uz0t");

### 4 Import from url
            var res = client.Import(urlImport,
                userName,
                password);

            var res = client.Import(urlImport);

### 5 Upload from computer
            var res = client.Upload(filePath, userName, password);
            var res = client.Upload(filePath);

### 7 Retrive video
            var res = client.Retrive("uz0t");

### 8 Retrive user
            var res = client.RetrieveUser("snmslavk");

### 9 Retrive auth user
            var res = client.RetrieveAuthUser(userName, password);
