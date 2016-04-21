# Streamable.dotNET
.NET API library for streamable.com

This is an implementation of API via C# for .NET applications

## How to
### 1 Create a client class
            var client = new StreamableAPI();

### 2 Your variables
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

### 6 Retrive video
            var res = client.Retrive("uz0t");

### 6 Retrive user
            var res = client.RetrieveUser("snmslavk");

### 6 Retrive auth user
            var res = client.RetrieveAuthUser(userName, password);
